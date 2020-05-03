using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing.Imaging;
using System.Drawing;


namespace Fake_Tube.Classes
{
    
    public class channel
    {
        
        public string name;
        public int channelId;
        public int ownerId;

        public channel() { }
        public channel (string name_, int id, int ownerId_) {
            name = name_;
            channelId= id;
            ownerId = ownerId_;
        }
    }
}
