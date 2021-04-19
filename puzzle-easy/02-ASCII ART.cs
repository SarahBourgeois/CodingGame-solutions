using System;
using System.Collections.Generic;

class Solution
{

// ROW input : 
/*#  ##   ## ##  ### ###  ## # # ###  ## # # #   # # ###  #  ##   #  ##   ## ### # # # # # # # # # # ### ### 
# # # # #   # # #   #   #   # #  #    # # # #   ### # # # # # # # # # # #    #  # # # # # # # # # #   #   # 
### ##  #   # # ##  ##  # # ###  #    # ##  #   ### # # # # ##  # # ##   #   #  # # # # ###  #   #   #   ## 
# # # # #   # # #   #   # # # #  #  # # # # #   # # # # # # #    ## # #   #  #  # # # # ### # #  #  #       
# # ##   ## ##  ### #    ## # # ###  #  # # ### # # # #  #  #     # # # ##   #  ###  #  # # # #  #  ###  #   */

    static void Main(string[] args)
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        List<char> alphaList = new List<char>();
        alphaList.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        string T = Console.ReadLine().ToUpper();

        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            string result = null;

            foreach (char c in T)
            {
                var index = alphaList.IndexOf(c);
                result += Char.IsLetter(c) ? ROW.Substring(L * index, L) : ROW.Substring(L * 26, L);
            }

            Console.WriteLine(result);
        }
    }
}