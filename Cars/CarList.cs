using System.Collections.Generic;

namespace Cars
{
    public sealed class CarList
    {
        private CarList() { }

        private static List<Car> listOfCars;
        public static List<Car> GetInstance()
        {
            if (listOfCars == null)
            {
                listOfCars = new List<Car>();
            }
            return listOfCars;
        }
    }
}
