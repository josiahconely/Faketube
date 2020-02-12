using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fake_Tube.Classes
{
    class BusinessLogic
    {

        public video getVideo(int vidID)
        {
            video newVideo = new video();

            newVideo.setCreatorName("Onion News");
            newVideo.setDislikes(100);
            newVideo.setLikes(101);
            newVideo.setName("Are We Teaching Our Kids Enough About Whales?");
            newVideo.setOwnerId(1);
            newVideo.setVideoId(1);
            newVideo.setViews(102);
            newVideo.setFileName("are_our_children_learning_enough_about_whales_POi4rvN_Yts_360p.mp4");
            newVideo.setPath("C:/vidoes");
            return newVideo;
        }

        public user getUser(int userId)
        {
            
            user u = new user();
            return u;
        }

        public channel getChannel(int channelId)
        {
            channel c = new channel();
            return c;
        }

        // updates the database
        public bool addVideoToChannel (string name, string tags,string fileName, string path, string discription )
        {
            return true;
        }

        public List<video> getVidoesfromVidoeIds( List<int> videoIds)
        {
            List<video> videos = new List<video>();

            // Temp
            video v = new video(1, 1, 1, 1, 1, "great Video", "file1.mp4", "c:/vidoes", "bobthebombdotcom");
            video v2 = new video(1, 1, 1, 1, 1, "even Better Vid", "file2.mp4", "c:/vidoes", "bobthebombdotcom");

            videos.Add(v);
            videos.Add(v2);
            return videos;
        }


    }
}
