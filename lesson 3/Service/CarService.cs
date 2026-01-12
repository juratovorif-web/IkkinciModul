

using lesson_3.Models;
using System.Dynamic;

namespace lesson_3.Service;

internal class CarService
{
    List<Car> Cars = new List<Car>();

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        Cars.Add(car);
        return car.CarId;
    }

    public Car? GetByIdCar(Guid carId)
    {
        foreach(var car in Cars)
        {
            if(car.CarId == carId)
            {
                return car;
            }
        }
        return null;
    }

    public bool DeleteCar(Guid carId)
    {
        var car = GetByIdCar(carId);
        if(car == null)
        {
            return false;
        }
        Cars.Remove(car);
        return true;
    }

    public List<Car> GetAllCars()
    {
        return Cars;
    }

    public bool UpdateCar(Guid carId, Car newCar)
    {
        var car = GetByIdCar(carId);
        if(car == null)
        {
            return false;
        }
        car.Model = newCar.Model;
        car.Brend = newCar.Brend;
        car.Price = newCar.Price;
        car.Color = newCar.Color;

        return true;
            
    }

}
  