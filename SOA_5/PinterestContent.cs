using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class PinterestContent : IContent
    {
        public string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] Video { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] Photos { get; set; }
        public string Topic { get; set; }
        public string Funder { get; set; }

        public PinterestContent(byte[] photos, string topic, string funder)
        {
            Photos = photos;
            Topic = topic;
            Funder = funder;
        }
    }
}
