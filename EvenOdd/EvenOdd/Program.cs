using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int num = 5;
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Number is Even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is Odd");
            //}
            //Console.ReadLine();

            for (int i = 0; i <=100; i++)
            {
                if (i % 2 == 1)//if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("Number Is Even"+i);
            }
            Console.ReadLine();
        }
    }
}
