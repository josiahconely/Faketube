using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Tube.Classes
{
    public class video
    {

        //atributes
        private BusinessLogic bl = new BusinessLogic();
        //video file
        // indicates a new video if value is -1
        public int videoId = -1;
        
        private int ownerId;
        public int views;
        private int likes;
        private int dislikes;
        public string name;
        public string nameText { get; set; }
        private string URL;
       
        private string creatorName;
        private string description;


       
        //img coverImgage;
        List<string> tags = new List<string>();


        //constructor
        public video() { }
        public video(int _videoId, int _onwerId, int _views, int _likes,int _dislikes,
            string _name, string _URL, string _creatorName, string _description){

        videoId =_videoId;
        ownerId = _onwerId;
        views =_views;
        likes =_likes;
        dislikes =_dislikes;
        name =_name;
        URL = _URL;
        creatorName =_creatorName;
        nameText = name;
        description = _description;


        }

        public string Name
        {

            get
            {
                return name;
            }
        }
        //gets/sets

        public void setURL(string s) { URL= s; }
        public string getURL() { return URL; }
        public int getVideoId() { return videoId; }
        public void setVideoId(int id) { videoId = id; }
        public int getOwnerId() { return ownerId; }
        public void setOwnerId(int id) { ownerId = id; }
        public string getName() { return name; }
        public void setName(string n) { name = n; }
        public int getViews() { return views; }
        public void setViews(int v) { views = v; }  
        public int getLikes() { return likes; }
        public void setLikes(int l) { likes = l ; }
        public int getDislikes() { return dislikes; }
        public void setDislikes(int d) { dislikes = d; }
        public void setCreatorName (string s) { creatorName = s; }
        public string getcreatorName () { return creatorName; }

        public void setDescription(string d) { description = d; }
        public string getDescription() { return description; }

        

        public string getTagsString()
        {
            string s = "";

            foreach (string t in tags)
            {
                s += t;
            }
            return s;
        }

        


        //public image

        

       

        //NOT DONE
        
        
        
        
        
        
        
        
        //Destructor
    }
}
