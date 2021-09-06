using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w aplikacji kalkulator");
            Console.WriteLine("Wpisz 1. liczbe: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Jaka operacje chcesz wykonac");
            Console.WriteLine(" '+','-', '*', '/'");
            var operation = Console.ReadLine();
            Console.WriteLine("Podaj 2. liczbe");
            var number2 = int.Parse(Console.ReadLine());

            var result = 0;

            switch(operation)
            {
                case "+":
                    result = number1 + number2;
                break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    throw new Exception("zla opcja");
            }
            Console.WriteLine($"Wynik Twojego dzialania to: {result}");
        }
    }
}
