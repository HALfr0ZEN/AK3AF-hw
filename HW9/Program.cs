using System;
using System.Collections.Generic;
using System.Text.Json;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> Cars = new()
            {
                new Car("Focus", 533900),
                new Car("Fiesta", 324900),
                new Car("Puma", 555900)
            };

            Brand brand = new Brand("Ford", Cars);
           
            string brandJSON = JsonSerializer.Serialize(brand);
            Console.WriteLine(brandJSON);

            System.IO.File.WriteAllText("cars.json", brandJSON);
            Car carsDeserialized = JsonSerializer.Deserialize<Car>(brandJSON);
        }
    }
}
