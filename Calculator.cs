using System;

namespace Homework01
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi skaitli x: ");
            string skaitlis1 = Console.ReadLine().Replace(",", ".");
            double x = Convert.ToDouble(skaitlis1);

            Console.Write("Ievadi skaitli y: ");
            string skaitlis2 = Console.ReadLine().Replace(",", ".");
            double y = Convert.ToDouble(skaitlis2);

            Console.Write("Ievadi aritmētisko operāciju (+, -, / vai *): ");
            string z = Console.ReadLine().Trim();

            switch (z)
            {
                case "+":
                    Console.WriteLine(x + " " + z + " " + y + " = " + Utils.Plus(x, y));
                    break;

                case "-":
                    Console.WriteLine(x + " " + z + " " + y + " = " + Utils.Minus(x, y)); 
                    break;

                case "/":
                    Console.WriteLine(x + " " + z + " " + y + " = " + Utils.Divide(x, y)); 
                    break;

                case "*":
                    Console.WriteLine(x + " " + z + " " + y + " = " + Utils.Multiply(x, y)); 
                    break;

                default:
                    Console.WriteLine("Kļūda aritmētiskās operācijas ievadē!"); 
                    break;

            }

        }
    }
}
