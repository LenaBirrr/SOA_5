using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public interface IContent
    {
        public string Topic { get; set; }
        public string Funder { get; set; }
        public string Text { get; set; }
        public byte[] Video { get; set; }
        public byte[] Photos { get; set; }

    }
}
