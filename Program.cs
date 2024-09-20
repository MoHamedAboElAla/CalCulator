namespace ConsoleApp1
    {

    public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Console Calculator in C#");
                Console.WriteLine("------------------------\n");

                List<double> numbers = new List<double>();
                string input;
                double number;

               // Ask the user to Write numbers until they Write "done".
                 Console.WriteLine("Write a number, and then press Enter. Write 'done' to finish.");
                 while ((input = Console.ReadLine()) != "done")
                {
                    if (double.TryParse(input, out number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number or 'done' to finish.");
                    }
                }

            Calculation calculate = new Calculation();
            calculate.Calculate(numbers);


        }

    
        }
    }



