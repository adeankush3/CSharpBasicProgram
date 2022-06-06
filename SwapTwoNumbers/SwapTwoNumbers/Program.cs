using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int temp;
            Console.WriteLine("Before Swapping value a={0},b={1}", a, b);
            temp = a;
            a = b;
            b= temp;
            Console.WriteLine("After Swapping Value a={0},b={1}", a, b);
            Console.ReadLine();
        }
    }
}
