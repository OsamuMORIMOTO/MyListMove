using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;

using Plugin;
using NicoLibrary;

using NLog;

namespace MyListMove
{
    public partial class VideoInfoWindow : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private IPluginHost pluginHost;

        /// <summary>
        /// 
        /// </summary>
        private List<VideoInfoPanel> videoInfoList = new List<VideoInfoPanel>();

        private TimeSpan timeSum;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commentID"></param>
        /// <param name="UserID"></param>
        /// <param name="videoURL"></param>
        /// <returns></returns>
        delegate bool AddVideoInfoCallback(string commentID, string UserID, string videoURL);

        /// <summary>
        /// 
        /// </summary>
        public VideoInfoWindow(IPluginHost plgin)
        {
            InitializeComponent();
            timeSum = new TimeSpan(0);
            pluginHost = plgin;
        }

        /// <summary>
        /// テストボタン
        /// TODO:実装完了後、削除すること
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AddVideoInfo("0123", "テストID", "http://www.nicovideo.jp/watch/sm2140648");

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="commentID"></param>
        /// <param name="UserID"></param>
        /// <param name="videoURL"></param>
        public void AddVideoInfoCommand(string commentId, string UserId, string videoURL)
        {

            Logger logger = LogManager.GetCurrentClassLogger();

            if (this.InvokeRequired)
            {
                try
                {
                    AddVideoInfoCallback delegateMethod = new AddVideoInfoCallback(AddVideoInfo);

                    bool value = (bool)this.Invoke(delegateMethod,commentId,UserId,videoURL);
                    logger.Info("Invoke return:" + value.ToString());
                }
                catch (Exception ex)
                {
                    
                }

            }
            else
            {
                AddVideoInfo(commentId, UserId, videoURL);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="userId"></param>
        /// <param name="videoURL"></param>
        /// <returns></returns>
        public bool AddVideoInfo (string commentId, string userId, string videoURL)
        {

            string videoId;

            if (!anariseCommentURL(videoURL, out videoId))
            {
                return false;
            }

            // 動画情報取得
            string URLString = "http://www.nicovideo.jp/api/getthumbinfo/" + videoId;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(URLString);

                string tempTitle = "";
                string tempTime = "";
                string tempURL = "";
                string thumbnail = "";

                XmlNodeList node1 = doc.GetElementsByTagName("title");
                if (node1.Count >= 1) tempTitle = node1[0].InnerText;
                XmlNodeList node2 = doc.GetElementsByTagName("length");
                if (node2.Count >= 1) tempTime = node2[0].InnerText;
                XmlNodeList node3 = doc.GetElementsByTagName("watch_url");
                if (node3.Count >= 1) tempURL = node3[0].InnerText;
                XmlNodeList node4 = doc.GetElementsByTagName("thumbnail_url");
                if (node4.Count >= 1) thumbnail = node4[0].InnerText;

                // 動画情報パネル追加
                VideoInfoPanel tempVideoInfoPanel = new VideoInfoPanel();
                
                tempVideoInfoPanel.CommentNo = commentId;
                tempVideoInfoPanel.UserID = userId;
                tempVideoInfoPanel.VideoTitle = tempTitle;
                tempVideoInfoPanel.VideoTime = tempTime;
                tempVideoInfoPanel.VideoURL = tempURL;
                tempVideoInfoPanel.ThumbnailURL = thumbnail;

                // 合計時間　加算
                TimeSpan interval = new TimeSpan(0,Int32.Parse(tempTime.Split(':')[0]), Int32.Parse(tempTime.Split(':')[1]));
                timeSum += interval;
                this.labelTimeSum.Text = timeSum.ToString(@"mm\:ss");

                Point tempPoint = new Point(3, 10 + (tempVideoInfoPanel.Size.Height * videoInfoList.Count));
                tempPoint.Offset(panelVideoInfoList.AutoScrollPosition);
                tempVideoInfoPanel.Location = tempPoint;

                ShowReqInfo2BSP(userId, videoId);

                tempVideoInfoPanel.EventManageButtonClick += new VideoInfoEventHandler(ManageButtonsClick);

                videoInfoList.Add(tempVideoInfoPanel);

                panelVideoInfoList.Controls.Add(videoInfoList.Last());
                
            }
            catch (Exception ex)
            {
                return false;
            }
            
            return true;

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageButtonsClick(object sender, VideoInfoEventArg e)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info("UserID:" + e.UserID);

            string videoId = e.VideoURL.Replace("http://www.nicovideo.jp/watch/", "");

            this.ShowVideoInfo2Own(e.VideoTitle, videoId, e.UserID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="receivedComment"></param>
        /// <returns></returns>
        private bool anariseCommentURL(string receivedComment, out string videoId)
        {

            videoId = "";

            if (!receivedComment.Contains("http://www.nicovideo.jp/watch/"))
            {
                return false;
            }
            
            videoId = receivedComment.Replace("http://www.nicovideo.jp/watch/", "").Split('?')[0]; ;

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        private void ShowReqInfo2BSP(string kotehan, string videoId)
        {
            string output = String.Format("/press show blue {0}が{1} リクエスト",kotehan,videoId);
            pluginHost.SendOwnerComment(output);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="videoTitle"></param>
        /// <param name="videoURL"></param>
        /// <param name=""></param>
        private void ShowVideoInfo2Own(string videoTitle, string videoURL, string kotehan)
        {
            string announceComment = "/perm 只今の動画　Title:[{0}] ,URL:[{1}] リクエストした人:[{2}]";
            string output = String.Format(announceComment, videoTitle, videoURL, kotehan);
            pluginHost.SendOwnerComment(output);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            string output = String.Format("/clear");
            pluginHost.SendOwnerComment(output);
        }
    }
}
