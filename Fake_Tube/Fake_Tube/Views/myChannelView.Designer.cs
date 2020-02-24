namespace Fake_Tube.Views
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
            this.LabelChannelName = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxVidoes = new System.Windows.Forms.ListBox();
            this.groupBoxVideo = new System.Windows.Forms.GroupBox();
            this.labelVideoId = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxTags = new System.Windows.Forms.TextBox();
            this.labelTags = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxPlayLists = new System.Windows.Forms.ListBox();
            this.groupBoxPlaylist = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelPlaylistVideos = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPlaylistId = new System.Windows.Forms.Label();
            this.textBoxPlaylistDescription = new System.Windows.Forms.TextBox();
            this.labelPlaylistDescription = new System.Windows.Forms.Label();
            this.textBoxPlaylistTags = new System.Windows.Forms.TextBox();
            this.labelPlaylistTag = new System.Windows.Forms.Label();
            this.labelPlaylistName = new System.Windows.Forms.Label();
            this.textBoxPlaylistName = new System.Windows.Forms.TextBox();
            this.buttonSavePlaylist = new System.Windows.Forms.Button();
            this.buttonModifyPlaylist = new System.Windows.Forms.Button();
            this.buttonDeletePlaylist = new System.Windows.Forms.Button();
            this.buttonAddNewPlaylist = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageVideos = new System.Windows.Forms.TabPage();
            this.tabPagePlaylist = new System.Windows.Forms.TabPage();
            this.groupBoxVideo.SuspendLayout();
            this.groupBoxPlaylist.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageVideos.SuspendLayout();
            this.tabPagePlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelChannelName
            // 
            this.LabelChannelName.AutoSize = true;
            this.LabelChannelName.Location = new System.Drawing.Point(14, 9);
            this.LabelChannelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelChannelName.Name = "LabelChannelName";
            this.LabelChannelName.Size = new System.Drawing.Size(132, 24);
            this.LabelChannelName.TabIndex = 3;
            this.LabelChannelName.Text = "ChannelName";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(217, 5);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(106, 35);
            this.buttonAddNew.TabIndex = 6;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(217, 55);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 35);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(217, 105);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(106, 35);
            this.buttonModify.TabIndex = 8;
            this.buttonModify.Text = "Modify >>";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(217, 155);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 35);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "<< Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxVidoes
            // 
            this.listBoxVidoes.FormattingEnabled = true;
            this.listBoxVidoes.ItemHeight = 22;
            this.listBoxVidoes.Location = new System.Drawing.Point(6, 6);
            this.listBoxVidoes.Name = "listBoxVidoes";
            this.listBoxVidoes.Size = new System.Drawing.Size(205, 356);
            this.listBoxVidoes.TabIndex = 10;
            // 
            // groupBoxVideo
            // 
            this.groupBoxVideo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxVideo.Controls.Add(this.labelVideoId);
            this.groupBoxVideo.Controls.Add(this.textBoxFileName);
            this.groupBoxVideo.Controls.Add(this.labelFileName);
            this.groupBoxVideo.Controls.Add(this.textBoxDescription);
            this.groupBoxVideo.Controls.Add(this.labelDescription);
            this.groupBoxVideo.Controls.Add(this.textBoxPath);
            this.groupBoxVideo.Controls.Add(this.labelFilePath);
            this.groupBoxVideo.Controls.Add(this.textBoxTags);
            this.groupBoxVideo.Controls.Add(this.labelTags);
            this.groupBoxVideo.Controls.Add(this.labelName);
            this.groupBoxVideo.Controls.Add(this.textBoxName);
            this.groupBoxVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxVideo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxVideo.Location = new System.Drawing.Point(329, 6);
            this.groupBoxVideo.Name = "groupBoxVideo";
            this.groupBoxVideo.Size = new System.Drawing.Size(385, 326);
            this.groupBoxVideo.TabIndex = 12;
            this.groupBoxVideo.TabStop = false;
            this.groupBoxVideo.Text = "Video Data";
            // 
            // labelVideoId
            // 
            this.labelVideoId.AutoSize = true;
            this.labelVideoId.Location = new System.Drawing.Point(99, 25);
            this.labelVideoId.Name = "labelVideoId";
            this.labelVideoId.Size = new System.Drawing.Size(87, 24);
            this.labelVideoId.TabIndex = 10;
            this.labelVideoId.Text = "Video ID:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(114, 126);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(265, 28);
            this.textBoxFileName.TabIndex = 9;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(11, 130);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(104, 24);
            this.labelFileName.TabIndex = 8;
            this.labelFileName.Text = "File Name*";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(15, 222);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(364, 97);
            this.textBoxDescription.TabIndex = 7;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 195);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(104, 24);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(114, 163);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(265, 28);
            this.textBoxPath.TabIndex = 5;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(11, 167);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(54, 24);
            this.labelFilePath.TabIndex = 4;
            this.labelFilePath.Text = "Path*";
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(114, 89);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(265, 28);
            this.textBoxTags.TabIndex = 3;
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(11, 93);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(52, 24);
            this.labelTags.TabIndex = 2;
            this.labelTags.Text = "Tags";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name*";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(114, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(265, 28);
            this.textBoxName.TabIndex = 0;
            // 
            // listBoxPlayLists
            // 
            this.listBoxPlayLists.FormattingEnabled = true;
            this.listBoxPlayLists.ItemHeight = 22;
            this.listBoxPlayLists.Location = new System.Drawing.Point(3, 6);
            this.listBoxPlayLists.Name = "listBoxPlayLists";
            this.listBoxPlayLists.Size = new System.Drawing.Size(205, 356);
            this.listBoxPlayLists.TabIndex = 13;
            // 
            // groupBoxPlaylist
            // 
            this.groupBoxPlaylist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBoxPlaylist.Controls.Add(this.flowLayoutPanelPlaylistVideos);
            this.groupBoxPlaylist.Controls.Add(this.labelPlaylistId);
            this.groupBoxPlaylist.Controls.Add(this.textBoxPlaylistDescription);
            this.groupBoxPlaylist.Controls.Add(this.labelPlaylistDescription);
            this.groupBoxPlaylist.Controls.Add(this.textBoxPlaylistTags);
            this.groupBoxPlaylist.Controls.Add(this.labelPlaylistTag);
            this.groupBoxPlaylist.Controls.Add(this.labelPlaylistName);
            this.groupBoxPlaylist.Controls.Add(this.textBoxPlaylistName);
            this.groupBoxPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxPlaylist.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxPlaylist.Location = new System.Drawing.Point(326, 6);
            this.groupBoxPlaylist.Name = "groupBoxPlaylist";
            this.groupBoxPlaylist.Size = new System.Drawing.Size(385, 369);
            this.groupBoxPlaylist.TabIndex = 19;
            this.groupBoxPlaylist.TabStop = false;
            this.groupBoxPlaylist.Text = "Playlist Data";
            // 
            // flowLayoutPanelPlaylistVideos
            // 
            this.flowLayoutPanelPlaylistVideos.AutoScroll = true;
            this.flowLayoutPanelPlaylistVideos.Location = new System.Drawing.Point(165, 244);
            this.flowLayoutPanelPlaylistVideos.Name = "flowLayoutPanelPlaylistVideos";
            this.flowLayoutPanelPlaylistVideos.Size = new System.Drawing.Size(221, 121);
            this.flowLayoutPanelPlaylistVideos.TabIndex = 11;
            // 
            // labelPlaylistId
            // 
            this.labelPlaylistId.AutoSize = true;
            this.labelPlaylistId.Location = new System.Drawing.Point(99, 25);
            this.labelPlaylistId.Name = "labelPlaylistId";
            this.labelPlaylistId.Size = new System.Drawing.Size(93, 24);
            this.labelPlaylistId.TabIndex = 10;
            this.labelPlaylistId.Text = "Playlist ID:";
            // 
            // textBoxPlaylistDescription
            // 
            this.textBoxPlaylistDescription.Location = new System.Drawing.Point(15, 157);
            this.textBoxPlaylistDescription.Multiline = true;
            this.textBoxPlaylistDescription.Name = "textBoxPlaylistDescription";
            this.textBoxPlaylistDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlaylistDescription.Size = new System.Drawing.Size(364, 81);
            this.textBoxPlaylistDescription.TabIndex = 7;
            // 
            // labelPlaylistDescription
            // 
            this.labelPlaylistDescription.AutoSize = true;
            this.labelPlaylistDescription.Location = new System.Drawing.Point(11, 127);
            this.labelPlaylistDescription.Name = "labelPlaylistDescription";
            this.labelPlaylistDescription.Size = new System.Drawing.Size(104, 24);
            this.labelPlaylistDescription.TabIndex = 6;
            this.labelPlaylistDescription.Text = "Description";
            // 
            // textBoxPlaylistTags
            // 
            this.textBoxPlaylistTags.Location = new System.Drawing.Point(114, 89);
            this.textBoxPlaylistTags.Name = "textBoxPlaylistTags";
            this.textBoxPlaylistTags.Size = new System.Drawing.Size(265, 28);
            this.textBoxPlaylistTags.TabIndex = 3;
            // 
            // labelPlaylistTag
            // 
            this.labelPlaylistTag.AutoSize = true;
            this.labelPlaylistTag.Location = new System.Drawing.Point(11, 93);
            this.labelPlaylistTag.Name = "labelPlaylistTag";
            this.labelPlaylistTag.Size = new System.Drawing.Size(52, 24);
            this.labelPlaylistTag.TabIndex = 2;
            this.labelPlaylistTag.Text = "Tags";
            // 
            // labelPlaylistName
            // 
            this.labelPlaylistName.AutoSize = true;
            this.labelPlaylistName.Location = new System.Drawing.Point(11, 56);
            this.labelPlaylistName.Name = "labelPlaylistName";
            this.labelPlaylistName.Size = new System.Drawing.Size(68, 24);
            this.labelPlaylistName.TabIndex = 1;
            this.labelPlaylistName.Text = "Name*";
            // 
            // textBoxPlaylistName
            // 
            this.textBoxPlaylistName.Location = new System.Drawing.Point(114, 52);
            this.textBoxPlaylistName.Name = "textBoxPlaylistName";
            this.textBoxPlaylistName.Size = new System.Drawing.Size(265, 28);
            this.textBoxPlaylistName.TabIndex = 0;
            // 
            // buttonSavePlaylist
            // 
            this.buttonSavePlaylist.Enabled = false;
            this.buttonSavePlaylist.Location = new System.Drawing.Point(214, 155);
            this.buttonSavePlaylist.Name = "buttonSavePlaylist";
            this.buttonSavePlaylist.Size = new System.Drawing.Size(106, 35);
            this.buttonSavePlaylist.TabIndex = 18;
            this.buttonSavePlaylist.Text = "<< Save";
            this.buttonSavePlaylist.UseVisualStyleBackColor = true;
            this.buttonSavePlaylist.Click += new System.EventHandler(this.buttonSavePlaylist_Click);
            // 
            // buttonModifyPlaylist
            // 
            this.buttonModifyPlaylist.Location = new System.Drawing.Point(214, 105);
            this.buttonModifyPlaylist.Name = "buttonModifyPlaylist";
            this.buttonModifyPlaylist.Size = new System.Drawing.Size(106, 35);
            this.buttonModifyPlaylist.TabIndex = 17;
            this.buttonModifyPlaylist.Text = "Modify >>";
            this.buttonModifyPlaylist.UseVisualStyleBackColor = true;
            this.buttonModifyPlaylist.Click += new System.EventHandler(this.buttonModifyPlaylist_Click);
            // 
            // buttonDeletePlaylist
            // 
            this.buttonDeletePlaylist.Location = new System.Drawing.Point(214, 55);
            this.buttonDeletePlaylist.Name = "buttonDeletePlaylist";
            this.buttonDeletePlaylist.Size = new System.Drawing.Size(106, 35);
            this.buttonDeletePlaylist.TabIndex = 16;
            this.buttonDeletePlaylist.Text = "Delete";
            this.buttonDeletePlaylist.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewPlaylist
            // 
            this.buttonAddNewPlaylist.Location = new System.Drawing.Point(214, 5);
            this.buttonAddNewPlaylist.Name = "buttonAddNewPlaylist";
            this.buttonAddNewPlaylist.Size = new System.Drawing.Size(106, 35);
            this.buttonAddNewPlaylist.TabIndex = 15;
            this.buttonAddNewPlaylist.Text = "Add New";
            this.buttonAddNewPlaylist.UseVisualStyleBackColor = true;
            this.buttonAddNewPlaylist.Click += new System.EventHandler(this.buttonAddNewPlaylist_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageVideos);
            this.tabControl1.Controls.Add(this.tabPagePlaylist);
            this.tabControl1.Location = new System.Drawing.Point(14, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 409);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPageVideos
            // 
            this.tabPageVideos.AutoScroll = true;
            this.tabPageVideos.Controls.Add(this.listBoxVidoes);
            this.tabPageVideos.Controls.Add(this.buttonAddNew);
            this.tabPageVideos.Controls.Add(this.buttonDelete);
            this.tabPageVideos.Controls.Add(this.buttonModify);
            this.tabPageVideos.Controls.Add(this.buttonSave);
            this.tabPageVideos.Controls.Add(this.groupBoxVideo);
            this.tabPageVideos.Location = new System.Drawing.Point(4, 31);
            this.tabPageVideos.Name = "tabPageVideos";
            this.tabPageVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVideos.Size = new System.Drawing.Size(727, 374);
            this.tabPageVideos.TabIndex = 0;
            this.tabPageVideos.Text = "Videos";
            this.tabPageVideos.UseVisualStyleBackColor = true;
            // 
            // tabPagePlaylist
            // 
            this.tabPagePlaylist.Controls.Add(this.listBoxPlayLists);
            this.tabPagePlaylist.Controls.Add(this.groupBoxPlaylist);
            this.tabPagePlaylist.Controls.Add(this.buttonSavePlaylist);
            this.tabPagePlaylist.Controls.Add(this.buttonAddNewPlaylist);
            this.tabPagePlaylist.Controls.Add(this.buttonModifyPlaylist);
            this.tabPagePlaylist.Controls.Add(this.buttonDeletePlaylist);
            this.tabPagePlaylist.Location = new System.Drawing.Point(4, 31);
            this.tabPagePlaylist.Name = "tabPagePlaylist";
            this.tabPagePlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaylist.Size = new System.Drawing.Size(727, 374);
            this.tabPagePlaylist.TabIndex = 1;
            this.tabPagePlaylist.Text = "Playlists";
            this.tabPagePlaylist.UseVisualStyleBackColor = true;
            // 
            // myChannelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 487);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LabelChannelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "myChannelView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FakeTube My Channel";
            this.Load += new System.EventHandler(this.myChannelView_Load);
            this.groupBoxVideo.ResumeLayout(false);
            this.groupBoxVideo.PerformLayout();
            this.groupBoxPlaylist.ResumeLayout(false);
            this.groupBoxPlaylist.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageVideos.ResumeLayout(false);
            this.tabPagePlaylist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelChannelName;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxVidoes;
        private System.Windows.Forms.GroupBox groupBoxVideo;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxTags;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelVideoId;
        private System.Windows.Forms.ListBox listBoxPlayLists;
        private System.Windows.Forms.GroupBox groupBoxPlaylist;
        private System.Windows.Forms.Label labelPlaylistId;
        private System.Windows.Forms.TextBox textBoxPlaylistDescription;
        private System.Windows.Forms.Label labelPlaylistDescription;
        private System.Windows.Forms.TextBox textBoxPlaylistTags;
        private System.Windows.Forms.Label labelPlaylistTag;
        private System.Windows.Forms.Label labelPlaylistName;
        private System.Windows.Forms.TextBox textBoxPlaylistName;
        private System.Windows.Forms.Button buttonSavePlaylist;
        private System.Windows.Forms.Button buttonModifyPlaylist;
        private System.Windows.Forms.Button buttonDeletePlaylist;
        private System.Windows.Forms.Button buttonAddNewPlaylist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPlaylistVideos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVideos;
        private System.Windows.Forms.TabPage tabPagePlaylist;
    }
}