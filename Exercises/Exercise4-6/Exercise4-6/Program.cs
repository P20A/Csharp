using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // با فرض اینکه: 001101
            // مساوی باشد با: 1101
            // کد درست کار میکند
            // (چون صفر های اول عدد تغییری در خود عدد به وجود نمی آورد و فقط نشان دهنده ظرفیت آن عدد می باشد)
            // bit == ظرفیت
            Console.WriteLine("enter your 8-bit binary number:");
            int x = int.Parse(Console.ReadLine());
            int temp = x;
            double result = 0;
            for (int i = 0; i < 8; i++)
            {
                if (x == 0)
                    break;
                if (x%2 == 0)
                {
                    result += Math.Pow(10, i);
                }
                x /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
