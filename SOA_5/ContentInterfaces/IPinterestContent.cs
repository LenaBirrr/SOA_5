using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5.ContentInterfaces
{
    public interface IPinterestContent:IContent
    {
        public byte[] Photos { get; set; }
    }
}
