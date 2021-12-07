using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Brand
    {
        public string Name { get; set; }
        public Car SelectedCar { get; set; }
        public List<Car> Cars { get; set; }

        public Brand(string name, List<Car> cars)
        {
            Name = name;
            Cars = cars;
            

            SelectedCar = Cars.First();
        }
    }
}
