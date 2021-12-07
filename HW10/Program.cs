using System;
using System.Collections.Generic;
using System.Linq;


namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CarContext context = new())
            {
                context.Database.EnsureDeleted();
                Console.WriteLine("Databáze vytvořena");
                context.Database.EnsureCreated();

                Console.WriteLine("Přidávám záznamy");
                context.AddRange(new Car(1, "Focus"));
                context.AddRange(new Car(2, "Fiesta"));
                context.AddRange(new Car(3, "Puma"));
                
                context.SaveChanges();
            }

            using (CarContext context = new())
            {
                Console.WriteLine("Provádím query delete na prvním záznamu");
                context.Remove(new Car(1, "Focus"));

                context.SaveChanges();
            }

            using (CarContext context = new())
            {
                Console.WriteLine("Provádím query update na druhém záznamu");
                context.Update(new Car(2, "Mustang"));

                context.SaveChanges();
            }

            using (CarContext context = new())
            {
                Console.WriteLine("Stavající databáze obsahuje (seřazeno podle jména): ");
                List<Car> cars = context
                    .Cars.OrderByDescending(x => x.Name)
                    .ToList();

                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Id} | {car.Name}");
                }

            }
        }
    }
}
