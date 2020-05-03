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
        int channelId;
        int videoIdToDeleteFromPlaylist;
        List<video> videoData = new List<video>();

        public myChannelView(int channel)
        {
            InitializeComponent();
            channelId = channel;
            buttonSave.Enabled = false;
            thisChannel = bl.getChannel(channel);
            System.Windows.Forms.MessageBox.Show(channelId.ToString());
            thisUser = bl.getUser(global_vars.userId);

        }

        

        private void myChannelView_Load(object sender, EventArgs e)
        {
            
            videoData = bl.getvideosFromChannelId(thisChannel.channelId);
            
            listBoxVidoes.DataSource = videoData;
            listBoxVidoes.DisplayMember = "Name";
            LabelChannelName.Text = thisChannel.name;
        }




        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            modifyVid = new video();
            textBoxName.Text = modifyVid.getName();
            textBoxFileName.Text = modifyVid.getURL();
            textBoxDescription.Text = modifyVid.getDescription();
            labelVideoId.Text = "Video ID: New Video";
            buttonSave.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            video deleteVid = new video();
            deleteVid = (listBoxVidoes.SelectedItem as video);

            if (bl.deleteVideo(deleteVid.getVideoId()))
            {
                System.Windows.Forms.MessageBox.Show("videoDeleted");
                myChannelView_Load( sender,  e);
            }
            else { System.Windows.Forms.MessageBox.Show("Delete Failed"); }

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (!(listBoxVidoes.SelectedIndex == -1))
            {
                modifyVid = (listBoxVidoes.SelectedItem as video);
                textBoxName.Text = modifyVid.getName();
                textBoxFileName.Text = modifyVid.getURL();
                textBoxDescription.Text = modifyVid.getDescription();
                
                
                labelVideoId.Text = "Video ID: " + modifyVid.getVideoId().ToString();
                buttonSave.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (modifyVid.getVideoId() == -1)
            {
                

                if (bl.addVideoToChannel(channelId, textBoxName.Text,"1", textBoxFileName.Text,textBoxDescription.Text)) {
                    //System.Windows.Forms.MessageBox.Show("update successful");
                    myChannelView_Load(sender, e);
                    MessageBox.Show("New video: " + textBoxName.Text + " added Successfuly.");
                    myChannelView_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error, Video could not save: are all required fields filled out?");
                }      
            }
            else
            {
                if (bl.updateVideoToChannel( textBoxName.Text, textBoxFileName.Text, textBoxDescription.Text, modifyVid.getVideoId()))
                {
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

        private void listBoxVidoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
