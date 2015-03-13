using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilyuta.Gallery.Model
{
    public class Employeer : BaseClass
    {
        public string name { set; get; }
        public DateTime dateOfBirth { set; get; }

        //TEMP + some additional information later
        public string presentPost { set; get; }
        public ICollection<ExhibitionHall> hallsUnderTheJurisdiction { set; get; }
        //smth more 
    }
}
