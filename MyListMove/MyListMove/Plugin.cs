using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Plugin;
using NicoLibrary;

namespace MyListMove
{
    public class Plugin : IPlugin
    {
        /// <summary>
        /// プラグイン説明
        /// </summary>
        public string Description
        {
            get
            {
                // TODO
                return "Description";
            }
        }

        /// <summary>
        /// プラグインのホスト
        /// </summary>
        public IPluginHost Host
        {
            get
            {
                return this.pluginHost;
            }           
            set
            {
                this.pluginHost = value;
            }
        }

        /// <summary>
        /// プラグイン自動実行フラグ
        /// </summary>
        public bool IsAutoRun
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// プラグイン名
        /// </summary>
        public string Name
        {
            get
            {
                return "MyListMove";
            }
        }

        /// <summary>
        /// バージョン
        /// </summary>
        public string Version
        {
            get
            {
                return "0.1";
            }
        }

        /// <summary>
        /// 自動実行処理
        /// </summary>
        public void AutoRun()
        {
            // TODO
        }

        /// <summary>
        /// 
        /// </summary>
        private IPluginHost pluginHost = null;

        /// <summary>
        /// 動画情報ウィンドウ
        /// </summary>
        private VideoInfoWindow viWindow = null;

        /// <summary>
        /// メイン処理
        /// </summary>
        public void Run()
        {
            // 動画情報ウィンド生成・表示
            if(viWindow == null)
            {
                viWindow = new VideoInfoWindow();
            }

            viWindow.Show((System.Windows.Forms.IWin32Window)pluginHost.MainForm);

            // イベントハンドラ登録
            pluginHost.ReceivedComment += new ReceivedCommentEventHandler(PluginHost_ReceivedComment);

        }

        /// <summary>
        /// コメント受信イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PluginHost_ReceivedComment(object sender, ReceivedCommentEventArgs e)
        {
            int count = e.CommentDataList.Count;
            if (count < 0) { return; }

            NicoLibrary.NicoLiveData.LiveCommentData commentData = e.CommentDataList[count - 1];

            string commentNo = commentData.No;
            string anonymity = commentData.Anonymity;
            string comment = commentData.Comment;
            string userId = commentData.UserId;
            string kotehan = "184";

            UserSettingInPlugin userSetting = pluginHost.GetUserSettingInPlugin();

            foreach (UserSettingInPlugin.UserData userData in userSetting.UserDataList)
            {
                if (userData.UserId.Equals(userId))
                {
                    kotehan = userData.NickName;

                    
                }
            }

            viWindow.AddVideoInfoCommand(commentNo, kotehan, comment);
            
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowReqInfo2BSP()
        {
            pluginHost.SendOwnerComment("/press show blue {0} 業務連絡");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="videoTitle"></param>
        /// <param name="videoURL"></param>
        /// <param name=""></param>
        public void ShowVideoInfo2Own(string videoTitle, string videoURL, string kotehan)
        {
            string announceComment = "/perm 只今の動画　Title:[{0}] ,URL:[{1}] 投稿者:[{2}]";
            pluginHost.SendOwnerComment(announceComment);
        }

    }
}
