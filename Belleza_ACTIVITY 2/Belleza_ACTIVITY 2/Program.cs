using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_ACTIVITY_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Music[] musics = new Music[4];

            //  Array of Music objects 
            Music[] musicList = new Music[2];

            musicList[0] = new PopMusic("Taylor Swift", "Blank Space");
            musicList[1] = new RockMusic("Linkin Park", "Numb");

            // Display music information
            foreach (Music music in musicList)
            {
                music.DisplayInfo();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
