namespace LetS_Review;
using System;


internal static class Solution
{
    static void Main()
    {
        UserNumberInput();
    }

    private static void UserNumberInput()
    {
        var input = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(input))
        {
            if (int.TryParse(input, out var number))
            {
                UserStringInput(number);
            }
            else
            {
                Console.WriteLine("this not a number!");
            }
        }
        else
        {
            Console.WriteLine("This is not a valid string inputs!");
        }
    }

    private static void UserStringInput(int number)
    {
        var words = new string[number];
        for (int i = 0; i < number; i++)
        {
            words[i] = Console.ReadLine()!;
            if (string.IsNullOrEmpty(words[i]) && int.TryParse(words[i], out _))
            {
                Console.WriteLine("This is not a valid string inputs!");
                i--;
            }
        }

        Transactions(words);
    }

    private static void Transactions(string[] words)
    {
        foreach (var word in words)
        {
            string evenChars = ""; 
            string oddChars = ""; 

            for (int j = 0; j < word.Length; j++)
            {
                if (j % 2 == 0)
                {
                    evenChars += word[j]; 
                }
                else
                {
                    oddChars += word[j];
                }
            }

            Console.WriteLine($"{evenChars} {oddChars}");
        }
    }
}
