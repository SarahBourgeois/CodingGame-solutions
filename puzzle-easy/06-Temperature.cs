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

        int currentMinTemp = 5526;

        int n = int.Parse(Console.ReadLine()); 
        string[] inputs = Console.ReadLine().Split(' ');

        if (n == 0)
          currentMinTemp = 0;

        for (int i = 0; i < n; i++)
        {
            int temperature = int.Parse(inputs[i]);
            int absTemperature = Math.Abs(temperature);
            int absMinTemp = Math.Abs(currentMinTemp);

            if(absTemperature < absMinTemp)
              currentMinTemp = temperature;

            if(temperature == currentMinTemp || temperature == absMinTemp)
               currentMinTemp = temperature; 
        }

        Console.WriteLine(currentMinTemp);
    }
}