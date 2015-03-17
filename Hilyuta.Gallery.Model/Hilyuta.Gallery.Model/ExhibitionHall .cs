using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilyuta.Gallery.Model
{
    public class ExhibitionHall  : BaseClass
    {
        public string name { set; get; }
        public int capacity { set; get; }
        public ICollection<Picture> pictures { set; get; }
        public ICollection<Employeer> employeers { set; get; }
    }
}
