//OOP only!!

using System;

namespace ConsoleApp1
{
    class Program
    {
        static decimal plus(decimal a, decimal b)
        {
            return a + b;
        }
        static decimal mult(decimal a, decimal b)
        {
            return a * b;
        }
        static void calc()
        {
            char operation = 'w';
            decimal n1 = 0;
            decimal n2 = 0;
            do{ 
            Console.WriteLine("[i]. Input numbers");
            Console.WriteLine("[+]. Plus numbers");
            Console.WriteLine("[*]. Mult numbers");
            Console.WriteLine("[q]. Quit");
            Console.WriteLine("Enter operation: ");
            operation = char.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 'i':
                    case 'I':
                        try
                        {
                            Console.WriteLine("Enter first number: ");
                            n1 = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("Enter second number: ");
                            n2 = decimal.Parse(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case '+':
                        Console.WriteLine($"{n1}+{n2}={plus(n1, n2)}"); //інтерполяційний рядок
                        break; //return, goto
                    case '*':
                        Console.WriteLine("{0}*{1}={2}", n1, n2, mult(n1, n2));
                        break;
                    default:
                        Console.WriteLine("Error choose!!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (char.ToLower(operation)!= 'q');

        }
        static void Main()
        {
            calc();
        }
    }
}
