using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Tube.Classes
{
    public class comment
    {
        private int videoId; // This is the ID of the video the comment is attached to.  
        private int parentId; // The ID of the comment this comment replied too, blank if it is not a reply
        private int commentId; // The ID of the comment
        private int userId; // The ID of the user who posted this comment
        private int likes; // The number of likes on the comment
        private int dislikes; // The number of dislikes on the comment
        private string text; // The content of the comment
        private string time; // The time of the comment posted
        private string date; // The date the comment was posted

        comment(int XvideoId, int XparentId, int XcommentId, int XuserId, string Xtext)
        {
            videoId = XvideoId;
            parentId = XparentId;
            commentId = XcommentId;
            userId = XcommentId;
            text = Xtext;
            likes = 0;
            dislikes = 0;
            time = DateTime.Now.ToString("h:mm:ss tt");
            date = DateTime.Today.ToString("d");
        }
        
        // Functions on likes
        int getLikes() { return likes; }
        void setLikes(int Xlikes) { likes = Xlikes; }
        void incrementLikes() { likes++; }

        // Functions on dislikes
        int getDislikes() { return dislikes; }
        void setDislikes(int Xdislikes) { dislikes = Xdislikes; }
        void incrementDislikes() { dislikes++; }

        // Functions on text
        string getText() { return text; }
        void setText(string Xtext) { text = Xtext; }

        // Other getters
        int getCommentId() { return commentId; }
        int getVideoId() { return videoId; }
        int getParentId() { return parentId; }
        int getUserId() { return userId; }
        string getTime() { return time; }
        string getDate() { return date; }

        // Destructor
        ~comment() { }
    }
}
