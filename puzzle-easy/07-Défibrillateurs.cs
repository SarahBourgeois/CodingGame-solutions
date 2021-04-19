using System;

class Solution
{
    static void Main(string[] args)
    {
        string LON = Console.ReadLine(); // longitude en degrés de l'utilisateur
        string LAT = Console.ReadLine(); // latitude en degrés de l'utilisateur
        int N = int.Parse(Console.ReadLine()); // le nombre de defibrilateurs

        double.TryParse(LON.Replace(',', '.'), out double userLon);
        double.TryParse(LAT.Replace(',', '.'), out double userLat);

        double oldDist = 100000;
        string result = null;


        for (int i = 0; i < N; i++)
        {
            string DEFIB = Console.ReadLine(); // description du defibrilateur

            // name of defib 
            var removerName = DEFIB.Remove(0, DEFIB.IndexOf(';') + 1);
            var nameOfDefib = removerName.Substring(0, removerName.IndexOf(';'));

            // coordinates
            int index = DEFIB.LastIndexOf(";") - 16;
            string coordinates = null;
            if (index > 0 && DEFIB.Length > 0)
                coordinates = DEFIB.Substring(index, Math.Min(DEFIB.Length, (DEFIB.Length - index)));

            string[] value = coordinates.Split(';');
            double.TryParse(value[0].Replace(',', '.'), out double debLong);
            double.TryParse(value[1].Replace(',', '.'), out double debLat);
            
            // dist calcul between two coordinates
            double rad(double angle) => angle * Math.PI / 180.0d;
            double havf(double diff) => Math.Pow(Math.Sin(rad(diff) / 2d), 2);
            var dist = 12745.6 * Math.Asin(Math.Sqrt(havf(debLat - userLat) + Math.Cos(rad(userLat)) * Math.Cos(rad(debLat)) * havf(debLong - userLon))); // earth radius 6.372,8‬km x 2 = 12745.6

            if (i == 0 || dist <= oldDist)
            {
                oldDist = dist;
                result = nameOfDefib;
            }
        }

        Console.WriteLine(result);
    }
}