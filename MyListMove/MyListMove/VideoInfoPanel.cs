using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyListMove
{
    public partial class VideoInfoPanel : UserControl
    {
        /// <summary>
        /// コメント番号
        /// </summary>
        public string CommentNo
        {
            get
            {
                return this.labelCommentNo.Text;
            }
            set
            {
                this.labelCommentNo.Text = value;
            }
        }

        /// <summary>
        /// ユーザID
        /// </summary>
        public string UserID
        {
            get
            {
                return this.labelUserID.Text;
            }
            set
            {
                this.labelUserID.Text = value;
            }
        }

        /// <summary>
        /// 動画タイトル
        /// </summary>
        public string VideoTitle
        {
            get
            {
                return this.labelVideoTitle.Text;
            }
            set
            {
                this.labelVideoTitle.Text = value;
            }
        }

        /// <summary>
        /// 動画時間
        /// </summary>
        public string VideoTime
        {
            get
            {
                return this.labelVideoTime.Text;
            }
            set
            {
                this.labelVideoTime.Text = value;
            }
        }

        /// <summary>
        /// 動画URL
        /// </summary>
        public string VideoURL
        {
            get
            {
                return this.linkLabelVideoURL.Text;
            }
            set
            {
                this.linkLabelVideoURL.Text = value;
            }
        }
        
        /// <summary>
        /// サムネイル画像URL
        /// </summary>
        public string ThumbnailURL
        {
            get
            {
                return this.picturerThumbnail.ImageLocation;
            }
            set
            {
                this.picturerThumbnail.ImageLocation = value;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public event VideoInfoEventHandler EventManageButtonClick;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnEventManageButtonClick(VideoInfoEventArg e)
        {
            if(EventManageButtonClick != null)
            {
                EventManageButtonClick(this, e);
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public VideoInfoPanel()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 動画URLクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelVideoURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // アクセス済とする
            linkLabelVideoURL.LinkVisited = true;

            // 既定のアプリケーションで URL を開く
            System.Diagnostics.Process.Start(this.linkLabelVideoURL.Text);
        }

        /// <summary>
        /// 運営ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerButton_Click(object sender, EventArgs e)
        {
            VideoInfoEventArg info = new VideoInfoEventArg();

            info.CommentNo = this.CommentNo;
            info.UserID = this.UserID;
            info.VideoTitle = this.VideoTitle;
            info.VideoTime = this.VideoTime;
            info.VideoURL = this.VideoURL;
            info.ThumbnailURL = this.ThumbnailURL;

            OnEventManageButtonClick(info);
        }
    }
}
