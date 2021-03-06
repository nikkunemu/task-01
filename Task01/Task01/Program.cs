using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                string numberString1, numberString2, operatorString;
                int numberInt1, numberInt2, result;

                numberString1 = EnterFirstNumber();
                numberString2 = EnterSecondNumber();
                operatorString = EnterOperator();

                numberInt1 = ConvertStringToInt(numberString1);
                numberInt2 = ConvertStringToInt(numberString2);

                result = Calculate(numberInt1, numberInt2, operatorString);
                GetResultFormat(operatorString, numberInt1, numberInt2, result);

                Console.Write("Please type exit to leave program, or any key to continue: ");
                value = Console.ReadLine();

            } while (value != "exit");
        }

        public static string EnterFirstNumber()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            string value = Console.ReadLine();
            return value;
        }
        public static string EnterSecondNumber()
        {
            Console.Write("Enter second number: ");
            string value = Console.ReadLine();
            return value;
        }
        public static string EnterOperator()
        {
            Console.Write("Enter operator: ");
            string value = Console.ReadLine();
            return value;
        }
   
        public static int ConvertStringToInt(string value)
        {
            switch (value)
            {
                case "zero":
                    return 0;
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                    Console.WriteLine("Invalid number. Please retry.");
                    return 0;
            }
        }
        public static int ConvertStringToOperator(int left, int right, Operator value)
        {

            try
            {
                if (value == Operator.Divide) if (right == 0)
                    throw new DivideByZeroException("Division by zero is not allowed");
                switch (value)
                {
                    case Operator.Plus:
                        return left + right;

                    case Operator.Minus:
                        return left - right;

                    case Operator.Multiply:
                        return left * right;

                    case Operator.Divide:
                        return left / right;

                    default:
                        return 0;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        public static int Calculate(int left, int right, string value)
        {
                switch (value)
                {
                    case "+":
                        return ConvertStringToOperator(left, right, Operator.Plus);
                    case "-":
                        return ConvertStringToOperator(left, right, Operator.Minus);
                    case "*":
                        return ConvertStringToOperator(left, right, Operator.Multiply);
                    case "/":
                        return ConvertStringToOperator(left, right, Operator.Divide);
                    default:
                        Console.WriteLine("Invalid operator. Please retry.");
                        return 0;
                }
        }
        public static void GetResultFormat(string value, int left, int right, int result)
        {
            switch (value)
            {
                case "-":
                    Console.WriteLine("Result: {0} - {1} = {2}", left, right, result);
                    break;
                case "+":
                    Console.WriteLine("Result: {0} + {1} = {2}", left, right, result);
                    break;
                case "*":
                    Console.WriteLine("Result: {0} * {1} = {2}", left, right, result);
                    break;
                case "/":
                    Console.WriteLine("Result: {0} / {1} = {2}", left, right, result);
                    break;
                default:
                    break;
            }
        }
        public enum Operator
        {
            Plus, Minus, Multiply, Divide
        }
    }
}
