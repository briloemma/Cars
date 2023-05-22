using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class SecondCommand : ICommand
    {
        public int Execute()
        {
            var proceed = ChooseCommand();
            return proceed;
        }
        private static int ChooseCommand()
        {
            Console.WriteLine();
            Console.WriteLine("Choose a command to perform:\n" +
                "1 - Count Car Brands\n" +
                "2 - Count All Cars\n" +
                "3 - Count Average Car Price\n" +
                "4 - Count Average Car Price For A Brand\n" +
                "5 - exit");
            Console.WriteLine();

            int.TryParse(Console.ReadLine(), out var CommandOption);
            var ProceedOrExit = CommandOption;

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
            return ProceedOrExit;
        }
    }
}
