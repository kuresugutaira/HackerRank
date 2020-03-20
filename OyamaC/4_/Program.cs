using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            var time = int.Parse(Console.ReadLine());
            var info = new string[time][];
            var now = 0;
            for (int i = 0; i < time; i++)
            {
                info[i] = Console.ReadLine().Split(' ');
            }

            ///バブルソートは計算量が大きいのでヒープソートを用いる
            ///
            /// ソート
            ///

            var stack = new Stack<string[]>(info);
            while(stack.Count > 0)
            {
                var tmp = stack.Pop();
                if(int.Parse(tmp[0]) >= now)
                {
                    now = Eat(tmp, now);
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }

        static int Eat(string[] data,int now) 
        {
            now += int.Parse(data[1]);
            count += 1;
            return now;
        }
    }
}
