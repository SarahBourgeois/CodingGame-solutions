using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

internal class Solution
{
    private static void Main(string[] args)
    {
        List<string> Re = new List<string>();
        string S = "";
        string M = Console.ReadLine(); 
        string Bin = ToBinary(ConvertToByteArray(M, Encoding.ASCII));
        char[] BA = Bin.ToCharArray();
        char C = ' ';

        foreach (char c in Bin)
        {
            if (c != C)
            {
                if (S != "")
                {
                    Re.Add(S);
                    S = "";
                }
                C = c;
            }
            S += C;
        }
        if (S != "")
            Re.Add(S);
            
        string RS = ""; string T;
        for (int i = 0; i < Re.Count; i++)
        {
            T = new string('0', Re[i].Length);
            RS += Re[i].StartsWith("1") ? String.Format(" {0} {1}", "0", T) : String.Format(" {0} {1}", "00", T);
        }
        Console.WriteLine(RS.TrimStart());
    }
    public static byte[] ConvertToByteArray(string str, Encoding encoding) => encoding.GetBytes(str);
    public static string ToBinary(byte[] data) => string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(7, '0')));
}