using lesson2hmwrk.Models;
using System.IO.Compression;

namespace lesson2hmwrk.Service;

internal class CarService
{

    List<Car> cars = new List<Car>();
    int id = 1;

    // Create
    public void Create(string brend, string name, string color, decimal price, Guid id, int years)
    {
        List<Car> cars = new List<Car>();
    }
    public void Create(Guid id, string brend, string name, string color, decimal price, int years)
    {
        Car car = new Car();
        car.Id = Guid.NewGuid();
        car.BrendCar = brend;
        car.NameCar = name;
        car.CarColor = color;
        car.PriceCar = price;
        car.YearsCar = years;

        cars.Add(car);
    }
    // Read
    public void GatAllCar()
    {
        if(cars.Count == 0)
        {
            Console.WriteLine("Error Car !");
            return;
        }
        for (var i =  0; i < cars.Count; i++)
        {
            Console.WriteLine(
                cars[i].Id + " " +
                cars[i].BrendCar + " " +
                cars[i].NameCar + " " +
                cars[i].CarColor + " " +
                cars[i].PriceCar + " " +
                cars[i].YearsCar 
            );
        }
    }
    // Update

    public void Update(Guid id, string brend, string name, string color, decimal price, int years)
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i].Id == id)
            {
                cars[i].BrendCar = brend ;
                cars[i].NameCar = name;
                cars[i].CarColor = color;
                cars[i].PriceCar = price;
                cars[i].YearsCar = years;

                Console.WriteLine("Update qilindi");
                return;
            }
        }

        Console.WriteLine("Bunday ID topilmadi");
    }
    public void Deleted(Guid id)
    {
        for(var i = 0; i < cars.Count;i++)
        {
            if(cars[i].Id == id)
            {
                cars.RemoveAt(i);
                Console.WriteLine("Deleted");
                return;
            }
        }
        Console.WriteLine("Bnaqa Id topilmadi ! ");
    }

}
