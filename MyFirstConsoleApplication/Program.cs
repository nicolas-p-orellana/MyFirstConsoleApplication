using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nicolas Orellana";
            string location = "Chile";

            Console.WriteLine($"My name is {name}, I am from {location}");

            DateTime currentDate = DateTime.Now.Date;
            Console.WriteLine($"Current date: {currentDate.ToString("MM/dd/yyyy")}");

            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
            int daysUntilChristmas = (christmas - currentDate).Days;
            Console.WriteLine($"Days until Christmas this year: {daysUntilChristmas}");

            Console.Write("Enter the width of the window in feet: ");
            string widthString = Console.ReadLine();
            double width = double.Parse(widthString);

            Console.Write("Enter the height of the window in feet: ");
            string heightString = Console.ReadLine();
            double height = double.Parse(heightString);

            double woodLength = 2 * (width + height) * 3.25;
            double glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.ReadKey();
        }

    }
}
