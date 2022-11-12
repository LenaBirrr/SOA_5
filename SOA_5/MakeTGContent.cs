using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class MakeTGContent : IMakeContent
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
            return new TGContent(WriteText(), ThinkOfATopic(), FindAFunder());
        }

        public byte[] TakePhotos()
        {
            throw new NotImplementedException();

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
