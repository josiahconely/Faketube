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
        users thisUser = new users();
        public channel thisChannel = new channel();
        BusinessLogic bl = new BusinessLogic();
        video modifyVid = new video();
        playlist modifyPlaylist = new playlist();
        bool addNewClicked = false;
        List<video> playListVideos;
        int videoIdToDeleteFromPlaylist;
        
        public myChannelView()
        {
            InitializeComponent();

            buttonSave.Enabled = false;
            


        }

        

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
            LabelChannelName.Text = thisChannel.getName();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            modifyVid = new video();
            textBoxName.Text = modifyVid.getName();
            textBoxPath.Text = modifyVid.getURL();
            textBoxDescription.Text = modifyVid.getDescription();
            labelVideoId.Text = "Video ID: New Video";
            buttonSave.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (!(listBoxVidoes.SelectedIndex == -1))
            {
                modifyVid = (listBoxVidoes.SelectedItem as video);
                textBoxName.Text = modifyVid.getName();
                textBoxPath.Text = modifyVid.getURL();
                textBoxDescription.Text = modifyVid.getDescription();
                
                textBoxTags.Text = modifyVid.getTagsString();
                labelVideoId.Text = "Video ID: " + modifyVid.getVideoId().ToString();
                buttonSave.Enabled = true;
                
            }
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

        

        private void buttonAddNewPlaylist_Click(object sender, EventArgs e)
        {
            textBoxPlaylistName.Text = "";
            textBoxPlaylistDescription.Text = "";
            textBoxPlaylistTags.Text = "";
            labelPlaylistId.Text = "New Playlist";
            buttonSavePlaylist.Enabled = true;
        }

        private void buttonModifyPlaylist_Click(object sender, EventArgs e)
        {
            if (!(listBoxPlayLists.SelectedIndex == -1))
            {
                modifyPlaylist = (listBoxPlayLists.SelectedItem as playlist);
                playListVideos = bl.getVidoesfromVidoeIds(modifyPlaylist.getVideoIds());


                textBoxPlaylistName.Text = modifyPlaylist.getPlaylistName();
                textBoxPlaylistDescription.Text = modifyPlaylist.getDescription();
                textBoxPlaylistTags.Text = modifyPlaylist.getTags().ToString();
                labelPlaylistId.Text = "Playlist ID: " + modifyPlaylist.getPlaylistId().ToString();
                buttonSavePlaylist.Enabled = true;
            }

        }

        private void buttonSavePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        /*private void populateVideoItems()
        {
                        //loop through each item
            flowLayoutPanelPlaylistVideos.Controls.Clear();
            foreach (video v in playListVideos)
            {
                ListItemVideo listVideo = new ListItemVideo();
                listVideo.ThisVideo = v;
                listVideo.videoName = v.getName();
                listVideo.creatorName = v.getcreatorName();
                listVideo.description = v.getDescription();
                listVideo.Click += videoClick;
                flowLayoutPanelPlaylistVideos.Controls.Add(listVideo);
            }
        }*/

        private void videoClick(object sender, EventArgs e)
        {
            ListItemVideo v = sender as ListItemVideo;
            videoIdToDeleteFromPlaylist = v.ThisVideo.getVideoId();
        }


    }
}
