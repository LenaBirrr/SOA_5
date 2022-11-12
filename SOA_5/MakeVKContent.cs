using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class MakeVKContent:IMakeContent
    {
        public string FindAFunder()
        {
            return "funder";
        }

        public byte[] MakeVideo()
        {
            throw new NotImplementedException();

        }

        public IContent Post()
        {
            return new VKContent(WriteText(), TakePhotos(), ThinkOfATopic(), FindAFunder());
        }

        public byte[] TakePhotos()
        {
            byte[] photos = { 0x10 };
            return photos;
        }

        public string ThinkOfATopic()
        {
            return "";
        }

        public string WriteText()
        {
            return "";
        }
    }
}
