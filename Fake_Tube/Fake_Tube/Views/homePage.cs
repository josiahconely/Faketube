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
    public partial class homePage : Form
    {


        //Attributes////////////////////////////////////////////////
        BusinessLogic bl = new BusinessLogic();
        users thisUser = new users();
        //video thisVideo;
        //channel thisChannel = new channel();
        //playlist thisPlaylist = new playlist();

        public homePage()
        {
            InitializeComponent();
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }





































        //Tool Strip Controls //////////////////////////////////////
        /*
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
        */

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










