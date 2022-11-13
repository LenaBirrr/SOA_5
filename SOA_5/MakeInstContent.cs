using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class MakeInstContent:IMakeInstContent
    {
        public string FindAFunder()
        {
            return "funder";
        }

        public byte[] MakeVideo()
        {
            byte[] video = { 0x10 };
            return video;
        }

        public IContent Post()
        {
            return new InstContent(WriteText(), MakeVideo(), TakePhotos(), ThinkOfATopic(),FindAFunder());
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
