using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Tube.Classes
{
    public class playlist
    {
        private int playlistId; // The ID of the playlist
        private List<int> videosId; // List of ID numbers for videos in the playlist
        private List<string> tags; // List of ID numbers for tags on the playlist
        private string playlistName; // Name of the playlist
        private string description; // Breif desctiption of the playlist
        private int userId; // ID of the owner of the playlist

        public playlist() { }
        public playlist(int XuserId, int XplaylistId, string XplaylistName, string Xdescription)
        {
            userId = XuserId;
            playlistId = XplaylistId;
            playlistName = XplaylistName;
            description = Xdescription;
        }

        // Getters and setters
        public int getPlaylistId() { return playlistId; }
        public int getUserId() { return userId; }
        public string getPlaylistName() { return playlistName; }
        public string getDescription() { return description; }
        public void setPlaylistName(string Xname) { playlistName = Xname; }
        public void setDesctiption(string Xdescription) { description = Xdescription; }
        public List<string> getTags() { return tags; }
        public List<int> getVideoIds() { return videosId; }
        // List add/delete functions
        public bool addVideo(int Xid)
        {
            if (!videosId.Contains(Xid))
            {
                videosId.Add(Xid);
                return true;
            }
            return false;
        }
        public bool addTag(string Xtag)
        {
            if (!tags.Contains(Xtag) && tags.Count() < 20)
            {
                tags.Add(Xtag);
                return true;
            }
            return false;
        }
        public bool deleteVideo(int Xid)
        {
            if (!videosId.Contains(Xid))
            {
                videosId.Remove(Xid);
                return true;
            }
            return false;
        }
        public bool deleteTag(string Xtag)
        {
            if (!tags.Contains(Xtag))
            {
                tags.Remove(Xtag);
                return true;
            }
            return false;
        }

        // Destructor
        ~playlist() { }
    }
}
