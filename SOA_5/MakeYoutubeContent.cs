using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class MakeYoutubeContent:IMakeYoutubeContent
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
            return new YoutubeContent(MakeVideo(), ThinkOfATopic(), FindAFunder());
        }

       

        public string ThinkOfATopic()
        {
            return "";
        }

     
    }
}
