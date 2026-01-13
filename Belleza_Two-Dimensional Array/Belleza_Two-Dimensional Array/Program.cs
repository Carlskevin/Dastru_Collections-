using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Two_Dimensional_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Songs = new string[3, 3]
        {
            { "Love Yourself", "Cool Down", "This Town" },
            { "Tonight", "This Time", "Hayaan Mo Sila" },
            { "Marilag", "Lord Patawad", "Buko" }
        };

            Console.WriteLine("----- Random Song List -----");
            Console.WriteLine("\nSongs1\t        \tSongs2\t        \tSongs3");
           

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(Songs[row, col] + "\t\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
