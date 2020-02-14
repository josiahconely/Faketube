using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Tube.Classes
{
    class video
    {

        //atributes

        //video file
        // indicates a new video if value is -1
        public int videoId = -1;
        
        private int ownerId;
        private int views;
        private int likes;
        private int dislikes;
        private string name;
        public string nameText { get; set; }
        private string fileName;
        private string path;
        private string creatorName;
        private string description;

        
        List<comment> comments;
        //img coverImgage;
        List<string> tags = new List<string>();


        //constructor
        public video() { }
        public video(int _videoId, int _onwerId, int _views, int _likes,int _dislikes,
            string _name, string _fileName, string _path, string _creatorName, string _description){

        videoId =_videoId;
        ownerId = _onwerId;
        views =_views;
        likes =_likes;
        dislikes =_dislikes;
        name =_name;
        fileName =_fileName;
        path =_path;
        creatorName =_creatorName;
        nameText = name;
        description = _description;


        }


        //gets/sets

        public void setFileName(string s) { fileName = s; }
        public string getFileName() { return fileName; }
        public void setPath(string s) { path = s; }
        public string getPath() { return path; }
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

        

        public string getURL() { return this.path + "/" + this.fileName; }

        //NOT DONE
        public void incLikes() { likes += 1; }
        public void decLikes() { likes -= 1; }
        public void incDislikes() { dislikes += 1; }
        public void decDislikes() { dislikes -= 1; }
        public void incViews() { }
        public void loadComments() { }
        public void addComment() { }
        
        
        
        //Destructor
    }
}
