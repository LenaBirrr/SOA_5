using SOA_5.ContentInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class YoutubeContent : IYoutibeContent
    {
        public byte[] Video { get; set; }
        public string Topic { get; set; }
        public string Funder { get; set; }

        public YoutubeContent(byte[] video, string topic, string funder)
        {
            Video = video;
            Topic = topic;
            Funder = funder;
        }
    }
}
