using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLog;

namespace MyListMove
{
    public delegate void VideoInfoEventHandler(object sender, VideoInfoEventArg e);

    public class VideoInfoEventArg : EventArgs
    {
        /// <summary>
        /// コメント番号
        /// </summary>
        public string CommentNo;

        /// <summary>
        /// ユーザID
        /// </summary>
        public string UserID;

        /// <summary>
        /// 動画タイトル
        /// </summary>
        public string VideoTitle;

        /// <summary>
        /// 動画時間
        /// </summary>
        public string VideoTime;

        /// <summary>
        /// 動画URL
        /// </summary>
        public string VideoURL;

        /// <summary>
        /// サムネイル画像URL
        /// </summary>
        public string ThumbnailURL;

    }
}
