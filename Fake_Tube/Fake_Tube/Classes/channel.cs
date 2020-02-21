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
    
    class channel
    {
        BusinessLogic bl = new BusinessLogic();
        private string name;
        private int channelId;
        private List<int> subscribersId;
        private List<int> vidoeIds;
        private int ownerId;
        //private Image logo;
        private List<string> tags;




        public channel() {
        
        }

        public string getName() { return name; }
        public void setName(string n) { name = n; }
        public int getChannelId() { return channelId; }
        public void setChannelId(int id) { channelId = id; }
        //public void getSubscribers() { }
        //public void setSubscribers() { }
        public List<video> getVidoes() 
        {
            List<video> videos = new List<video>();
            videos = bl.getVidoesfromVidoeIds(vidoeIds);
            return videos;
        }
        public void addVideo() { }

        //change
        public void setVideos(List<int> v) {
            vidoeIds = v;
        }
        public int getOwnerId(){ return ownerId; }
        public void setOwnerId(int id) { ownerId = id; }
        public int getSubsNumber() { return subscribersId.Count; }
        //public void getCoverImg () { }
        //public void setCoverImg() { }
        //public void getTags() { }
        //public void setTags() { }

    }
}
