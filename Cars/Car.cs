using System;

namespace Cars
{
    public class Car : IComparable
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int NumberOfCars { get; set; }
        public int PricePerCar { get; set; }

        public Car(string carBrand, string carModel, int numberOfCars, int pricePerCar)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            NumberOfCars = numberOfCars;
            PricePerCar = pricePerCar;
        }
        public int CompareTo(object obj)
        {
            if (obj is Car car)
            {
                return CarBrand.CompareTo(car.CarBrand);
            }
            else throw new ArgumentException("Некорректное значение параметра");
        }
    }
}
