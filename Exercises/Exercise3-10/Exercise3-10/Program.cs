using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your weight(kg):");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your height(cm):");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / (Math.Pow(height / 100, 2));
            if (BMI < 18.5)
                Console.WriteLine("Under weight");
            else if (BMI < 25)
                Console.WriteLine("Normal");
            else if (BMI < 30)
                Console.WriteLine("Over weight");
            else
                Console.WriteLine("obese");



        }
    }
}
