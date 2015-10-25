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

namespace MyListMove
{
    public partial class Form1 : Form
    {
        private List<VideoInfoPanel> videoInfoList = new List<VideoInfoPanel>();

        delegate bool AddVideoInfoCallback(string commentID, string UserID, string videoURL);

        public Form1()
        {
            InitializeComponent();
        }

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
        public void AddVideoInfoCommand(string commentID, string UserID, string videoURL)
        {

            if (this.InvokeRequired)
            {
                try
                {
                    AddVideoInfoCallback delegateMethod = new AddVideoInfoCallback(AddVideoInfo);

                    this.Invoke(delegateMethod,commentID,UserID,videoURL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }

            }
            else
            {
                AddVideoInfo(commentID, UserID, videoURL);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commentID"></param>
        /// <param name="UserID"></param>
        /// <param name="videoURL"></param>
        /// <returns></returns>
        public bool AddVideoInfo (string commentID, string UserID, string videoURL)
        {
            
            // 動画情報取得
            string URLString = "http://www.nicovideo.jp/api/getthumbinfo/" + textBoxURL.Text;

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
                
                tempVideoInfoPanel.CommentNo = 123456789;
                tempVideoInfoPanel.UserID = "テストユーザID:" + tempVideoInfoPanel.Controls.Count.ToString();
                tempVideoInfoPanel.VideoTitle = tempTitle;
                tempVideoInfoPanel.VideoTime = tempTime;
                tempVideoInfoPanel.VideoURL = tempURL;
                tempVideoInfoPanel.ThumbnailURL = thumbnail;

                Point tempPoint = new Point(3, 10 + (200 * videoInfoList.Count));
                tempPoint.Offset(panelVideoInfoList.AutoScrollPosition);
                tempVideoInfoPanel.Location = tempPoint;
                
                videoInfoList.Add(tempVideoInfoPanel);

                panelVideoInfoList.Controls.Add(videoInfoList.Last());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

                return false;

            }
             
            return true;

        }
        
    }
}
