using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fake_Tube.Classes;

namespace Fake_Tube.Views
{
    public partial class ListItemVideo : UserControl
    {
        video thisVideo = new video();
        
        public ListItemVideo()
        {
            InitializeComponent();
        }

        #region Properties
        private String _videoName;
        private String _description;
        private string _creatorName;
        private Image _icon;

        [Category ("Custom Prop")]
        public String videoName
        {
            get { return _videoName; }
            set { _videoName = value; labelVideoName.Text = value; }
        }


        [Category("Custom Prop")]
        public String description
        {
            get { return _description; }
            set { _description = value; labelDescription.Text = value; }
        }


        [Category("Custom Prop")]
        public string creatorName
        {
            get { return _creatorName; }
            set { _creatorName = value; labelCreatorName.Text = value; }
        }


        [Category("Custom Prop")]
        public Image icon
        {
            get { return _icon; }
            set { _icon = value; pictureBoxVideoPic.Image = value; }
        }






        #endregion

        private void ListItemVideo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListItemVideo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ListItemVideo_Load(object sender, EventArgs e)
        {

        }

        private void ListItemVideo_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Parent == null || this.Parent.GetType() != typeof(videoPlayer))
                return;
            AxWMPLib.AxWindowsMediaPlayer player = (this.Parent as videoPlayer).Controls["axWindowsMediaPlayer1"] as AxWMPLib.AxWindowsMediaPlayer;
            player.URL = "C:/vidoes/12_smartphone_gadgets_you_might_not_believe_existed_IR6V_6xqWDU_360p.mp4"; 
            player.Refresh();
            
        }
    }
}
