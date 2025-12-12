using System;

namespace Exercise10_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("enter the month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("enter the year: ");
            int year = int.Parse(Console.ReadLine());

            Date date = new Date(day, month, year);
            Console.WriteLine(date.toString());
            date.setDate(23, 4, 2399);
            Console.WriteLine(date.toString());
        }
    }
}
