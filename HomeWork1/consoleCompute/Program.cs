using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpe
{

    class Program
    {

        static void Main(string[] args)
        {
            double temp = 0.0;

            double num1=0.0,num2=0.0;

            bool jugde(string input, double num)
            {
                if (Double.TryParse(input, out num))
                {
                    temp = num;
                    return true;
                }
                else
                {
                    Console.WriteLine("Input erorr, please try again! ");
                    return false;
                }

            }
            Console.Write("Please enter the first number:");

            while (!jugde(Console.ReadLine(), temp)) { }
            
                num1 = temp;

            Console.WriteLine("Please enter the second number:");
            while (!jugde(Console.ReadLine(), temp)) { }

            num2 = temp;

            Console.WriteLine("Please enter the operate:+,-,*,/");
            string inputStr = Console.ReadLine();
            while (inputStr!="+"&&inputStr!="-"&&inputStr!="*"&&inputStr!="/")
            {
                Console.WriteLine("Input error,please input correctly!");
                Console.WriteLine("Please enter the operate:+,-,*,/");
                inputStr = Console.ReadLine();
            }
            switch (inputStr)
            {
                case "+":
                    Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1}*{num2}={num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"{num1}/{num2}={num1 / num2}");
                    break;
                default:
                    break;
            }
        }
    }
}
