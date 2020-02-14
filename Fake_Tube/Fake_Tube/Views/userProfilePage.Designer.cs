namespace Fake_Tube.Views
{
    partial class userProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userProfilePage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelUserName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonUserImg = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 2;
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
            // 
            // toolStripLabelUserName
            // 
            this.toolStripLabelUserName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelUserName.Name = "toolStripLabelUserName";
            this.toolStripLabelUserName.Size = new System.Drawing.Size(62, 36);
            this.toolStripLabelUserName.Text = "UserName";
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
            // 
            // userProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "userProfilePage";
            this.Text = "userProfilePage";
            this.Load += new System.EventHandler(this.userProfilePage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonHome;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUserName;
        private System.Windows.Forms.ToolStripButton toolStripButtonUserImg;
    }
}