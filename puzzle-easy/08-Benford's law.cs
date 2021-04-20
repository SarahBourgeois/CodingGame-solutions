using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            string transaction = Regex.Replace(input, "[^a-zA-Z0-9_]+", "", RegexOptions.Compiled).TrimStart('0');
            list.Add(int.Parse(transaction.Substring(0, 1)));
        }

        list.Sort();
        var allAccountTransactionResult = from data in list
                                          group data by data into groups
                                          select (
                                              groups.Key,
                                              Count: groups.Count(),
                                              Percent: (double)groups.Count() / list.Count * 100
                                          );

        bool isFraud = isBenfordLawApplication(allAccountTransactionResult.Select(c => c.Percent).ToList());

        string result = isFraud ? "true" : "false";

        Console.WriteLine(result);
    }



    static bool isBenfordLawApplication(List<double> accountPercent)
    {
        List<double> benfordLawlist = new List<double> { 30.1, 17.6, 12.5, 9.7, 7.9, 6.7, 5.8, 5.1, 4.6 };
        int count = 0;

        for (int i = 0; i < 9; i++)
        {
            double benfordExcept = benfordLawlist.ElementAt(i);
            double accountResult = accountPercent.ElementAt(i);

            if (accountResult >= (benfordExcept - 10) && accountResult <= (benfordExcept + 10))
                count++;
        }

        return count < 9;
    }
}
