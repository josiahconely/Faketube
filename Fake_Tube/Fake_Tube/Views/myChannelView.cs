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
    public partial class myChannelView : Form
    {
        user thisUser = new user();
        channel thisChannel = new channel();
        BusinessLogic bl = new BusinessLogic();
        video modifyVid = new video();
        bool addNewClicked = false;
        
        public myChannelView()
        {
            InitializeComponent();

            buttonSave.Enabled = false;
            buildToolBar();


        }

        public void buildToolBar()
        {
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
            this.Hide();
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //change to home
            Login m = new Login();
            m.Show();
            this.Hide();
        }
        private void toolStripLabelUserName_Click(object sender, EventArgs e)
        {
            //edit to user page
            Login m = new Login();
            m.Show();
            this.Hide();

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //edit to user page
            Login m = new Login();
            m.Show();
            this.Hide();

        }
        //Tool Strip Controls //////////////////////////////////////

        private void myChannelView_Load(object sender, EventArgs e)
        {
            //place holder
            //MessageBox.Show(sender.ToString());
            thisUser = bl.getUser(1);
            thisChannel = bl.getChannel(1);

            List<video> videoData = new List<video>();
            videoData = thisChannel.getVidoes();
            listBoxVidoes.DisplayMember = "nameText";
            listBoxVidoes.DataSource = videoData;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            modifyVid = new video();
            textBoxName.Text = modifyVid.getName();
            textBoxPath.Text = modifyVid.getPath();
            textBoxDescription.Text = modifyVid.getDescription();
            textBoxFileName.Text = modifyVid.getFileName();
            labelVideoId.Text = "Video ID: New Video";
            buttonSave.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            modifyVid = (listBoxVidoes.SelectedItem as video);
            textBoxName.Text = modifyVid.getName();
            textBoxPath.Text = modifyVid.getPath();
            textBoxDescription.Text = modifyVid.getDescription();
            textBoxFileName.Text = modifyVid.getFileName();
            textBoxTags.Text = modifyVid.getTagsString();
            labelVideoId.Text = "Video ID: " + modifyVid.getVideoId().ToString();
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (modifyVid.getVideoId() == -1)
            {
                
                if (bl.updateVideoToChannel(textBoxName.Text, textBoxTags.Text,
                textBoxFileName.Text, textBoxPath.Text, textBoxDescription.Text)) {
                    myChannelView_Load(sender, e);
                    MessageBox.Show("New video: " + textBoxName.Text + " added Successfuly.");
                }
                else
                {
                    MessageBox.Show("Error, Video could not save: are all required fields filled out?");
                }      
            }
            else
            {
                if (bl.updateVideoToChannel(textBoxName.Text, textBoxTags.Text,
                textBoxFileName.Text, textBoxPath.Text, textBoxDescription.Text, modifyVid.getVideoId()))
                {
                    //update this or requiry the data base to rebuild the channel

                    myChannelView_Load(sender, e);
                    MessageBox.Show("Video: " + modifyVid.getVideoId().ToString() + " Updated");
                }
                else
                {
                    MessageBox.Show("Error, Video could not save: are all required fields filled out?");
                }

            }
            
         

        }

        private void listBoxVidoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
