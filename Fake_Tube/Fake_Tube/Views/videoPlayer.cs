using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fake_Tube.Views
{
    
    public partial class videoPlayer : Form
    {
        private const int V = 1;
        Image i;
        public videoPlayer(int videoId)
        {
            InitializeComponent();


            ToolStripDropDownButton toolStripDropDownButtonMyChannels = new ToolStripDropDownButton();
            toolStripDropDownButtonMyChannels.Text = "My Channels";
            //get users channel names
            List<string> myChannels = new List<string>()
        {
            "carrot",
            "fox",
            "explorer"
        };

            toolStripDropDownButtonMyChannels.DropDownItems.Clear();
            List<ToolStripMenuItem> channels = new List<ToolStripMenuItem>();
            foreach (string x in myChannels)
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
                channels.Add(n);
            }
            toolStripDropDownButtonMyChannels.DropDownItems.AddRange(channels.ToArray());
            toolStripDropDownButtonMyChannels.DropDown.AllowDrop = true;
            toolStrip1.Items.Insert(4, toolStripDropDownButtonMyChannels);
        }

        private void N_Click(object sender, EventArgs e)
        {
            //place holder
            MessageBox.Show( sender.ToString());
        }

        

        private void ToolStripDropDownButtonMyChannels_Click(object sender, EventArgs e)
        {
            
        }

        private void videoPlayer_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //change to home
            Login m = new Login();
            m.Show();
            this.Hide();
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

        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {

        }
    }
    
}
