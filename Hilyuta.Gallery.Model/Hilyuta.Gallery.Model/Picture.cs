using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilyuta.Gallery.Model
{
    public class Picture
    {
        public string name { set; get; }
        public uint yearThePainting { set; get; }
        public Artist author;

    }
}
