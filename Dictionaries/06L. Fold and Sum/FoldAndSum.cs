using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = numbers.Length / 4;

        int[] leftDigits = numbers.Take(k)
            .Reverse()
            .ToArray();

        int[] rightDigits = numbers.Reverse()
            .Take(k).
            ToArray();

        int[] firstRow = leftDigits.Concat(rightDigits).ToArray();
        int[] secondRow = numbers.Skip(k)
            .Take(2 * k)
            .ToArray();

        List<int> result = firstRow
            .Zip(secondRow, ((x, y) => x + y))
            .ToList();

        //for (int i = 0; i < firstRow.Length; i++)
        //{
        //    result.Add(firstRow[i] + secondRow[i]);
        //}  
            

        Console.WriteLine(string.Join(" ", result));

    }
}

