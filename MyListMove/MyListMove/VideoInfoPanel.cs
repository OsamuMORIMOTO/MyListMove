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
        public int CommentNo
        {
            get
            {
                int tempCommentNo;
                if (int.TryParse(this.labelCommentNo.Text, out tempCommentNo))
                {
                    return tempCommentNo;
                }
                return -1;
            }
            set
            {
                this.labelCommentNo.Text = value.ToString();
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
    }
}
