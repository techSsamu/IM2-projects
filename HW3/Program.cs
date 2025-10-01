using System;
using System.Collections.Generic;

class Program
{
    
    static Dictionary<char, int> GetCharFrequency(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in input)
        {
            
            if (char.IsLetter(c))
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }
        }

        return frequency;
    }

    static void Main()
    {
        Console.Write("Enter string(s) separated by commas: ");
        string userInput = Console.ReadLine();

        
        string[] parts = userInput.Split(',');

        foreach (string raw in parts)
        {
            string word = raw.Trim(); 
            var freq = GetCharFrequency(word);

            Console.WriteLine($"\nInput: {word}");
            foreach (var kvp in freq)
            {
                Console.Write($"{kvp.Key}={kvp.Value}, ");
            }
            Console.WriteLine(); 
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
