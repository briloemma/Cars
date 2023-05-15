using System;
using System.Collections.Generic;

namespace Cars
{
    public static class GetCarInfo
    {
        public static string CarBrand { get; set; }
        public static string CarModel { get; set; }
        public static int NumberOfCars { get; set; }
        public static int PricePerCar { get; set; }
        public static int ProceedOrExit { get; set; }

        public static int CommandOption;

        public static List<Car> updatedListOfCars = new List<Car>();
        public static void PerformCommands()
        {
            while (ProceedOrExit == 0)
            {
                GetCarInfoo();
                UpdateCarList();
                AddACarOrPerformCommand();
            }

            while (ProceedOrExit != 5)
            {
                ChooseCommand();
            }
        }

        public static void UpdateCarList()
        {
            Car car = new Car(CarBrand, CarModel, NumberOfCars, PricePerCar);
            updatedListOfCars.Add(car);
        }

        private static void GetCarInfoo()
        {
            Console.WriteLine("Enter car brand");
            CarBrand = Console.ReadLine();

            Console.WriteLine("Enter car model");
            CarModel = Console.ReadLine();

            Console.WriteLine("Enter number of cars");
            NumberOfCars = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter price per car in USD");
            PricePerCar = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        private static void AddACarOrPerformCommand()
        {
            Console.WriteLine("Choose: 0 - add a car, 1 - perform a command.");
            ProceedOrExit = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        private static void ChooseCommand()
        {
            Console.WriteLine();
            Console.WriteLine("Choose a command to perform:\n" +
                "1 - Count Car Brands\n" +
                "2 - Count All Cars\n" +
                "3 - Count Average Car Price\n" +
                "4 - Count Average Car Price For A Brand\n" +
                "5 - exit");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out CommandOption);
            ProceedOrExit = CommandOption;

            switch (CommandOption)
            {
                case 1:
                    CommandOptions.CountCarBrands();
                    break;
                case 2:
                    CommandOptions.CountAllCars();
                    break;
                case 3:
                    CommandOptions.CountAveragePrice();
                    break;
                case 4:
                    Console.WriteLine("Enter a brand name");
                    string brandName = Console.ReadLine();
                    CommandOptions.CountAveragePriceForEachBrand(brandName);
                    break;
                case 5:
                    break;
            }
        }
    }
}
