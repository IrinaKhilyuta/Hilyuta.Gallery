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
        public string homeAddress { set; get; }
        public string presentPost { set; get; }
        public string socialSecurityNumber { set; get; }
        public string authorityIdentifier { set; get; }
        public string medicalInsuranceNumber { set; get; }

        
        //TEMP + some additional information later (информация о договоре по найму на работу)
        public string presentPost { set; get; }
        public ICollection<ExhibitionHall> hallsUnderTheJurisdiction { set; get; }
        //smth more 
    }
}
