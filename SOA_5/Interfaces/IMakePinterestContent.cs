﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA_5
{
    public interface IMakePinterestContent:IMakeContent
    {
        public byte[] TakePhotos();
    }
}
