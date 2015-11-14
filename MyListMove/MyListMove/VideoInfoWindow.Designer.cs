namespace MyListMove
{
    partial class VideoInfoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelVideoInfoList = new System.Windows.Forms.Panel();
            this.labelTimeSum = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(12, 12);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(329, 19);
            this.textBoxURL.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelVideoInfoList
            // 
            this.panelVideoInfoList.AutoScroll = true;
            this.panelVideoInfoList.Location = new System.Drawing.Point(12, 70);
            this.panelVideoInfoList.Name = "panelVideoInfoList";
            this.panelVideoInfoList.Size = new System.Drawing.Size(420, 520);
            this.panelVideoInfoList.TabIndex = 3;
            // 
            // labelTimeSum
            // 
            this.labelTimeSum.AutoSize = true;
            this.labelTimeSum.Location = new System.Drawing.Point(289, 44);
            this.labelTimeSum.Name = "labelTimeSum";
            this.labelTimeSum.Size = new System.Drawing.Size(52, 12);
            this.labelTimeSum.TabIndex = 4;
            this.labelTimeSum.Text = "TimeSum";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(107, 37);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(89, 27);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "運コメ非表示";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // VideoInfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 603);
            this.Controls.Add(this.labelTimeSum);
            this.Controls.Add(this.panelVideoInfoList);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxURL);
            this.Name = "VideoInfoWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelVideoInfoList;
        private System.Windows.Forms.Label labelTimeSum;
        private System.Windows.Forms.Button buttonClear;
    }
}