namespace Fake_Tube.Views
{
    partial class videoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(videoPlayer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelUserName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonUserImg = new System.Windows.Forms.ToolStripButton();
            this.labelVideoName = new System.Windows.Forms.Label();
            this.labelCreatorName = new System.Windows.Forms.Label();
            this.pictureBoxCreator = new System.Windows.Forms.PictureBox();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonDislike = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLikesNum = new System.Windows.Forms.Label();
            this.labelDislikesNum = new System.Windows.Forms.Label();
            this.labelViews = new System.Windows.Forms.Label();
            this.labelViewsNum = new System.Windows.Forms.Label();
            this.buttonComment = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButtonHome,
            this.toolStripLabelUserName,
            this.toolStripButtonUserImg});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 36);
            this.toolStripLabel1.Text = "FakeTube";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHome.Image")));
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(44, 36);
            this.toolStripButtonHome.Text = "Home";
            this.toolStripButtonHome.Click += new System.EventHandler(this.toolStripButtonHome_Click);
            // 
            // toolStripLabelUserName
            // 
            this.toolStripLabelUserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelUserName.Name = "toolStripLabelUserName";
            this.toolStripLabelUserName.Size = new System.Drawing.Size(62, 36);
            this.toolStripLabelUserName.Text = "UserName";
            this.toolStripLabelUserName.Click += new System.EventHandler(this.toolStripLabelUserName_Click);
            // 
            // toolStripButtonUserImg
            // 
            this.toolStripButtonUserImg.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonUserImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUserImg.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUserImg.Image")));
            this.toolStripButtonUserImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUserImg.Name = "toolStripButtonUserImg";
            this.toolStripButtonUserImg.Size = new System.Drawing.Size(36, 36);
            this.toolStripButtonUserImg.Text = "toolStripButton4";
            this.toolStripButtonUserImg.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // labelVideoName
            // 
            this.labelVideoName.AutoSize = true;
            this.labelVideoName.Location = new System.Drawing.Point(12, 57);
            this.labelVideoName.Name = "labelVideoName";
            this.labelVideoName.Size = new System.Drawing.Size(111, 24);
            this.labelVideoName.TabIndex = 3;
            this.labelVideoName.Text = "VideoName";
            // 
            // labelCreatorName
            // 
            this.labelCreatorName.AutoSize = true;
            this.labelCreatorName.Location = new System.Drawing.Point(68, 447);
            this.labelCreatorName.Name = "labelCreatorName";
            this.labelCreatorName.Size = new System.Drawing.Size(119, 24);
            this.labelCreatorName.TabIndex = 4;
            this.labelCreatorName.Text = "creatorName";
            // 
            // pictureBoxCreator
            // 
            this.pictureBoxCreator.Location = new System.Drawing.Point(12, 451);
            this.pictureBoxCreator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCreator.Name = "pictureBoxCreator";
            this.pictureBoxCreator.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCreator.TabIndex = 5;
            this.pictureBoxCreator.TabStop = false;
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(476, 451);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(85, 34);
            this.buttonLike.TabIndex = 6;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // buttonDislike
            // 
            this.buttonDislike.Location = new System.Drawing.Point(567, 451);
            this.buttonDislike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDislike.Name = "buttonDislike";
            this.buttonDislike.Size = new System.Drawing.Size(85, 34);
            this.buttonDislike.TabIndex = 7;
            this.buttonDislike.Text = "Dislike";
            this.buttonDislike.UseVisualStyleBackColor = true;
            this.buttonDislike.Click += new System.EventHandler(this.buttonDislike_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 537);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 85);
            this.textBox1.TabIndex = 10;
            // 
            // labelLikesNum
            // 
            this.labelLikesNum.AutoSize = true;
            this.labelLikesNum.Location = new System.Drawing.Point(472, 488);
            this.labelLikesNum.Name = "labelLikesNum";
            this.labelLikesNum.Size = new System.Drawing.Size(62, 24);
            this.labelLikesNum.TabIndex = 11;
            this.labelLikesNum.Text = "likes #";
            // 
            // labelDislikesNum
            // 
            this.labelDislikesNum.AutoSize = true;
            this.labelDislikesNum.Location = new System.Drawing.Point(564, 488);
            this.labelDislikesNum.Name = "labelDislikesNum";
            this.labelDislikesNum.Size = new System.Drawing.Size(88, 24);
            this.labelDislikesNum.TabIndex = 12;
            this.labelDislikesNum.Text = "Dislikes #";
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Location = new System.Drawing.Point(299, 457);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(66, 24);
            this.labelViews.TabIndex = 13;
            this.labelViews.Text = "Views:";
            // 
            // labelViewsNum
            // 
            this.labelViewsNum.AutoSize = true;
            this.labelViewsNum.Enabled = false;
            this.labelViewsNum.Location = new System.Drawing.Point(371, 457);
            this.labelViewsNum.Name = "labelViewsNum";
            this.labelViewsNum.Size = new System.Drawing.Size(102, 24);
            this.labelViewsNum.TabIndex = 14;
            this.labelViewsNum.Text = "ViewsNum";
            this.labelViewsNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(567, 583);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(75, 39);
            this.buttonComment.TabIndex = 17;
            this.buttonComment.Text = "Post";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 629);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 186);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(690, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 788);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 85);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(640, 360);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // videoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(970, 827);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.labelViewsNum);
            this.Controls.Add(this.labelViews);
            this.Controls.Add(this.labelDislikesNum);
            this.Controls.Add(this.labelLikesNum);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDislike);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.pictureBoxCreator);
            this.Controls.Add(this.labelCreatorName);
            this.Controls.Add(this.labelVideoName);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "videoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FakeTube Video Player";
            this.Load += new System.EventHandler(this.videoPlayer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.ToolStripButton toolStripButtonUserImg;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label labelVideoName;
        private System.Windows.Forms.Label labelCreatorName;
        private System.Windows.Forms.PictureBox pictureBoxCreator;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonDislike;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLikesNum;
        private System.Windows.Forms.Label labelDislikesNum;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.Label labelViewsNum;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUserName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}