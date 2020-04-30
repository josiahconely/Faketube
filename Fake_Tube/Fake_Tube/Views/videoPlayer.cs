﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fake_Tube.Classes;

namespace Fake_Tube.Views
{
   
    public partial class videoPlayer : Form
    {
        bool handleChecked = true;
        //Attributes////////////////////////////////////////////////
        BusinessLogic bl = new BusinessLogic();
        users thisUser = new users();
        video thisVideo;
        channel thisChannel = new channel();
        playlist thisPlaylist = new playlist();
        //Main form controls/////////////////////////////////////////
        public videoPlayer(int videoId, int userId, int channelId)
        {
            InitializeComponent();
            thisVideo = bl.getVideo(videoId);
            thisUser = bl.getUser(userId);
            thisChannel = bl.getChannel(channelId);
            buildToolBar();
        }
        private void videoPlayer_Load(object sender, EventArgs e)
        {
            //Assigns info from video 
            loader();
        }
        private void loader()
        {
            thisVideo.incViews();
            axWindowsMediaPlayer1.URL = thisVideo.getURL();
            labelVideoName.Text = thisVideo.getName();
            labelLikesNum.Text = thisVideo.getLikes().ToString();
            labelDislikesNum.Text = thisVideo.getDislikes().ToString();
            labelViewsNum.Text = thisVideo.getViews().ToString();
            labelCreatorName.Text = thisVideo.getcreatorName();
            buildComments();
            populateVideoItems();
            //update ths to load checks from user
            handleChecked = false;
            checkBoxLike.Checked = false;
            checkBoxDislike.Checked = false;
            handleChecked = true;
        }
        //Video Selector Controls////////////////////////////////////
        private void populateVideoItems()
        {
            List<video> videos = new List<video>();
            videos = thisChannel.getVidoes();
            
            //loop through each item
            flowLayoutPanel1.Controls.Clear();
            foreach (video v in videos)
            {
                ListItemVideo listVideo = new ListItemVideo();
                listVideo.ThisVideo = v;
                listVideo.videoName = v.getName();
                listVideo.creatorName = v.getcreatorName();
                listVideo.description = v.getDescription();
                listVideo.Click += videoClick;
                flowLayoutPanel1.Controls.Add(listVideo);
            }
        }
        private void videoClick(object sender, EventArgs e) 
        {
            ListItemVideo v = sender as ListItemVideo;
            thisVideo = v.ThisVideo;
            videoPlayer_Load(sender, e);
        }
        //Likes Dislikes Buttons/////////////////////////////////////
        private void checkBoxLike_CheckedChanged(object sender, EventArgs e)
        {

            if (handleChecked)
            {
                handleChecked = false;
                //if 1 like occured unDislike did not occur
                //if 2 like occured unDislike occured
                //if 3 unLike occured
                switch (bl.clickLikeVideo(thisVideo.getVideoId(), thisUser.userId))
                {
                    case 1:
                        checkBoxLike.Checked = true;
                        break;
                    case 2:
                        checkBoxLike.Checked = true;
                        checkBoxDislike.Checked = false;
                        break;
                    case 3:
                        checkBoxLike.Checked = false;
                        break;
                }
                handleChecked = true;
            }
            labelLikesNum.Text = thisVideo.getLikes().ToString();
            labelDislikesNum.Text = thisVideo.getDislikes().ToString();
        }
        private void checkBoxDislike_CheckedChanged(object sender, EventArgs e)
        {
            if (handleChecked)
            {
                handleChecked = false;
                //if 1 dislike occured unlike did not occur
                //if 2 idslike occured unlike occured
                //if 3 unDislike occured
                switch (bl.clickDislikeVideo(thisVideo.getVideoId(), thisUser.userId))
                {
                    case 1:
                        checkBoxDislike.Checked = true;
                        break;
                    case 2:
                        checkBoxLike.Checked = false;
                        checkBoxDislike.Checked = true;
                        break;
                    case 3:
                        checkBoxDislike.Checked = false;
                        break;
                }
                handleChecked = true;
            }
            labelLikesNum.Text = thisVideo.getLikes().ToString();
            labelDislikesNum.Text = thisVideo.getDislikes().ToString();

        }
        //Comments Controls/////////////////////////////////////////
        public void buildComments()
        {
            foreach (comment c in thisVideo.getComments())
            {
                listViewComments.Clear();
                string[] row = { c.getText(), c.getLikes().ToString(), c.getDislikes().ToString() };
                var listViewItem = new ListViewItem(row);
                listViewComments.Items.Add(listViewItem);
            }
        }
        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            if (textBoxNewComment.Text != "")
            {
                thisVideo.addComment(this.textBoxNewComment.Text, thisUser.userId);
                textBoxNewComment.Text = "";
                buildComments();
            }
        }
        private void textBoxNewComment_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewComment.Text == "")
            {
                buttonPostComment.Enabled = false;
            }
            else
            {
                buttonPostComment.Enabled = true;
            }
        }
        //Tool Strip Controls //////////////////////////////////////
        public void buildToolBar()
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            //Adds My Channels Drop Down
            ToolStripDropDownButton toolStripDropDownButtonMyChannels = new ToolStripDropDownButton();
            toolStripDropDownButtonMyChannels.Text = "My Channels";
            //get users channel names


            toolStripDropDownButtonMyChannels.DropDownItems.Clear();
            List<ToolStripMenuItem> myChannels = new List<ToolStripMenuItem>();
            foreach (int x in thisUser.myChannels)
            {
                ToolStripMenuItem n = new ToolStripMenuItem();
                n.Text = x.ToString();

                if (!string.IsNullOrEmpty(x.ToString()))
                {
                    Keys k = new Keys();
                    k.Equals(1);
                    n.ShortcutKeys = k;
                    n.Click += N_Click;
                }
                myChannels.Add(n);
            }
            toolStripDropDownButtonMyChannels.DropDownItems.AddRange(myChannels.ToArray());
            toolStripDropDownButtonMyChannels.DropDown.AllowDrop = true;
            toolStrip1.Items.Insert(4, toolStripDropDownButtonMyChannels);
            //////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////
            //Adds My Subs Drop Down
            ToolStripDropDownButton toolStripDropDownButtonMySubscriptions = new ToolStripDropDownButton();
            toolStripDropDownButtonMySubscriptions.Text = "My Subscriptions";
            //get users channel names


            toolStripDropDownButtonMySubscriptions.DropDownItems.Clear();
            List<ToolStripMenuItem> subChannels = new List<ToolStripMenuItem>();
            foreach (int x in thisUser.mySubs)
            {
                ToolStripMenuItem m = new ToolStripMenuItem();
                m.Text = x.ToString();
                Keys k = new Keys();
                k.Equals(1);
                m.ShortcutKeys = k;
                m.Click += M_Click;
                subChannels.Add(m);
            }
            toolStripDropDownButtonMySubscriptions.DropDownItems.AddRange(subChannels.ToArray());
            toolStripDropDownButtonMySubscriptions.DropDown.AllowDrop = true;
            toolStrip1.Items.Insert(5, toolStripDropDownButtonMySubscriptions);
            //////////////////////////////////////////////////////////////////////////////////////////
        }
        private void M_Click(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;
            //not safe
            try
            {
                int x = int.Parse(tsi.Text);
                //place holder
                thisChannel = bl.getChannel(x);
                videoPlayer_Load(sender, e);
            }

            catch
            {
                MessageBox.Show("Channel failed to load... :(");
            }
        }
        private void N_Click(object sender, EventArgs e)
        {
            //change to home
            myChannelView m = new myChannelView();
            m.ShowDialog(this);
            if (thisChannel.getChannelId() == m.thisChannel.getChannelId())
            {
                loader();
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //change to home
            Login m = new Login();
            m.Show();
            this.Close();
        }
        private void toolStripLabelUserName_Click(object sender, EventArgs e)
        {
            //edit to user page
            Login m = new Login();
            m.Show();
            this.Close();
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //edit to user page
            Login m = new Login();
            m.Show();
            this.Close();
        }
        private void ToolStripDropDownButtonMyChannels_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
