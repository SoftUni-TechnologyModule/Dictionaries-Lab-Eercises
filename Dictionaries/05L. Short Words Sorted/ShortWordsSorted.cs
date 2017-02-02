using System;
using System.Collections.Generic;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        List<string> textLine = Console.ReadLine()
            .ToLower()
            .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?' }
            , StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> result = textLine.Distinct()
            .Where(w => w.Length < 5)
            .OrderBy(x => x).ToList();

        Console.WriteLine(string.Join(", ", result));
    }
}

