using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore
{
    class Phone
    {
        public string Model { get; set; }
        public string System { get; set; }
        public decimal Price { get; set; }
        public string SystemUpdate { get; set; }

        public override string ToString()
        {
            return String.Format("{0}  {1} - {2}. Цена {3}", Model, System, SystemUpdate, Price);
        }
    }
}
