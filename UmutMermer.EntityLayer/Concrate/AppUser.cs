﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmutMermer.EntityLayer.Concrate
{
    public class AppUser :IdentityUser<int>
    {
        public string Name { get; set; }
    }
}
