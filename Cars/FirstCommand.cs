using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class FirstCommand : ICommand
    {
        public int Execute()
        {
            UpdateCarList(GetCarInfo());
            var proceed = AddACarOrPerformCommand();
            return proceed;
        }

        public void UpdateCarList(Car car)
        {
            CarList.GetInstance().Add(car);
        }

        public Car GetCarInfo()
        {
            Console.WriteLine("Enter car brand");
            var CarBrand = Console.ReadLine();

            Console.WriteLine("Enter car model");
            var CarModel = Console.ReadLine();

            
            Console.WriteLine("Enter number of cars");
            var NumberOfCars = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per car in USD");
            var PricePerCar = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Car car = new Car(CarBrand, CarModel, NumberOfCars, PricePerCar);

            return car;
        }

        public static int AddACarOrPerformCommand()
        {
            Console.WriteLine("Choose: 0 - add a car, 1 - perform a command.");
            var NumberOfCars = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return NumberOfCars;
        }
    }
}
