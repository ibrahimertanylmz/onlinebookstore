﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement.Classes
{
    class MusicCD : Product
    {
        public string Singer { get; protected set; }
        public string Type { get; protected set; }
    }
}
