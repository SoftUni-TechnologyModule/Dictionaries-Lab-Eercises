using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        var result = new SortedDictionary<double, int>();

        foreach (var num in numbers)
        {
            if (!result.ContainsKey(num))
            {
                result[num] = 0;
            }

            result[num]++;
        }

        foreach (var pairs in result)
        {
            Console.WriteLine($"{pairs.Key} -> {pairs.Value}");
        }
    }
}