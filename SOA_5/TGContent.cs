using SOA_5.ContentInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class TGContent : ITGContent
    {
        public string Text { get; set; }
        
        public string Topic { get; set; }
        public string Funder { get; set; }

        public TGContent(string text, string topic, string funder)
        {
            Text = text;
            Topic = topic;
            Funder = funder;
        }
    }
}
