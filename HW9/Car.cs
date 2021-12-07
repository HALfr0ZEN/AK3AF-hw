using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Car
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public Car(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}
