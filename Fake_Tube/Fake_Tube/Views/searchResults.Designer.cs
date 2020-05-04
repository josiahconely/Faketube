namespace Fake_Tube.Views
{
    partial class searchResults
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
            this.listBoxChannels = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxVideos = new System.Windows.Forms.ListBox();
            this.buttonChannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxChannels
            // 
            this.listBoxChannels.FormattingEnabled = true;
            this.listBoxChannels.ItemHeight = 20;
            this.listBoxChannels.Location = new System.Drawing.Point(532, 14);
            this.listBoxChannels.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxChannels.Name = "listBoxChannels";
            this.listBoxChannels.Size = new System.Drawing.Size(386, 524);
            this.listBoxChannels.TabIndex = 0;
            this.listBoxChannels.SelectedIndexChanged += new System.EventHandler(this.listBoxChannels_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxVideos
            // 
            this.listBoxVideos.FormattingEnabled = true;
            this.listBoxVideos.ItemHeight = 20;
            this.listBoxVideos.Location = new System.Drawing.Point(13, 14);
            this.listBoxVideos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxVideos.Name = "listBoxVideos";
            this.listBoxVideos.Size = new System.Drawing.Size(386, 524);
            this.listBoxVideos.TabIndex = 2;
            this.listBoxVideos.SelectedIndexChanged += new System.EventHandler(this.listBoxVideos_SelectedIndexChanged);
            // 
            // buttonChannel
            // 
            this.buttonChannel.Location = new System.Drawing.Point(926, 18);
            this.buttonChannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChannel.Name = "buttonChannel";
            this.buttonChannel.Size = new System.Drawing.Size(147, 35);
            this.buttonChannel.TabIndex = 3;
            this.buttonChannel.Text = "Select Channel";
            this.buttonChannel.UseVisualStyleBackColor = true;
            this.buttonChannel.Click += new System.EventHandler(this.buttonChannel_Click);
            // 
            // searchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonChannel);
            this.Controls.Add(this.listBoxVideos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxChannels);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "searchResults";
            this.Text = "searchResults";
            this.Load += new System.EventHandler(this.searchResults_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChannels;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxVideos;
        private System.Windows.Forms.Button buttonChannel;
    }
}