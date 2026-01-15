using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 2D Array Music
            Music[,] musics = new Music[2,2];

            //Row 2 
            musics[0,0] = new PopMusic("Taylor Swift", "Blank Space");
            musics[0,1] = new RockMusic("Linkin Park", "Numb");

            //Row 1 
            musics[1, 0] = new PopMusic("EXB", "Hayaan mo Sila");
            musics[1, 1] = new RockMusic("Bamboo", "Noypi");

            // Display music information
            foreach (Music music in musics)
            {
                music.DisplayInfo();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
