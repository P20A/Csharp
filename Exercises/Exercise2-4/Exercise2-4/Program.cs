using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float floatNum = 24562.566723456789f;
            int intNum = (int)floatNum;
            short shortNum = (short)floatNum;
            byte byteNum = (byte)floatNum;
            // توانایی تبدیل فلوت به بولین رو نداریم
            long longNum = (long)floatNum;
            char charNum = (char)floatNum;
            Console.WriteLine($"float: {floatNum} ,int: {intNum} ,short: {shortNum} " +
                $",byte: {byteNum} ,long: {longNum} ,char: {charNum}");
        }
    }
}
