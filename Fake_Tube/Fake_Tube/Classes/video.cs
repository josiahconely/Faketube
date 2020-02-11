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
        private string fileName;
        private string path;
        //video file
        int videoId;
        int ownerId;
        string name;
        string creatorName;
        int views;
        int likes; 
        int dislikes;
        List<comment> comments;
        //img coverImgage;
        List<tag> tags;


        //constructor
        public video() { }
        

        //gets/sets

        public void setFileName(string s) { fileName = s; }
        public void setPath(string s) { path = s; }
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
