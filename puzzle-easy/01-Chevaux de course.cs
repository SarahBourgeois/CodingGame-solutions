using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int old = 0; 
        int diff = 100000;
        List<int> list = new List<int>();

        for (int i = 0; i < N; i++)
            list.Add(int.Parse(Console.ReadLine()));
       
        list.Sort();

        foreach (int currentNumber in list)
        {
            if (currentNumber == list.ElementAt(0))
                old = currentNumber;
            else
            {
                var soustraction = currentNumber - old;
                if (Math.Abs(soustraction) < Math.Abs(diff))
                    diff = Math.Abs(soustraction);

                old = currentNumber;
            }
        }
        Console.WriteLine(diff);
    }
}