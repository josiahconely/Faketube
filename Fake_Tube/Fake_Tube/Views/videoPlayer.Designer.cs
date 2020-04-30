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
            this.textBoxNewComment = new System.Windows.Forms.TextBox();
            this.labelLikesNum = new System.Windows.Forms.Label();
            this.labelDislikesNum = new System.Windows.Forms.Label();
            this.labelViews = new System.Windows.Forms.Label();
            this.labelViewsNum = new System.Windows.Forms.Label();
            this.buttonPostComment = new System.Windows.Forms.Button();
            this.listViewComments = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.checkBoxLike = new System.Windows.Forms.CheckBox();
            this.checkBoxDislike = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
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
            this.toolStrip1.Size = new System.Drawing.Size(994, 41);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 36);
            this.toolStripLabel1.Text = "FakeTube";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButtonHome
            // 
            this.toolStripButtonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonHome.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHome.Image")));
            this.toolStripButtonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHome.Name = "toolStripButtonHome";
            this.toolStripButtonHome.Size = new System.Drawing.Size(65, 36);
            this.toolStripButtonHome.Text = "Home";
            this.toolStripButtonHome.Click += new System.EventHandler(this.toolStripButtonHome_Click);
            // 
            // toolStripLabelUserName
            // 
            this.toolStripLabelUserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelUserName.Name = "toolStripLabelUserName";
            this.toolStripLabelUserName.Size = new System.Drawing.Size(94, 36);
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
            this.labelVideoName.Size = new System.Drawing.Size(164, 32);
            this.labelVideoName.TabIndex = 3;
            this.labelVideoName.Text = "VideoName";
            // 
            // labelCreatorName
            // 
            this.labelCreatorName.AutoSize = true;
            this.labelCreatorName.Location = new System.Drawing.Point(68, 447);
            this.labelCreatorName.Name = "labelCreatorName";
            this.labelCreatorName.Size = new System.Drawing.Size(178, 32);
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
            // textBoxNewComment
            // 
            this.textBoxNewComment.Location = new System.Drawing.Point(12, 537);
            this.textBoxNewComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewComment.Multiline = true;
            this.textBoxNewComment.Name = "textBoxNewComment";
            this.textBoxNewComment.Size = new System.Drawing.Size(549, 85);
            this.textBoxNewComment.TabIndex = 10;
            this.textBoxNewComment.TextChanged += new System.EventHandler(this.textBoxNewComment_TextChanged);
            // 
            // labelLikesNum
            // 
            this.labelLikesNum.AutoSize = true;
            this.labelLikesNum.Location = new System.Drawing.Point(472, 488);
            this.labelLikesNum.Name = "labelLikesNum";
            this.labelLikesNum.Size = new System.Drawing.Size(96, 32);
            this.labelLikesNum.TabIndex = 11;
            this.labelLikesNum.Text = "likes #";
            // 
            // labelDislikesNum
            // 
            this.labelDislikesNum.AutoSize = true;
            this.labelDislikesNum.Location = new System.Drawing.Point(564, 488);
            this.labelDislikesNum.Name = "labelDislikesNum";
            this.labelDislikesNum.Size = new System.Drawing.Size(137, 32);
            this.labelDislikesNum.TabIndex = 12;
            this.labelDislikesNum.Text = "Dislikes #";
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Location = new System.Drawing.Point(299, 457);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(99, 32);
            this.labelViews.TabIndex = 13;
            this.labelViews.Text = "Views:";
            // 
            // labelViewsNum
            // 
            this.labelViewsNum.AutoSize = true;
            this.labelViewsNum.Enabled = false;
            this.labelViewsNum.Location = new System.Drawing.Point(371, 457);
            this.labelViewsNum.Name = "labelViewsNum";
            this.labelViewsNum.Size = new System.Drawing.Size(150, 32);
            this.labelViewsNum.TabIndex = 14;
            this.labelViewsNum.Text = "ViewsNum";
            // 
            // buttonPostComment
            // 
            this.buttonPostComment.Enabled = false;
            this.buttonPostComment.Location = new System.Drawing.Point(567, 583);
            this.buttonPostComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostComment.Name = "buttonPostComment";
            this.buttonPostComment.Size = new System.Drawing.Size(75, 39);
            this.buttonPostComment.TabIndex = 17;
            this.buttonPostComment.Text = "Post";
            this.buttonPostComment.UseVisualStyleBackColor = true;
            this.buttonPostComment.Click += new System.EventHandler(this.buttonPostComment_Click);
            // 
            // listViewComments
            // 
            this.listViewComments.GridLines = true;
            this.listViewComments.HideSelection = false;
            this.listViewComments.Location = new System.Drawing.Point(13, 629);
            this.listViewComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewComments.Name = "listViewComments";
            this.listViewComments.Size = new System.Drawing.Size(548, 186);
            this.listViewComments.TabIndex = 18;
            this.listViewComments.UseCompatibleStateImageBehavior = false;
            this.listViewComments.View = System.Windows.Forms.View.Tile;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(701, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 774);
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
            // 
            // checkBoxLike
            // 
            this.checkBoxLike.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLike.Location = new System.Drawing.Point(476, 451);
            this.checkBoxLike.Name = "checkBoxLike";
            this.checkBoxLike.Size = new System.Drawing.Size(74, 34);
            this.checkBoxLike.TabIndex = 20;
            this.checkBoxLike.Text = "Like";
            this.checkBoxLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxLike.UseVisualStyleBackColor = true;
            this.checkBoxLike.CheckedChanged += new System.EventHandler(this.checkBoxLike_CheckedChanged);
            // 
            // checkBoxDislike
            // 
            this.checkBoxDislike.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDislike.AutoSize = true;
            this.checkBoxDislike.Location = new System.Drawing.Point(567, 451);
            this.checkBoxDislike.Name = "checkBoxDislike";
            this.checkBoxDislike.Size = new System.Drawing.Size(110, 42);
            this.checkBoxDislike.TabIndex = 21;
            this.checkBoxDislike.Text = "Dislike";
            this.checkBoxDislike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDislike.UseVisualStyleBackColor = true;
            this.checkBoxDislike.CheckedChanged += new System.EventHandler(this.checkBoxDislike_CheckedChanged);
            // 
            // videoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(986, 827);
            this.Controls.Add(this.checkBoxDislike);
            this.Controls.Add(this.checkBoxLike);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listViewComments);
            this.Controls.Add(this.buttonPostComment);
            this.Controls.Add(this.labelViewsNum);
            this.Controls.Add(this.labelViews);
            this.Controls.Add(this.labelDislikesNum);
            this.Controls.Add(this.labelLikesNum);
            this.Controls.Add(this.textBoxNewComment);
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
        private System.Windows.Forms.TextBox textBoxNewComment;
        private System.Windows.Forms.Label labelLikesNum;
        private System.Windows.Forms.Label labelDislikesNum;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.Label labelViewsNum;
        private System.Windows.Forms.Button buttonPostComment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUserName;
        private System.Windows.Forms.ListView listViewComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxLike;
        private System.Windows.Forms.CheckBox checkBoxDislike;
    }
}