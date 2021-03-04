using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class lesson040321
    {
        public static void Main1()
        {
            Console.WriteLine("Enter First number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            int z = Add(a, b);
            Console.WriteLine($"{a} + {b} = {z}" + z.ToString());



            Console.ReadLine();


        }

        static int Add(int x, int y)
        {

            return x + y;



        }
    }
}
