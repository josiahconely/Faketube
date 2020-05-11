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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Documents;


namespace Fake_Tube.Views
{
    public partial class userProfilePage : Form
    {
        bool addingNewChannel = true;
        string connection_string;
        SqlConnection connection;
        users thisUser;
        BusinessLogic bl = new BusinessLogic();
        List<int> channelIds = new List<int>();

        public userProfilePage()
        {
            InitializeComponent();
            thisUser = bl.getUser(global_vars.userId);
            buildToolBar();
            toolStripLabelUserName.Text = global_vars.userName;
        }

        private void userProfilePage_Load(object sender, EventArgs e)
        {
            channelIds.Clear();
            listBoxmychannels.Items.Clear();
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute userPagePopulateInfo @id";
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = thisUser.userId;

            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    textBoxUserName.Text = row["userName"].ToString();
                    textBoxPassword.Text = row["password"].ToString();
                    textBoxImgUrl.Text = row["img_url"].ToString();
                }
            }




            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandText = "Execute populateUserChannels @UserId";
            cmd2.Parameters.Add("@UserId", SqlDbType.Int).Value = global_vars.userId;

            int temp = 0;
            
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    int.TryParse(row["Id"].ToString(), out temp);
                    listBoxmychannels.Items.Add(temp);
                    //channelIds.Add(temp);

                }
            }

            //listBoxmychannels.DataSource = channelIds;
            

            connection.Close();









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
            
                int x = int.Parse(tsi.Text);
                //place holder
                videoPlayer v = new videoPlayer(bl.getMostRecentVidFromChannel(x), global_vars.userId, x);
                v.Show();
                this.Close();
             
            
                //MessageBox.Show("Channel failed to load... :(");
            
        }
        private void N_Click(object sender, EventArgs e)
        {
            ToolStripItem tsi = sender as ToolStripItem;
            //change to home
            
            try
            {
                int x = int.Parse(tsi.Text);
                myChannelView m = new myChannelView(x);
                m.Show();
                
            }
            catch
            {
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute UpdateUserInfo @id, @userName,@password,@img_url";

            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = global_vars.userId;
            cmd.Parameters.Add("@userName", SqlDbType.NChar,20).Value = textBoxUserName.Text;
            cmd.Parameters.Add("@password", SqlDbType.NChar, 20).Value = textBoxPassword.Text;
            cmd.Parameters.Add("@img_url", SqlDbType.VarChar).Value = textBoxImgUrl.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            thisUser = bl.getUser(global_vars.userId);
            userProfilePage_Load(sender, e);
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            textBoxchannelName.Text = "";
            addingNewChannel = true;
            buttonSaveChannel.Enabled = true;

        }

        private void buttonSaveChannel_Click(object sender, EventArgs e)
        {
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            if (addingNewChannel)
            {
                
                connection.Open();

                // Create the command and set its properties.
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Execute addNewChannel @name, @userId";

                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@name", SqlDbType.NChar,20).Value = textBoxchannelName.Text;
                cmd.Parameters.Add("@userId", SqlDbType.Int).Value = global_vars.userId;
                
                cmd.ExecuteNonQuery();
                connection.Close();

                userProfilePage m = new userProfilePage();
                m.Show();
                this.Close();
                //userProfilePage_Load(sender, e);
            }
        }

        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxmychannels.Items.Count > 1)
            {
                int chanId;
                string text = listBoxmychannels.GetItemText(listBoxmychannels.SelectedItem);
                int.TryParse((text), out chanId);
                System.Windows.Forms.MessageBox.Show("channel deleted: "+ chanId.ToString());

                connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connection_string);
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Execute deletechannel @Id";
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = chanId;
                cmd.ExecuteNonQuery();
                connection.Close();
                userProfilePage m = new userProfilePage();
                m.Show();
                this.Close();
                //userProfilePage_Load(sender, e);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("must have at least one Channel");
            }



        }
    }
}
    