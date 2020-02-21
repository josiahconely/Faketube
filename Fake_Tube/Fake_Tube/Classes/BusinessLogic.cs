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
            //TEMP
            List<int> vidIds = new List<int>(new int[] { 1, 2, 3 });
            c.setVideos(vidIds);
            return c;
        }

        // updates the database OVERLOADED IF NO ID PROVIDED CREATES NEW RECORD IN DATABASE
        public bool updateVideoToChannel(string name, string tags, string fileName, string path, string discription)
        {
            if (name != "") { return true; }
            return false;
            //update database add vidId to channel

        }

        public bool updateVideoToChannel(string name, string tags, string fileName, string path, string discription, int vidId)
        {
            if (name != "") { return true; }
            return false;
        }

        public List<video> getVidoesfromVidoeIds(List<int> videoIds)
        {
            List<video> videos = new List<video>();

            // Temp
            video v = new video(1, 1, 1, 1, 1, "great Video", "are_our_children_learning_enough_about_whales_POi4rvN_Yts_360p.mp4", "c:/vidoes", "bobthebombdotcom", "the best discription ever");
            video v2 = new video(2, 1, 1, 1, 1, "even Better Vid", "12_smartphone_gadgets_you_might_not_believe_existed_IR6V_6xqWDU_360p.mp4", "c:/vidoes", "bobthebombdotcom", "the worst Discription ever");

            videos.Add(v);
            videos.Add(v2);
            return videos;
        }

        public bool vaidVideoName()
        { return true; }

        //not done
        public bool addCommentToVideo(comment c, int vidId)
        {
            return true;
        }

        public bool likeVideo(int videoId, int userId)
        {
            return true;
            //set logic for switching 
        }
    }
}
