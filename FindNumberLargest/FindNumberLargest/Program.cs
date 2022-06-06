using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumberLargest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 20;

            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("Num1 is Gretter");
                }
                else
                {
                    Console.WriteLine("Num3 is Gretter");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Num2 is Gretter");
                }
                else
                {
                    Console.WriteLine("Num3 is Gretter");
                }
            }
            //if(num1> num2 &&num1>num3)
            //{
            //    Console.WriteLine("Num1 is Gretter");
            //}
            //else if(num2>num3 &&num2>num1)
            //{
            //    Console.WriteLine("Num2 is Gretter");
            //}
            //else
            //{
            //    Console.WriteLine("Num3 is Gretter");
            //}
            Console.ReadLine();
        }
    }
}
