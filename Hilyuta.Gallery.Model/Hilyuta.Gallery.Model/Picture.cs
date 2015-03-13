using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilyuta.Gallery.Model
{
    public class Picture : BaseClass
    {
        public string name { set; get; }
        public uint yearThePainting { set; get; }
        public Artist author;


        //temp fields?????
        public string TEMP_genre;
        public string TEMP_style;
        public string TEMP_content;
        public string TEMP_technique;

    }
}
