﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilyuta.Gallery.Model
{
    public class Artist : BaseClass
    {
        public string name { set; get; }
        public DateTime dateOfBirth { set; get; }
        public DateTime dateOfDeath { set; get; }
        public ICollection<Picture> pictures { set; get; }
    }
}
