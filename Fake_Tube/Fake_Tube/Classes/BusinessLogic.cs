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
    }
}
