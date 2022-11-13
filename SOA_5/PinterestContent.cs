using SOA_5.ContentInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class PinterestContent : IPinterestContent
    {
       
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
