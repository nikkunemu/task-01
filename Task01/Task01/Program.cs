using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string number1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string number2 = Console.ReadLine();

            double intNum1 = 0;
            double intNum2 = 0;

            switch (number1)
            {
                case "zero":
                    intNum1 = 0;
                    break;
                case "one":
                    intNum1 = 1;
                    break;
                case "two":
                    intNum1 = 2;
                    break;
                case "three":
                    intNum1 = 3;
                    break;
                case "four":
                    intNum1 = 4;
                    break;
                case "five":
                    intNum1 = 5;
                    break;
                case "six":
                    intNum1 = 6;
                    break;
                case "seven":
                    intNum1 = 7;
                    break;
                case "eight":
                    intNum1 = 8;
                    break;
                case "nine":
                    intNum1 = 9;
                    break;
            }

            switch (number2)
            {
                case "zero":
                    intNum2 = 0;
                    break;
                case "one":
                    intNum2 = 1;
                    break;
                case "two":
                    intNum2 = 2;
                    break;
                case "three":
                    intNum2 = 3;
                    break;
                case "four":
                    intNum2 = 4;
                    break;
                case "five":
                    intNum2 = 5;
                    break;
                case "six":
                    intNum2 = 6;
                    break;
                case "seven":
                    intNum2 = 7;
                    break;
                case "eight":
                    intNum2 = 8;
                    break;
                case "nine":
                    intNum2 = 9;
                    break;
            }

            Console.Write("Enter operator: ");
            string operat = Console.ReadLine();

            switch (operat)
            {
                case "+":
                    Console.WriteLine("Result: {0} + {1} = {2}", intNum1, intNum2, intNum1 + intNum2);
                    break;
                case "-":
                    Console.Write("Result: {0} - {1} = {2}", intNum1, intNum2, intNum1 - intNum2);
                    break;
                case "/":
                    Console.Write("Result: {0} / {1} = {2}", intNum1, intNum2, intNum1 / intNum2);
                    break;
                case "*":
                    Console.Write("Result: {0} * {1} = {2}", intNum1, intNum2, intNum1 * intNum2);
                    break;
            }


            Console.ReadLine();
        }
    }
}
