using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Tube.Classes
{
    public class users
    {
        private string userId; 
        private string userName;
        private string password;
        private string coverImg;
        private List<int> channelsSubcribed;
        private List<int> channelsOwned;
      

        public string UserId
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
        public List<int> Subcribed
        {
            get => channelsSubcribed;
            set => channelsSubcribed = value;
        }

        public List<int> Owned
        {
            get => channelsOwned;
            set => channelsOwned = value;
        }
    }
   
}
