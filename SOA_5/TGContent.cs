using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class TGContent : IContent
    {
        public string Text { get; set; }
        public byte[] Video { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] Photos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
