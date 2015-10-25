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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picturerThumbnail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturerThumbnail
            // 
            this.picturerThumbnail.Location = new System.Drawing.Point(3, 3);
            this.picturerThumbnail.Name = "picturerThumbnail";
            this.picturerThumbnail.Size = new System.Drawing.Size(194, 188);
            this.picturerThumbnail.TabIndex = 0;
            this.picturerThumbnail.TabStop = false;
            // 
            // labelCommentNo
            // 
            this.labelCommentNo.AutoSize = true;
            this.labelCommentNo.Location = new System.Drawing.Point(203, 29);
            this.labelCommentNo.Name = "labelCommentNo";
            this.labelCommentNo.Size = new System.Drawing.Size(35, 12);
            this.labelCommentNo.TabIndex = 1;
            this.labelCommentNo.Text = "*****";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(244, 29);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(40, 12);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "UserID";
            // 
            // labelVideoTitle
            // 
            this.labelVideoTitle.AutoSize = true;
            this.labelVideoTitle.Location = new System.Drawing.Point(203, 61);
            this.labelVideoTitle.Name = "labelVideoTitle";
            this.labelVideoTitle.Size = new System.Drawing.Size(57, 12);
            this.labelVideoTitle.TabIndex = 1;
            this.labelVideoTitle.Text = "VideoTitle";
            // 
            // labelVideoTime
            // 
            this.labelVideoTime.AutoSize = true;
            this.labelVideoTime.Location = new System.Drawing.Point(203, 99);
            this.labelVideoTime.Name = "labelVideoTime";
            this.labelVideoTime.Size = new System.Drawing.Size(37, 12);
            this.labelVideoTime.TabIndex = 1;
            this.labelVideoTime.Text = "***:**";
            // 
            // linkLabelVideoURL
            // 
            this.linkLabelVideoURL.AutoSize = true;
            this.linkLabelVideoURL.Location = new System.Drawing.Point(203, 125);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelCommentNo);
            this.panel1.Controls.Add(this.picturerThumbnail);
            this.panel1.Controls.Add(this.linkLabelVideoURL);
            this.panel1.Controls.Add(this.labelUserID);
            this.panel1.Controls.Add(this.labelVideoTime);
            this.panel1.Controls.Add(this.labelVideoTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 194);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "運営コメント";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VideoInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VideoInfoPanel";
            this.Size = new System.Drawing.Size(500, 200);
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
        private System.Windows.Forms.Button button1;
    }
}
