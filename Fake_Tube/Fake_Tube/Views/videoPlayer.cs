using System;
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
            toolStripLabelUserName.Text = global_vars.userName;
        }
        private void videoPlayer_Load(object sender, EventArgs e)
        {
            //Assigns info from video 
            loader();
        }
        private void loader()
        {
            textBoxNewComment.Clear();
            axWindowsMediaPlayer1.URL = thisVideo.getURL();
            labelVideoName.Text = thisVideo.getName();
            labelLikesNum.Text = thisVideo.getLikes().ToString();
            labelDislikesNum.Text = thisVideo.getDislikes().ToString();
            labelViewsNum.Text = thisVideo.views.ToString();
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
            videos = bl.getvideosFromChannelId(thisChannel.channelId);
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
                        labelLikesNum.Text = bl.getLikes(thisVideo.getVideoId()).ToString();
                        break;
                    case 2:
                        checkBoxLike.Checked = true;
                        checkBoxDislike.Checked = false;
                        labelLikesNum.Text = bl.getLikes(thisVideo.getVideoId()).ToString();
                        labelDislikesNum.Text = bl.getDislikes(thisVideo.getVideoId()).ToString();
                        break;
                    case 3:
                        checkBoxLike.Checked = false;
                        labelLikesNum.Text = bl.getLikes(thisVideo.getVideoId()).ToString();
                        break;
                }
                handleChecked = true;
            } 
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
                        labelLikesNum.Text = bl.getLikes(thisVideo.getVideoId()).ToString();
                        labelDislikesNum.Text = bl.getDislikes(thisVideo.getVideoId()).ToString();

                        break;
                    case 2:
                        checkBoxDislike.Checked = true;
                        checkBoxLike.Checked = false;
                        labelLikesNum.Text = bl.getLikes(thisVideo.getVideoId()).ToString();
                        labelDislikesNum.Text = bl.getDislikes(thisVideo.getVideoId()).ToString();
                        break;
                    case 3:
                        checkBoxDislike.Checked = false;
                        labelLikesNum.Text = bl.getLikes(thisVideo.getVideoId()).ToString();
                        labelDislikesNum.Text = bl.getDislikes(thisVideo.getVideoId()).ToString();
                        break;
                }
                handleChecked = true;
            }
        }
        //Comments Controls/////////////////////////////////////////
        public void buildComments()
        {
            listViewComments.Clear();
            List<string> comments = new List<string>();
            comments = bl.getComments(thisVideo.videoId);
            foreach (string c in comments)
            {
                var listViewItem = new ListViewItem(c);
                listViewComments.Items.Add(listViewItem);
            }
        }
        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            if (textBoxNewComment.Text != "")
            {
                bl.addCommentToVideo(textBoxNewComment.Text, thisVideo.videoId);
                buildComments();
            }
            textBoxNewComment.Clear();
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
                int x = int.Parse(tsi.Text);
                thisChannel = bl.getChannel(x);
                videoPlayer_Load(sender, e);
        }
        private void N_Click(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;
            try 
            {
                int x = int.Parse(tsi.Text);
                myChannelView m = new myChannelView(x);
                m.Show();
            }
            catch{}
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //change to home
            homePage m = new homePage();
            m.Show();
            this.Close();
        }
        private void toolStripLabelUserName_Click(object sender, EventArgs e)
        {
            //edit to user page
            userProfilePage m = new userProfilePage();
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
       

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text != "")
            {
                searchResults m = new searchResults(toolStripTextBox1.Text);
                m.Show();
                this.Close();
            }
        }

        private void buttonSubscribe_Click(object sender, EventArgs e)
        { 
            bl.subscribeToChannel(thisChannel.channelId, global_vars.userId);
        }
    }
}
