using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public class MakeTGContent : IMakeTGContent
    {
        public string FindAFunder()
        {
            return "funder";
        }

        

        public IContent Post()
        {
            return new TGContent(WriteText(), ThinkOfATopic(), FindAFunder());
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
