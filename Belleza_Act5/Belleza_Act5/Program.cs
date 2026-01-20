using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Act5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Carls Kevin Belleza    
            //ACTIVITY 5: Customize a User - Input Method

            // Create 2D Array of Music
            Music[,] musics = new Music[2, 2];

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== ENTER MUSIC DETAILS ===\n");
            Console.ResetColor();

            // User input
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Music [{i},{j}]");
                    musics[i, j] = Music.UserInput();
                    Console.WriteLine();
                }
            }

            // Display music information
            Console.WriteLine("=== MUSIC INFORMATION ===\n");
           

            foreach (Music music in musics)
            {
                music.DisplayInfo();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
