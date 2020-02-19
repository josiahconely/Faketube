using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Tube.Classes
{
    class user
    {
        public int userId = 1;

        public List<string> myChannels = new List<string>()
        {
            "carrot",
            "fox",
            "explorer"
        };
        public List<int> mySubs = new List<int>()
        {
            1,
            2,
            3
        };

        public user() { }
        
    }
}
