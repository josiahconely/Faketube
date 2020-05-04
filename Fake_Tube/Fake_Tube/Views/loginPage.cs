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

using Fake_Tube.Classes;

namespace Fake_Tube
{
    

    public partial class Login : Form
    {
        string connection_string;
        BusinessLogic bl = new BusinessLogic();
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
            if (global_vars.userId > -1)
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
            string newResult = InputBox("New User", "Enter new user name");
            string newResult2 = InputBox("New User", "Enter a Password");
            string newResult3 = InputBox("New User", "Enter a channel name");
            System.Windows.Forms.MessageBox.Show(newResult.ToString() + newResult2.ToString());
            if ( newResult != "" && newResult2 != "")
            {
                bl.addNewUser(newResult, newResult2, newResult3);
            }
        }


        public static string InputBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;


            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            return textBox.Text;
        }
    }
}
