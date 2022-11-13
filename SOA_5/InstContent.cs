using SOA_5.ContentInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class InstContent : IInstContent
    {
        public string Text { get; set; }
        public byte[] Video { get; set; }
        public byte[] Photos { get; set; }
        public string Topic { get; set; }
        public string Funder { get; set; }

        public InstContent(string text, byte[] video, byte[] photos, string topic, string funder)
        {
            Text = text;
            Video = video;
            Photos = photos;
            Topic = topic;
            Funder = funder;
        }
    }
}
