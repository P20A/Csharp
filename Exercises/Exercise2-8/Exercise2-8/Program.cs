using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character:");
            char Char = Convert.ToChar(Console.ReadLine());
            int ski = (int)Char;
            Console.WriteLine($"ski => {ski}");
            int skiP = ski + 2;
            int skiM = ski - 2;
            char charP = Convert.ToChar(skiP);
            char charM = Convert.ToChar(skiM);
            Console.WriteLine($"ski = {ski} , char = {Char}\nski - 2 = {skiM} , char - 2 = {charM}\nski + 2 = {skiP} , char + 2 = {charP}\a");
            


        }
    }
}
