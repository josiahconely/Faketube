using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Documents;

namespace Fake_Tube.Classes
{
    class BusinessLogic
    {
        
        string connection_string;
        SqlConnection connection;

        public video getVideo(int vidID)
        {
            vidID = 1;
            video newVideo = new video();
            connection_string = ConfigurationManager.ConnectionStrings
                ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connection_string);
            connection.Open();

            SqlCommand cmd = new SqlCommand("EXEC populateVideo @videoID = '" + vidID + "'", connection);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable video = new DataTable();
                adapter.Fill(video);

        
                foreach (DataRow row in video.Rows)
                {
                    int.TryParse(row["Id"].ToString(), out newVideo.videoId);
                    newVideo.setCreatorName(row["channelName"].ToString());
                    newVideo.setDislikes(100);
                    newVideo.setLikes(101);
                    newVideo.setName(row["name"].ToString());
                    newVideo.setOwnerId(1);
                    newVideo.setURL(row["video_url"].ToString());
                }
            }
            connection.Close();
            return newVideo;
        }

        public users getUser(int userId)
        {
            users u = new users();
            connection_string = ConfigurationManager.ConnectionStrings
                ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connection_string);
            connection.Open();

            SqlCommand cmd = new SqlCommand("EXEC populateUser @userID = '" + userId + "'", connection);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable user = new DataTable();
                adapter.Fill(user);
                foreach (DataRow row in user.Rows)
                {
                    int.TryParse(row["Id"].ToString(), out u.userId);
                    u.userName = (row["userName"].ToString());
                    u.password = (row["password"].ToString());
                    u.coverImg = (row["img_url"].ToString());
                }
            }

            SqlCommand cmd2 = new SqlCommand("EXEC populateUserChannels @userID = '" + userId + "'", connection);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
            {
                DataTable x = new DataTable();
                adapter.Fill(x);
                foreach (DataRow row in x.Rows)
                {
                    int temp;
                    int.TryParse(row["id"].ToString(), out temp);
                    u.myChannels.Add(temp);
                }
            }


            SqlCommand cmd3 = new SqlCommand("EXEC populateUserSubscriptions @userID = '" + userId + "'", connection);

            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd3))
            {
                DataTable x = new DataTable();
                adapter.Fill(x);
                foreach (DataRow row in x.Rows)
                {
                    int temp;
                    int.TryParse(row["channelid"].ToString(), out temp);
                    u.mySubs.Add(temp);
                }
            }

            connection.Close();
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
            video v = new video(1, 1, 1, 1, 1, "great Video", "c:/vidoes/are_our_children_learning_enough_about_whales_POi4rvN_Yts_360p.mp4", "bobthebombdotcom", "the best discription ever");
            video v2 = new video(2, 1, 1, 1, 1, "even Better Vid", "c:/vidoes/12_smartphone_gadgets_you_might_not_believe_existed_IR6V_6xqWDU_360p.mp4", "bobthebombdotcom", "the worst Discription ever");

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


        
        public int clickLikeVideo(int videoId, int userId)
        {
            return 2; 
            //if 1 like occured unDislike did not occur
            //if 2 like occured unDislike occured
            //if 3 unLike occured
        }
        public int clickDislikeVideo(int videoId, int userId)
        {
            return 2;
            //if 1 dislike occured unlike did not occur
            //if 2 idslike occured unlike occured
            //if 3 unDislike occured
        }
    }
}
