﻿namespace Fake_Tube.Views
{
    partial class myChannelView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myChannelView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelUserName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonUserImg = new System.Windows.Forms.ToolStripButton();
            this.LabelChannelName = new System.Windows.Forms.Label();
            this.labelVideos = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxVideo = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTags = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.groupBoxVideo.SuspendLayout();
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(730, 39);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 36);
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
            // 
            // LabelChannelName
            // 
            this.LabelChannelName.AutoSize = true;
            this.LabelChannelName.Location = new System.Drawing.Point(14, 39);
            this.LabelChannelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelChannelName.Name = "LabelChannelName";
            this.LabelChannelName.Size = new System.Drawing.Size(132, 24);
            this.LabelChannelName.TabIndex = 3;
            this.LabelChannelName.Text = "ChannelName";
            // 
            // labelVideos
            // 
            this.labelVideos.AutoSize = true;
            this.labelVideos.Location = new System.Drawing.Point(14, 81);
            this.labelVideos.Name = "labelVideos";
            this.labelVideos.Size = new System.Drawing.Size(69, 24);
            this.labelVideos.TabIndex = 5;
            this.labelVideos.Text = "Videos";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(229, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 35);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add New";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(229, 158);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 35);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(229, 208);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(106, 35);
            this.buttonModify.TabIndex = 8;
            this.buttonModify.Text = "Modify >>";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(229, 258);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 35);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "<< Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(18, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 290);
            this.listBox1.TabIndex = 10;
            // 
            // groupBoxVideo
            // 
            this.groupBoxVideo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxVideo.Controls.Add(this.textBox4);
            this.groupBoxVideo.Controls.Add(this.labelDiscription);
            this.groupBoxVideo.Controls.Add(this.textBox3);
            this.groupBoxVideo.Controls.Add(this.labelFilePath);
            this.groupBoxVideo.Controls.Add(this.textBox2);
            this.groupBoxVideo.Controls.Add(this.labelTags);
            this.groupBoxVideo.Controls.Add(this.labelName);
            this.groupBoxVideo.Controls.Add(this.textBox1);
            this.groupBoxVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxVideo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxVideo.Location = new System.Drawing.Point(341, 109);
            this.groupBoxVideo.Name = "groupBoxVideo";
            this.groupBoxVideo.Size = new System.Drawing.Size(385, 290);
            this.groupBoxVideo.TabIndex = 12;
            this.groupBoxVideo.TabStop = false;
            this.groupBoxVideo.Text = "Video Data";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(33, 187);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(346, 97);
            this.textBox4.TabIndex = 7;
            // 
            // labelDiscription
            // 
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Location = new System.Drawing.Point(29, 160);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(97, 24);
            this.labelDiscription.TabIndex = 6;
            this.labelDiscription.Text = "Discription";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 28);
            this.textBox3.TabIndex = 5;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(29, 131);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(47, 24);
            this.labelFilePath.TabIndex = 4;
            this.labelFilePath.Text = "Path";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 28);
            this.textBox2.TabIndex = 3;
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(29, 93);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(52, 24);
            this.labelTags.TabIndex = 2;
            this.labelTags.Text = "Tags";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 28);
            this.textBox1.TabIndex = 0;
            // 
            // myChannelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 827);
            this.Controls.Add(this.groupBoxVideo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelVideos);
            this.Controls.Add(this.LabelChannelName);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "myChannelView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myChannelView";
            this.Load += new System.EventHandler(this.myChannelView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxVideo.ResumeLayout(false);
            this.groupBoxVideo.PerformLayout();
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
        private System.Windows.Forms.Label LabelChannelName;
        private System.Windows.Forms.Label labelVideos;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxVideo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelDiscription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}