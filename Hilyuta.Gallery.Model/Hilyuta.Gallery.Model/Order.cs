using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilyuta.Gallery.Model
{
    public class Order : BaseClass
    {
        public string category { get; set; }
        public string clientName { get; set; }
        public string numberOfVisitios { get; set; }
        public DateTime orderTime { get; set; }
        public DateTime orderDate { get; set; }
        public double price { get; set; }
    }
}
