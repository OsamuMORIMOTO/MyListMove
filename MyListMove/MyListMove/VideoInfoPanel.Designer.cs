namespace MyListMove
{
    partial class VideoInfoPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.picturerThumbnail = new System.Windows.Forms.PictureBox();
            this.labelCommentNo = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelVideoTitle = new System.Windows.Forms.Label();
            this.labelVideoTime = new System.Windows.Forms.Label();
            this.linkLabelVideoURL = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManagerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturerThumbnail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturerThumbnail
            // 
            this.picturerThumbnail.Location = new System.Drawing.Point(5, 5);
            this.picturerThumbnail.Margin = new System.Windows.Forms.Padding(5);
            this.picturerThumbnail.Name = "picturerThumbnail";
            this.picturerThumbnail.Size = new System.Drawing.Size(130, 100);
            this.picturerThumbnail.TabIndex = 0;
            this.picturerThumbnail.TabStop = false;
            // 
            // labelCommentNo
            // 
            this.labelCommentNo.AutoSize = true;
            this.labelCommentNo.Location = new System.Drawing.Point(143, 5);
            this.labelCommentNo.Name = "labelCommentNo";
            this.labelCommentNo.Size = new System.Drawing.Size(67, 12);
            this.labelCommentNo.TabIndex = 1;
            this.labelCommentNo.Text = "CommentNo";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(216, 5);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(40, 12);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "UserID";
            // 
            // labelVideoTitle
            // 
            this.labelVideoTitle.AutoSize = true;
            this.labelVideoTitle.Location = new System.Drawing.Point(143, 34);
            this.labelVideoTitle.Name = "labelVideoTitle";
            this.labelVideoTitle.Size = new System.Drawing.Size(57, 12);
            this.labelVideoTitle.TabIndex = 1;
            this.labelVideoTitle.Text = "VideoTitle";
            // 
            // labelVideoTime
            // 
            this.labelVideoTime.AutoSize = true;
            this.labelVideoTime.Location = new System.Drawing.Point(143, 64);
            this.labelVideoTime.Name = "labelVideoTime";
            this.labelVideoTime.Size = new System.Drawing.Size(59, 12);
            this.labelVideoTime.TabIndex = 1;
            this.labelVideoTime.Text = "VideoTime";
            // 
            // linkLabelVideoURL
            // 
            this.linkLabelVideoURL.AutoSize = true;
            this.linkLabelVideoURL.Location = new System.Drawing.Point(143, 93);
            this.linkLabelVideoURL.Name = "linkLabelVideoURL";
            this.linkLabelVideoURL.Size = new System.Drawing.Size(56, 12);
            this.linkLabelVideoURL.TabIndex = 2;
            this.linkLabelVideoURL.TabStop = true;
            this.linkLabelVideoURL.Text = "VideoURL";
            this.linkLabelVideoURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVideoURL_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ManagerButton);
            this.panel1.Controls.Add(this.labelCommentNo);
            this.panel1.Controls.Add(this.picturerThumbnail);
            this.panel1.Controls.Add(this.linkLabelVideoURL);
            this.panel1.Controls.Add(this.labelUserID);
            this.panel1.Controls.Add(this.labelVideoTime);
            this.panel1.Controls.Add(this.labelVideoTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 114);
            this.panel1.TabIndex = 3;
            // 
            // ManagerButton
            // 
            this.ManagerButton.Location = new System.Drawing.Point(218, 60);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(81, 20);
            this.ManagerButton.TabIndex = 3;
            this.ManagerButton.Text = "運営コメント";
            this.ManagerButton.UseVisualStyleBackColor = true;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // VideoInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VideoInfoPanel";
            this.Size = new System.Drawing.Size(400, 120);
            ((System.ComponentModel.ISupportInitialize)(this.picturerThumbnail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturerThumbnail;
        private System.Windows.Forms.Label labelCommentNo;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelVideoTitle;
        private System.Windows.Forms.Label labelVideoTime;
        private System.Windows.Forms.LinkLabel linkLabelVideoURL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManagerButton;
    }
}
