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
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute getChannelObjectfromChannelId @paramId";
            cmd.Parameters.Add("@paramId", SqlDbType.Int).Value = channelId;

            string tempName = "";
            int tempId = 0;
            int tempOwnerId = 0;

            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    int.TryParse(row["Id"].ToString(), out tempId);
                    int.TryParse(row["userId"].ToString(), out tempOwnerId);
                    tempName = row["name"].ToString();

                }
            }
            connection.Close();
            channel c = new channel(tempName, tempId, tempOwnerId);
            return c;
        }

        public bool addVideoToChannel(int channelId, string name, string img_url, string vid_URL, string discription)
        {


            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute addNewVideo @channelId_,@name_,@img_url_,@discription_,@video_url_";

            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@channelId_", SqlDbType.Int).Value = channelId;
            cmd.Parameters.Add("@name_", SqlDbType.NChar, 50).Value = name;
            cmd.Parameters.Add("@img_url_", SqlDbType.VarChar).Value = img_url;
            cmd.Parameters.Add("@discription_", SqlDbType.Text).Value = discription;
            cmd.Parameters.Add("@video_url_", SqlDbType.VarChar).Value = vid_URL;



            cmd.ExecuteNonQuery();
            connection.Close();

            return true;

            return false;

        }

        //NOT DONE
        public bool updateVideoToChannel( string name, string FileName, string Description, int VideoId)
        {
            try
            {
                connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connection_string);
                connection.Open();

                // Create the command and set its properties.
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Execute updateVideo @id, @name, @video_url, @description";

                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = VideoId;
                cmd.Parameters.Add("@name", SqlDbType.NChar,50).Value = name;
                cmd.Parameters.Add("@video_url", SqlDbType.VarChar).Value = FileName;
                cmd.Parameters.Add("@description", SqlDbType.Text).Value = Description;
                cmd.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch { return false; }
        }

        public List<video> getVidoesfromVidoeIds(List<int> videoIds)
        {
            List<video> videos = new List<video>();
            foreach (int vid in videoIds) { videos.Add(getVideo(vid)); }
            return videos;
        }
        //NOT DONE
        public bool addCommentToVideo(comment c, int vidId)
        {
            return true;
        }
        //NOT DONE
        public int clickLikeVideo(int videoId, int userId)
        {
            return 2;
            //if 1 like occured unDislike did not occur
            //if 2 like occured unDislike occured
            //if 3 unLike occured
        }
        //NOT DONE
        public int clickDislikeVideo(int videoId, int userId)
        {
            return 2;
            //if 1 dislike occured unlike did not occur
            //if 2 idslike occured unlike occured
            //if 3 unDislike occured
        }

        public List<int> search(string term)
        {
            
            List<int> values = new List<int>();
            int temp;

            connection_string = ConfigurationManager.ConnectionStrings
                ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connection_string);
            connection.Open();

            SqlCommand cmd = new SqlCommand("EXEC search @param1 = '" + term + "'", connection);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                
                foreach (DataRow row in data.Rows)
                {
                    
                    int.TryParse(row["Id"].ToString(), out temp);
                    values.Add(temp);
                    
                }
            }
            connection.Close();


            return values;
        }

        public int getMostRecentVidFromChannel(int chanId)
        {
            connection_string = ConfigurationManager.ConnectionStrings
                ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();

            // Create the command and set its properties.

            SqlCommand cmd = new SqlCommand
               ("mostRecentVid", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@chanId";
            parameter1.SqlDbType = SqlDbType.NChar;
            parameter1.Direction = ParameterDirection.Input;
            parameter1.Value = chanId;
            cmd.Parameters.Add(parameter1);

            int channelId_ = 0;
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                foreach (DataRow row in data.Rows)
                {
                    int.TryParse(row["Id"].ToString(), out channelId_);
                }
            }
            connection.Close();
            return channelId_;
        }

        public List<video> getvideosFromChannelId(int chanId)
        {


            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute getvideoIdsFromChannelId @chanId";
            cmd.Parameters.Add("@chanId", SqlDbType.Int).Value = chanId;

            List<int> values = new List<int>();
            int temp = 0;
            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    int.TryParse(row["Id"].ToString(), out temp);
                    values.Add(temp);
                }
            }
            
            connection.Close();
            return getVidoesfromVidoeIds(values);
        }


        public bool deleteVideo(int vidId)
        {
            try
            {
                connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connection_string);
                connection.Open();

                // Create the command and set its properties.
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Execute deleteVideo @VidId";

                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@VidId", SqlDbType.Int).Value = vidId;




                cmd.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
