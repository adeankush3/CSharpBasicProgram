using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUsingSwitchStatement
{
    public class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.WriteLine("Enter First Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Symbols(+,-,*,/)");
            string symbols = Console.ReadLine();

            switch (symbols)
            {
                case "+":
                    res=num1+ num2;
                    Console.WriteLine("Adition " + res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine("Subtraction " + res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Multiplication " + res);
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine("division " + res);
                    break;
               
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            Console.ReadLine();
        }
    }
}
