using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{

    const string NORTH = "N";
    const string SOUTH = "S";
    const string WEST = "W";
    const string EAST = "E";
    
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            
             string directionX = "";
             string directionY = "";
            
            if (initialTx > lightX)
            {
                directionX = WEST;
                initialTx--;
            }
            else if (initialTx < lightX)
            {
                directionX = EAST;
                initialTx++;
            }
            if (initialTy > lightY)
            {
                directionY = NORTH;
                initialTy--;
            }
            else if (initialTy < lightY)
            {
                directionY = SOUTH;
                initialTy++;
            }

            Console.WriteLine($"{directionY}{directionX}");
        }
    }
}