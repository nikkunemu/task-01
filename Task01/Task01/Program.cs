using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();

            bool menu = true;
            while (menu == true)
            {
                p.MainMenu();
                p.SwitchOP(p.number1);
                p.SwitchOP1(p.number2);
                p.operat(p.oper);
                Console.ReadLine();
            }
        }
        public bool MainMenu()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            number1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            number2 = Console.ReadLine();

            Console.Write("Enter operator: ");
            oper = Console.ReadLine();

            return true;
        }

        public string number1 { get; set; }
        public string number2 { get; set; }
        public int intNum1 { get; set; }
        public int intNum2 { get; set; }
        public string oper { get; set; }

        public enum Operator
        {
            plus, minus, multiply, divide
        }
        public void SwitchOP(string str)
        {
            switch (str)
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
                default:
                    Console.WriteLine("Invalid first number. Please retry.");
                    return;
            }
        }
        public void SwitchOP1(string str)
        {
            switch (str)
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
                default:
                    Console.WriteLine("Invalid second number. Please retry.");
                    return;
            }
        }
        public int Calculate(int left, int right, Operator op)
        {
            switch (op)
            {
                case Operator.plus:
                    return left + right;

                case Operator.minus:
                    return left - right;

                case Operator.multiply:
                    return left * right;

                case Operator.divide:
                    return left / right;

                default:
                    return 0;
            }
        }
        public void operat(string str)
        {
            switch (str)
            {
                case "+":
                    Console.WriteLine("Result: {0} + {1} = {2}", 
                        intNum1, intNum2, Calculate(intNum1, intNum2, Operator.plus));
                    break;
                case "-":
                    Console.WriteLine("Result: {0} - {1} = {2}",
                        intNum1, intNum2, Calculate(intNum1, intNum2, Operator.minus));
                    break;
                case "*":
                    Console.WriteLine("Result: {0} * {1} = {2}",
                        intNum1, intNum2, Calculate(intNum1, intNum2, Operator.multiply));
                    break;
                case "/":
                    Console.WriteLine("Result: {0} / {1} = {2}",
                        intNum1, intNum2, Calculate(intNum1, intNum2, Operator.divide));
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please retry.");
                    break;
            }
        }
    }
}
