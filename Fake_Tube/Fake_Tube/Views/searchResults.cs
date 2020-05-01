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


namespace Fake_Tube.Views
{
    public partial class searchResults : Form
    {
        string connection_string;
        SqlConnection connection;

        List<int> videoIds = new List<int>();
        int selected_videoId =0 ;
        int userID;
        public searchResults(List<int> vids, int userId)
        {
            InitializeComponent();
            videoIds = vids;
            foreach (int v in videoIds){
                listBox1.Items.Add(v);
             }
            userID = userId;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int.TryParse(listBox1.SelectedItem.ToString(), out selected_videoId);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            connection_string = ConfigurationManager.ConnectionStrings
                ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connection_string);
            connection.Open();

            SqlCommand cmd = new SqlCommand("EXEC getChannelIdfromVidId @param1 = '" + selected_videoId + "'", connection);
            int channelId =0 ;
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                //System.Windows.Forms.MessageBox.Show("gothere 2");
                foreach (DataRow row in data.Rows)
                {
                    //System.Windows.Forms.MessageBox.Show("gothere 3");
                    int.TryParse(row["channelId "].ToString(), out channelId);
                   
                    //System.Windows.Forms.MessageBox.Show(temp.ToString());
                }
            }
            connection.Close();

            videoPlayer m = new videoPlayer(selected_videoId, userID, channelId);
            m.Show();
            this.Close();
        }
    }
}
