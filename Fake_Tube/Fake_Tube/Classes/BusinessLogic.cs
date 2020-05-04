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
            incViewCount(vidID);
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
                    newVideo.setDislikes(getDislikes(newVideo.videoId));
                    newVideo.setLikes(getLikes(newVideo.videoId));
                    newVideo.setName(row["name"].ToString());
                    newVideo.setOwnerId(1);
                    newVideo.setURL(row["video_url"].ToString());
                    int.TryParse(row["view_count"].ToString(), out newVideo.views);
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
        public void addCommentToVideo(string text, int vidId)
        {
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute addCommentToVideo @userId,@videoId,@Text";

            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = global_vars.userId;
            cmd.Parameters.Add("@videoId", SqlDbType.Int).Value = vidId;
            cmd.Parameters.Add("@Text", SqlDbType.Text).Value = text;
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public List<string> getComments(int vidId)
        {
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute getComments @videoId";
            cmd.Parameters.Add("@videoId", SqlDbType.Int).Value = vidId;

            List<string> commentText = new List<string>();
            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    commentText.Add(row["userName"].ToString() + ": " + row["text"].ToString());
                }
            }
            connection.Close();
            return commentText;
        }


        //NOT DONE
        public int clickLikeVideo(int videoId, int userId)
        {
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute getLikeStatus @userId, @videoId";
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;

            
            int switchController = -1;
            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    try
                    {
                        int.TryParse(row["status"].ToString(), out switchController);
                       
                    }
                    catch
                    {
                      
                    }
                }
            }

            switch (switchController)
            {
                case -1:
                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd1.CommandText = "Execute addLikeStatus @userId, @videoId, @status";

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                    cmd1.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;
                    cmd1.Parameters.Add("@status", SqlDbType.Int).Value = 1;
                    cmd1.ExecuteNonQuery();
                    return 1;
                    break;
                case 0:
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = "Execute updateLikeStatus @userId, @videoId, @status";

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                    cmd2.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;
                    cmd2.Parameters.Add("@status", SqlDbType.Int).Value = 1;
                    cmd2.ExecuteNonQuery();
                    return 2;
                    break;
                case 1:
                    SqlCommand cmd3 = connection.CreateCommand();
                    cmd3.CommandText = "Execute deleteLikeStatus @userId, @videoId, @status";

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                    cmd3.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;
                    cmd3.Parameters.Add("@status", SqlDbType.Int).Value = 0;
                    cmd3.ExecuteNonQuery();
                    return 3;
                    break;
                default:
                    return 4;
            }
            connection.Close();
            return 4;
            //if 1 like occured unDislike did not occur
            //if 2 like occured unDislike occured
            //if 3 unLike occured
        }
        //NOT DONE
        public int clickDislikeVideo(int videoId, int userId)
        {
            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute getLikeStatus @userId, @videoId";
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;


            int switchController = -1;
            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    try
                    {
                        int.TryParse(row["status"].ToString(), out switchController);
                      
                    }
                    catch
                    {

                    }
                }
            }

            switch (switchController)
            {
                case -1:
                    SqlCommand cmd1 = connection.CreateCommand();
                    cmd1.CommandText = "Execute addLikeStatus @userId, @videoId, @status";

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                    cmd1.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;
                    cmd1.Parameters.Add("@status", SqlDbType.Int).Value = 0;
                    cmd1.ExecuteNonQuery();
                    return 1;
                    break;
                case 1:
                    SqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = "Execute updateLikeStatus @userId, @videoId, @status";

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                    cmd2.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;
                    cmd2.Parameters.Add("@status", SqlDbType.Int).Value = 0;
                    cmd2.ExecuteNonQuery();
                    return 2;
                    break;
                case 0:
                    SqlCommand cmd3 = connection.CreateCommand();
                    cmd3.CommandText = "Execute deleteLikeStatus @userId, @videoId, @status";

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                    cmd3.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;
                    cmd3.Parameters.Add("@status", SqlDbType.Int).Value = 0;
                    cmd3.ExecuteNonQuery();
                    return 3;
                    break;
                default:
                    return 4;
            }
            connection.Close();
            return 4;
            //if 1 like occured unDislike did not occur
            //if 2 like occured unDislike occured
            //if 3 unLike occured
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

        public List<int> searchChannels(string term)
        {
            List<int> values = new List<int>();
            int temp;
            connection_string = ConfigurationManager.ConnectionStrings
                ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            connection = new SqlConnection(connection_string);
            connection.Open();
            SqlCommand cmd = new SqlCommand("EXEC searchChannels @param1 = '" + term + "'", connection);
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
        public void incViewCount(int id)
        {

            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute incViewCount @id";

            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.ExecuteNonQuery();
            connection.Close();



        }

        public int getLikes(int videoId)
        {
            int likes =0;

            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute getLikesNumber @videoId";
            cmd.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;

            
           
            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (data.Rows.Count > 0)
                {
                    
                    
                    foreach (DataRow row in data.Rows)
                    {
                        int.TryParse(row["numLikes"].ToString(), out likes);
                    }
                }
            }

            connection.Close();
            
            return likes;
        }

        public int getDislikes (int videoId)
        {
            int dislikes = 0;

            connection_string = ConfigurationManager.ConnectionStrings
               ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);

            // Create the command and set its properties.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute getDisLikesNumber @videoId";
            cmd.Parameters.Add("@videoId", SqlDbType.Int).Value = videoId;



            connection.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow row in data.Rows)
                    {
                        int.TryParse(row["numDisLikes"].ToString(), out dislikes);
                    }
                }
            }
            connection.Close();
            return dislikes;
        }

        public void addNewUser(string userName, string password, string channelName)
        {
            try
            {
                connection_string = ConfigurationManager.ConnectionStrings
                   ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connection_string);
                connection.Open();

                // Create new User.
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Execute addUser @userName, @password";
                cmd.Parameters.Add("@userName", SqlDbType.NChar, 20).Value = userName;
                cmd.Parameters.Add("@password", SqlDbType.NChar, 20).Value = password;
                cmd.ExecuteNonQuery();

                //Gets user Id
                SqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "Execute getUserIdfromUserName @userName";
                cmd2.Parameters.Add("@userName", SqlDbType.NChar, 20).Value = userName;
                int userId = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        foreach (DataRow row in data.Rows)
                        {
                            int.TryParse(row["id"].ToString(), out userId);
                        }
                    }
                }

                // adds one channel for new user
                SqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandText = "Execute addNewChannel @name,@userId";
                cmd1.Parameters.Add("@name", SqlDbType.NChar, 20).Value = channelName;
                cmd1.Parameters.Add("@userId", SqlDbType.NChar, 20).Value = userId;
                cmd1.ExecuteNonQuery();

                //Get new ChannelId
                SqlCommand cmd3 = connection.CreateCommand();
                cmd3.CommandText = "Execute getchanIdfromchanName @chanName";
                cmd3.Parameters.Add("@chanName", SqlDbType.NChar, 20).Value = channelName;
                int channelId = 0;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd3))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    if (data.Rows.Count > 0)
                    {
                        foreach (DataRow row in data.Rows)
                        {
                            int.TryParse(row["id"].ToString(), out channelId);
                        }
                    }
                }
                //subscribe to yoself
                connection.Close();
                subscribeToChannel(channelId, userId);
            }
            catch
            {

            }
        }

        public void subscribeToChannel(int chanId, int userId) 
        {
            connection_string = ConfigurationManager.ConnectionStrings
                   ["Fake_Tube.Properties.Settings.Faketube_databaseConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();

            // Create new User.
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "Execute subscribeToChannel @userId,@channelId ";
            cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
            cmd.Parameters.Add("@channelId", SqlDbType.Int).Value = chanId;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }

}
