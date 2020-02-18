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
        BusinessLogic bl = new BusinessLogic();
        user thisUser = new user();
        video thisVideo;
        //List<ListItemVideo> listVideos = new List<ListItemVideo>();
        public videoPlayer(int videoId, int userId)
        {
            InitializeComponent();
            thisVideo = bl.getVideo(videoId);

            ///////////////////////////////////////////////////////////////////////////////////////
            //Adds My Channels Drop Down
            ToolStripDropDownButton toolStripDropDownButtonMyChannels = new ToolStripDropDownButton();
            toolStripDropDownButtonMyChannels.Text = "My Channels";
            //get users channel names
        

            toolStripDropDownButtonMyChannels.DropDownItems.Clear();
            List<ToolStripMenuItem> myChannels = new List<ToolStripMenuItem>();
            foreach (string x in thisUser.myChannels)
            {
                ToolStripMenuItem n = new ToolStripMenuItem();
                n.Text = x;
                
                if (!string.IsNullOrEmpty(x))
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
            foreach (string x in thisUser.mySubs)
            {
                ToolStripMenuItem m = new ToolStripMenuItem();
                m.Text = x;

                if (!string.IsNullOrEmpty(x))
                {
                    Keys k = new Keys();
                    k.Equals(1);
                    m.ShortcutKeys = k;
                    m.Click += M_Click; 
                }
                subChannels.Add(m);
            }
            toolStripDropDownButtonMySubscriptions.DropDownItems.AddRange(subChannels.ToArray());
            toolStripDropDownButtonMySubscriptions.DropDown.AllowDrop = true;
            toolStrip1.Items.Insert(5, toolStripDropDownButtonMySubscriptions);
            //////////////////////////////////////////////////////////////////////////////////////////
        }


       

        private void videoPlayer_Load(object sender, EventArgs e)
        {
            //Assigns info from video 
            thisVideo.incViews();
            axWindowsMediaPlayer1.URL = thisVideo.getURL();
            labelVideoName.Text = thisVideo.getName();
            labelLikesNum.Text = thisVideo.getLikes().ToString();
            labelDislikesNum.Text = thisVideo.getDislikes().ToString();
            labelViewsNum.Text = thisVideo.getViews().ToString();
            labelCreatorName.Text = thisVideo.getcreatorName();
            populateVideoItems();
        }

        //Tool Strip Controls //////////////////////////////////////
        private void M_Click(object sender, EventArgs e)
        {
            //place holder
            MessageBox.Show(sender.ToString());
        }

        private void N_Click(object sender, EventArgs e)
        {
            //change to home
            myChannelView m = new myChannelView();
            m.Show();
            this.Close();
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
        //Tool Strip Controls //////////////////////////////////////  

        private void populateVideoItems()
        {
            List<video> videos = new List<video>();
            videos = bl.getVidoesfromVidoeIds();
            
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
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {

        }

        //not done
        private void buttonLike_Click(object sender, EventArgs e)
        {
            thisVideo.incLikes();
            labelLikesNum.Text = thisVideo.getLikes().ToString();
            labelDislikesNum.Text = thisVideo.getDislikes().ToString();
        }

        //not done
        private void buttonDislike_Click(object sender, EventArgs e)
        {
            thisVideo.incDislikes();
            labelLikesNum.Text = thisVideo.getLikes().ToString();
            labelDislikesNum.Text = thisVideo.getDislikes().ToString();
        }

        
    }
}
