using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fake_Tube.Classes
{
    public class users
    {
        public int userId;
        public string userName;
        public string password;
        public string coverImg;
        public List<int> myChannels = new List<int>();
        public List<int> mySubs = new List<int>();


        public int UserId
        {
            get => userId; 
            set => userId = value; 
        }
        public string UserName
        {
            get => userName;
            set => userName = value;

        }
        public string Password
        {
            get => password; 
            set => password = value; 
        }
    }
}
