using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if(num % 3 == 0 && num % 5 == 0) { Console.WriteLine("fizzbuzz"); }
            else if(num % 3 != 0 && num % 5 == 0) { Console.WriteLine("buzz"); }
            else if(num % 3 == 0 && num % 5 != 0) { Console.WriteLine("fizz"); }
            else { Console.WriteLine(num); }
        }
    }
}
