using System;

namespace SW1
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- PART 1: Prime or Composite ---
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();
            int count = 1;
            foreach (string numStr in numbers)
            {
                if (int.TryParse(numStr, out int num))
                {
                    string result = IsPrime(num) ? "Prime" : "Composite";
                    Console.WriteLine($"{count}. {num,5} \t{result}");
                    count++;
                }
            }

            // --- PART 2: Currency Conversion ---
            Console.Write("\nEnter currency in ($): ");
            string dollarInput = Console.ReadLine();

            if (double.TryParse(dollarInput.Replace(",", ""), out double dollarAmount))
            {
                ConvertCurrency(dollarAmount, out double peso, out double yen);

                Console.WriteLine("\nDollar($)");
                Console.WriteLine($"{dollarAmount:N2}\n");

                Console.WriteLine("Phil Peso(P)");
                Console.WriteLine($"{peso:N2}\n");

                Console.WriteLine("Jpn Yen (Y)");
                Console.WriteLine($"{yen:N2}\n");

            }
            else
            {
                Console.WriteLine("Invalid currency input.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // --- Method to check if a number is Prime ---
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // --- Method to convert currency (USD to PHP and JPY) ---
        static void ConvertCurrency(double dollars, out double peso, out double yen)
        {
            const double pesoRate = 57.17;
            const double yenRate = 146.67;

            peso = dollars * pesoRate;
            yen = dollars * yenRate;
        }
    }
}
