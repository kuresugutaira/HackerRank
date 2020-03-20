using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var abcd = Console.ReadLine().Split(' ');
            var nums = new int[4];
            int result = 0;
            for(int i = 0; i < 4; i++)
            {
                nums[i] = int.Parse(abcd[i]);
            }
            var time = nums[3]/nums[2];
            for(int z = 0; z <= time; z++)//(Ax + By = D - Czについて解いていく) 
            {
                var uhen = nums[3] - nums[2] * z;
                for(int y = 0; nums[1] * y <= uhen; y++)
                {
                    for(int x = 0;nums[0] * x + nums[1] * y <= uhen; x++)
                    {
                        if (nums[0] * x + nums[1] * y == uhen)
                        {
                            result++;
                        }
                    }
                }
            }
            Console.WriteLine(result);
        } 
    }
}
