using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.

        Dictionary<string, string> dico = new Dictionary<string, string>();
        string extensionFileToCheck = null;

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string extension = inputs[0]; 
            string mimeType = inputs[1]; 

            dico.Add(extension.ToLower(), mimeType);
        }
        
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.

            if (FNAME.Contains('.'))
                extensionFileToCheck = FNAME.Split('.').Last();
            else
                extensionFileToCheck = "";

            bool keyExists = dico.TryGetValue(extensionFileToCheck.ToLower(), out string value);
            if (!keyExists)
                Console.WriteLine("UNKNOWN");
            else
                Console.WriteLine(value);
        }
    }
}