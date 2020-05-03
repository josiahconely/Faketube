using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fake_Tube.Views;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Documents;

namespace Fake_Tube
{

    public partial class Login : Form
    {
        string connection_string;

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userid = -1;
            connection_string = ConfigurationManager.ConnectionStrings
                ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();

            // Create the command and set its properties.
            
            SqlCommand cmd = new SqlCommand
               ("login", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@userName";
            parameter1.SqlDbType = SqlDbType.NChar;
            parameter1.Direction = ParameterDirection.Input;
            parameter1.Value = textBox1.Text;

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@password";
            parameter2.SqlDbType = SqlDbType.NChar;
            parameter2.Direction = ParameterDirection.Input;
            parameter2.Value = textBox2.Text;

            cmd.Parameters.Add(parameter1);
            cmd.Parameters.Add(parameter2);
            string userName = "";
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);


                //System.Windows.Forms.MessageBox.Show("gothere 2");
                foreach (DataRow row in data.Rows)
                {
                    //System.Windows.Forms.MessageBox.Show("gothere 3");
                    int.TryParse(row["Id"].ToString(), out userid);
                    userName = row["userName"].ToString();

                    //System.Windows.Forms.MessageBox.Show(temp.ToString());
                }
            }
            connection.Close();

            //edit to home page 
            global_vars.userId = userid;
            global_vars.userName = userName;
            if (global_vars.userId >-1)
            {
                userProfilePage m = new userProfilePage();
                m.Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid user-name and password!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
