using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        string filePath = "D:\\Lab4OOP.txt";

        char[] characters = File.ReadAllText(filePath).ToCharArray();

        int arrayCount = CountPunctuationArray(characters);

        Console.WriteLine($"Кількість знаків пунктуації в файлі (масив): "+ arrayCount);

        List<char> characterList = characters.ToList();

        int listCount = CountPunctuationList(characterList);

        Console.WriteLine($"Кількість знаків пунктуації в файлі (список): "+ listCount);
    }

    static int CountPunctuationArray(char[] characters)
    {
        int count = 0;

        foreach (char character in characters)
        {
            if (char.IsPunctuation(character))
            {
                count++;
            }
        }

        return count;
    }

    static int CountPunctuationList(List<char> characters)
    {
        int count = 0;

        foreach (char character in characters)
        {
            if (char.IsPunctuation(character))
            {
                count++;
            }
        }

        return count;
    }
}