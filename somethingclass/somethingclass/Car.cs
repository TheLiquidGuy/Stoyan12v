using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somethingclass
{
    class Car
    {
        public int ImmobilizerId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Array[] Tyre = new Array[4];
        public IgnitionKey IgnitionKey { set; get; }
        public Engine Engine { set; get; }
        public Human Driver { set; get; }
    }
}
