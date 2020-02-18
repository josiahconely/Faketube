﻿namespace Fake_Tube.Views
{
    partial class ListItemVideo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxVideoPic = new System.Windows.Forms.PictureBox();
            this.labelVideoName = new System.Windows.Forms.Label();
            this.labelCreatorName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxVideoPic
            // 
            this.pictureBoxVideoPic.Location = new System.Drawing.Point(7, 9);
            this.pictureBoxVideoPic.Name = "pictureBoxVideoPic";
            this.pictureBoxVideoPic.Size = new System.Drawing.Size(75, 83);
            this.pictureBoxVideoPic.TabIndex = 0;
            this.pictureBoxVideoPic.TabStop = false;
            this.pictureBoxVideoPic.MouseEnter += new System.EventHandler(this.ListItemVideo_MouseEnter);
            this.pictureBoxVideoPic.MouseLeave += new System.EventHandler(this.ListItemVideo_MouseLeave);
            // 
            // labelVideoName
            // 
            this.labelVideoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVideoName.Location = new System.Drawing.Point(88, 9);
            this.labelVideoName.Name = "labelVideoName";
            this.labelVideoName.Size = new System.Drawing.Size(48, 10);
            this.labelVideoName.TabIndex = 1;
            this.labelVideoName.Text = "Video Name";
            this.labelVideoName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItemVideo_MouseClick);
            this.labelVideoName.MouseEnter += new System.EventHandler(this.ListItemVideo_MouseEnter);
            this.labelVideoName.MouseLeave += new System.EventHandler(this.ListItemVideo_MouseLeave);
            // 
            // labelCreatorName
            // 
            this.labelCreatorName.Location = new System.Drawing.Point(94, 29);
            this.labelCreatorName.Name = "labelCreatorName";
            this.labelCreatorName.Size = new System.Drawing.Size(36, 7);
            this.labelCreatorName.TabIndex = 2;
            this.labelCreatorName.Text = "Creator Name";
            this.labelCreatorName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItemVideo_MouseClick);
            this.labelCreatorName.MouseEnter += new System.EventHandler(this.ListItemVideo_MouseEnter);
            this.labelCreatorName.MouseLeave += new System.EventHandler(this.ListItemVideo_MouseLeave);
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(94, 42);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(30, 7);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            this.labelDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItemVideo_MouseClick);
            this.labelDescription.MouseEnter += new System.EventHandler(this.ListItemVideo_MouseEnter);
            this.labelDescription.MouseLeave += new System.EventHandler(this.ListItemVideo_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBoxVideoPic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 100);
            this.panel1.TabIndex = 4;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItemVideo_MouseClick);
            this.panel1.MouseEnter += new System.EventHandler(this.ListItemVideo_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.ListItemVideo_MouseLeave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(97, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 7);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItemVideo_MouseClick);
            this.label1.MouseEnter += new System.EventHandler(this.ListItemVideo_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.ListItemVideo_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(-2, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 10);
            this.panel2.TabIndex = 6;
            // 
            // ListItemVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelCreatorName);
            this.Controls.Add(this.labelVideoName);
            this.Name = "ListItemVideo";
            this.Size = new System.Drawing.Size(278, 100);
            this.Load += new System.EventHandler(this.ListItemVideo_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItemVideo_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ListItemVideo_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItemVideo_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVideoPic;
        private System.Windows.Forms.Label labelVideoName;
        private System.Windows.Forms.Label labelCreatorName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
