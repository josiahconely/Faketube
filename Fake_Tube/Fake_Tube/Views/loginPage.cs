﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fake_Tube.Views;

namespace Fake_Tube
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edit to home page 
            videoPlayer m = new videoPlayer(10,1);
            m.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
