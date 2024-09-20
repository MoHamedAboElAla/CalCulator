using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculation
    {
        public  void Calculate(List<double> numbers)
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator: +, -, *, or /");
            string op = Console.ReadLine();

            double result = numbers[0];

            // Use a loop to do the math.
            for (int i = 1; i < numbers.Count; i++)
            {
                switch (op)
                {
                    case "+":
                        result += numbers[i];
                        break;
                    case "-":
                        result -= numbers[i];
                        break;
                    case "*":
                        result *= numbers[i];
                        break;
                    case "/":
                        result /= numbers[i];
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        return;
                }
            }

            // Print the result.
            Console.WriteLine($"Your result: {result}");
            Console.WriteLine("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
