using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public static class CommandOptions
    {
        public static void CountCarBrands()
        {
            var cars = GetCarInfo.updatedListOfCars;

            var numberOfCarTypes = cars.GroupBy(x => x.CarBrand).Count();
            var carsGroupedByModel = cars.GroupBy(x => x.CarBrand).
                Select(c => new { Brand = c.Key });

            Console.WriteLine($"There are {numberOfCarTypes} car types (brands):");
            foreach (var car in carsGroupedByModel)
            {
                Console.WriteLine($"{car.Brand}");
            }
        }

        public static void CountAllCars()
        {
            var cars = GetCarInfo.updatedListOfCars;

            var numberOfCars = cars.Select(c => c.NumberOfCars);

            int totalNumber = 0;

            foreach (var item in numberOfCars)
            {
                totalNumber += item;
            }

            Console.WriteLine($"Total number of cars: {totalNumber}");
        }

        public static void CountAveragePrice()
        {
            var cars = GetCarInfo.updatedListOfCars;

            var avgPrice = cars.Select(c => c.PricePerCar).Average();

            Console.WriteLine($"Average car price: {avgPrice} USD");
        }

        public static void CountAveragePriceForEachBrand(string carBrand)
        {
            var cars = GetCarInfo.updatedListOfCars;

            List<int> prices = new List<int>();

            foreach (var car in cars)
            {
                var brand = car.CarBrand;

                if (brand == carBrand)
                {
                    prices.Add(car.PricePerCar);
                }
            }

            Console.WriteLine($"Average {carBrand} price: {prices.Average()}");
        }
    }
}
