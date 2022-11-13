using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class MakePinterestContent:IMakePinterestContent
    {
        public string FindAFunder()
        {
            return "funder";
        }

       
        public IContent Post()
        {
            return new PinterestContent(TakePhotos(), ThinkOfATopic(), FindAFunder());
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

    }
}
