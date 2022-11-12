using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class YoutubeContent : IContent
    {
        public string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] Video { get; set; }
        public byte[] Photos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
