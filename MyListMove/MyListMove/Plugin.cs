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
        private IPluginHost _host = null;
        private Form1 _form = null;

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
                return this._host;
            }           
            set
            {
                this._host = value;
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
        /// メイン処理
        /// </summary>
        public void Run()
        {
            // System.Windows.Forms.MessageBox.Show("Hello NCV Plugins!");

            if(_form == null)
            {
                _form = new Form1();
                _form.Show((System.Windows.Forms.IWin32Window)_host.MainForm);
            }

            _host.ReceivedComment += new ReceivedCommentEventHandler(_host_ReceivedComment);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _host_ReceivedComment(object sender, ReceivedCommentEventArgs e)
        {
            int count = e.CommentDataList.Count;
            if (count < 0) { return; }

            NicoLibrary.NicoLiveData.LiveCommentData commentData = e.CommentDataList[count - 1];

            string no = commentData.No;
            string anonymity = commentData.Anonymity;
            string comment = commentData.Comment;
            string userid = commentData.UserId;

            _form.AddVideoInfoCommand(no, userid, comment);
            
        }
    }
}
