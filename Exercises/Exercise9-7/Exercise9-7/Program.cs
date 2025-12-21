using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter: ");
            string value = Console.ReadLine();
            int result;
            bool valid = validator(value, out result);
            if(valid)
            {
                Console.WriteLine($"the value is: {result}");
            }
            else
            {
                Console.WriteLine("the value can not be converted.");
            }


        }
        static bool validator(string value, out int result)
        {
            result = 0;
            try
            {
                result = int.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
                
        }
    }
}
