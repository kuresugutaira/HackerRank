using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int hour = num / 3600;
            Console.WriteLine(hour);
            int min = (num % 3600) / 60;
            Console.WriteLine(min);
            int sec = num % 60;
            Console.WriteLine(sec);
        }
    }
}
