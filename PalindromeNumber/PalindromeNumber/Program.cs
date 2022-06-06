using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = 12211;
            int rem;
            int result = 0;
            int temp = num;

            while (num !=0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;

            }
            num = temp;
            //Console.WriteLine(result);
            if (num==result)
            {
                Console.WriteLine("Palindrome number");
            }
            else
            {
                Console.WriteLine("Not palindrome number");
            }
            
            Console.ReadLine();
            
        }
    }
}
