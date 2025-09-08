using System;

namespace Homework1
{
    class MatrixSummary
    {
        static void Main()
        {
            int rows = 0, cols = 0;

            while (true)
            {
                Console.Write("Enter number of rows: ");
                if (int.TryParse(Console.ReadLine(), out rows) && rows > 0)
                    break;
                Console.WriteLine("Please enter a valid positive integer.");
            }

            while (true)
            {
                Console.Write("Enter number of columns: ");
                if (int.TryParse(Console.ReadLine(), out cols) && cols > 0)
                    break;
                Console.WriteLine("Please enter a valid positive integer.");
            }

            int[,] matrix = new int[rows, cols];
            int sum = 0;
            int totalElements = rows * cols;

            Console.WriteLine("\nEnter the numbers:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    while (true)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        if (int.TryParse(Console.ReadLine(), out matrix[i, j]))
                        {
                            sum += matrix[i, j];
                            break;
                        }
                        Console.WriteLine("Invalid input. Please enter an integer.");
                    }
                }
            }

            Console.WriteLine("\nList of all elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(); 
            }

            double average = (double)sum / totalElements;

            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Average: {average:F2}");

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
