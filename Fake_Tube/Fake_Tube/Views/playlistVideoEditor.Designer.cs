namespace Fake_Tube.Views
{
    partial class FormPlaylistVideoEditor
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
            this.listBoxVidoes = new System.Windows.Forms.ListBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
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
            this.groupBoxVideo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxVidoes
            // 
            this.listBoxVidoes.FormattingEnabled = true;
            this.listBoxVidoes.ItemHeight = 29;
            this.listBoxVidoes.Location = new System.Drawing.Point(13, 14);
            this.listBoxVidoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxVidoes.Name = "listBoxVidoes";
            this.listBoxVidoes.Size = new System.Drawing.Size(151, 352);
            this.listBoxVidoes.TabIndex = 17;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(172, 14);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(99, 36);
            this.buttonAddNew.TabIndex = 13;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(172, 64);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 36);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(172, 114);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(99, 36);
            this.buttonModify.TabIndex = 15;
            this.buttonModify.Text = "Modify >>";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(172, 164);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 36);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "<< Save";
            this.buttonSave.UseVisualStyleBackColor = true;
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
            this.groupBoxVideo.Location = new System.Drawing.Point(280, 14);
            this.groupBoxVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxVideo.Name = "groupBoxVideo";
            this.groupBoxVideo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxVideo.Size = new System.Drawing.Size(376, 363);
            this.groupBoxVideo.TabIndex = 18;
            this.groupBoxVideo.TabStop = false;
            this.groupBoxVideo.Text = "Video Data";
            this.groupBoxVideo.Enter += new System.EventHandler(this.groupBoxVideo_Enter);
            // 
            // labelVideoId
            // 
            this.labelVideoId.AutoSize = true;
            this.labelVideoId.Location = new System.Drawing.Point(94, 24);
            this.labelVideoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVideoId.Name = "labelVideoId";
            this.labelVideoId.Size = new System.Drawing.Size(111, 29);
            this.labelVideoId.TabIndex = 10;
            this.labelVideoId.Text = "Video ID:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(98, 130);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(262, 35);
            this.textBoxFileName.TabIndex = 9;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(8, 138);
            this.labelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(135, 29);
            this.labelFileName.TabIndex = 8;
            this.labelFileName.Text = "File Name*";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(11, 236);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(349, 114);
            this.textBoxDescription.TabIndex = 7;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(8, 211);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(135, 29);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(98, 169);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(262, 35);
            this.textBoxPath.TabIndex = 5;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(8, 175);
            this.labelFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(71, 29);
            this.labelFilePath.TabIndex = 4;
            this.labelFilePath.Text = "Path*";
            // 
            // textBoxTags
            // 
            this.textBoxTags.Location = new System.Drawing.Point(99, 91);
            this.textBoxTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTags.Name = "textBoxTags";
            this.textBoxTags.Size = new System.Drawing.Size(262, 35);
            this.textBoxTags.TabIndex = 3;
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(8, 97);
            this.labelTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(68, 29);
            this.labelTags.TabIndex = 2;
            this.labelTags.Text = "Tags";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 58);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(88, 29);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name*";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 52);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 35);
            this.textBoxName.TabIndex = 0;
            // 
            // FormPlaylistVideoEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 391);
            this.Controls.Add(this.listBoxVidoes);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxVideo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPlaylistVideoEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist Video Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxVideo.ResumeLayout(false);
            this.groupBoxVideo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVidoes;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxVideo;
        private System.Windows.Forms.Label labelVideoId;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxTags;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}