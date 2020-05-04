using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Fake_Tube.Classes;

namespace Fake_Tube.Views
{
    public partial class searchResults : Form
    {
        BusinessLogic bl = new BusinessLogic();
        string connection_string;
        SqlConnection connection;
        List<int> videoIds = new List<int>();
        List<int> ChannelIds = new List<int>();
        int selected_videoId = 0;
        int selected_channel = 0;
        string searchTerm;
        
        public searchResults(string Term)
        {
            InitializeComponent();
            searchTerm = Term;
        }

        private void searchResults_Load(object sender, EventArgs e)
        {
            videoIds = bl.search(searchTerm);
            ChannelIds = bl.searchChannels(searchTerm);
            foreach (int v in videoIds)
            {
                listBoxVideos.Items.Add(v);
            }
            foreach (int v in ChannelIds)
            {
                listBoxChannels.Items.Add(v);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (selected_videoId != 0)
            {
                connection_string = ConfigurationManager.ConnectionStrings
                    ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
                connection = new SqlConnection(connection_string);
                connection.Open();

                SqlCommand cmd = new SqlCommand("EXEC getChannelIdfromVidId @param1 = '" + selected_videoId + "'", connection);
                int channelId = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    foreach (DataRow row in data.Rows)
                    {
                        int.TryParse(row["channelId"].ToString(), out channelId);
                    }
                }
                connection.Close();
                System.Windows.Forms.MessageBox.Show(channelId.ToString());
                videoPlayer m = new videoPlayer(selected_videoId, global_vars.userId, channelId);
                m.Show();
                this.Close();
            }
        }

        private void listBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(listBoxVideos.SelectedItem.ToString(), out selected_videoId);
            }
            catch
            {

            }
        }

        private void listBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(listBoxChannels.SelectedItem.ToString(), out selected_channel);
            }
            catch
            {

            }
        }

        private void buttonChannel_Click(object sender, EventArgs e)
        {
            if (selected_channel > 0)
            {
                selected_videoId = bl.getMostRecentVidFromChannel(selected_channel);
                videoPlayer m = new videoPlayer(selected_videoId, global_vars.userId, selected_channel);
                m.Show();
                this.Close();
            }
        }
    }
}
