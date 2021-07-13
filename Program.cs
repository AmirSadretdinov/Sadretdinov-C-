using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Садретдинов_Тестовое_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //задание 1
                //int a;
                //Console.WriteLine("введите число");
                //a = Convert.ToInt32(Console.ReadLine());
                //if (a >= 7)
                //{ Console.WriteLine("Привет!"); }
                
            }
            {//задание 3
                int[] nums = { 3, 6, 7, 9, 1, 21, 15, 36 };
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                { if (nums[i] % 3 == 0)
                        Console.Write("\t"+nums[i]);
                }
                Console.ReadKey();
                     


            }
        }
    }
}
