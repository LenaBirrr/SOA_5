using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public interface IMakeContent
    {
        public string ThinkOfATopic();
        public string FindAFunder();
        public byte[] MakeVideo();
        public byte[] TakePhotos();
        public string WriteText();
        public IContent Post();

    }
}
