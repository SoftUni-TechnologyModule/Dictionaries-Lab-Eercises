using System;
using System.Collections.Generic;

class OddOccurrences
{
    static void Main(string[] args)
    {
        var textLine = Console.ReadLine().ToLower().Split(' ');

        var words = new Dictionary<string, int>();

        foreach (var word in textLine)
        {
            if (!words.ContainsKey(word))
            {
                words[word] = 0;
            }

            words[word]++;
        }

        var result = new List<string>();

        foreach (var word in words)
        {
            if (word.Value % 2 != 0)
            {
                result.Add(word.Key);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }
}

