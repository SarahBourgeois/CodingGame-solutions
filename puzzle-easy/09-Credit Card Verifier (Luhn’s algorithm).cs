using System;
using System.Linq;

/* 
Lunh algorithm for card verificator
*/

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string initialInputCard = Console.ReadLine().Replace(" ", "");

            string result = LuhnAlgoVerificator(initialInputCard) ? "YES" : "NO";
           
            Console.WriteLine(result);
        }
    }

    static bool LuhnAlgoVerificator(string initialInputCard)
    {
        string reverseCard = new string(initialInputCard.ToCharArray().Reverse().ToArray());
        string card1 = null, card2 = null;

        for (int i = 0; i < reverseCard.Length; i++)
        {
            int doubleEachDIgit = int.Parse(reverseCard[i].ToString()) * 2;
            var sum = doubleEachDIgit.ToString().Sum(c => c - '0');

            if (i % 2 != 0)
                card1 += $"{sum.ToString().Substring(0, 1)}";
            else
                card2 += $"{reverseCard[i]}";
        }

        int sumNumbersCard = card1.Sum(c => c - '0') + card2.Sum(c => c - '0');

        return sumNumbersCard % 10 == 0;
    }

}