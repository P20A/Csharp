using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperture(Celsius):");
            int tempC = int.Parse(Console.ReadLine());
            int tempK = tempC + 273;
            int tempF = tempC * 9 / 5 + 32;
            Console.WriteLine($"the results are:\nCelsius:{tempC}\nkelvin: {tempK}\nFahrenheit: {tempF}");
        }
    }
}
