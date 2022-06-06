using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 153;
            int rem;
            int cube;
            int result = 0;
            int temp = number;

            while (number!=0)
            {
                rem = number % 10;
                cube = rem * rem * rem;
                result= result + cube;
                number = number / 10;
            }
            number = temp;
            if (number==result)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstong");
            }
            Console.ReadLine();
        }
    }
}
