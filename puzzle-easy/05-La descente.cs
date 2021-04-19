using System;

class Player
{
    static void Main(string[] args)
    {
     

        // game loop
        while (true)
        {
           int mountainValue = 0;
           int index = 0;
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                 if(mountainH > mountainValue) {
                     mountainValue = mountainH;
                     index = i;
                 }
            }
            Console.WriteLine(index); 
        }
    }
}