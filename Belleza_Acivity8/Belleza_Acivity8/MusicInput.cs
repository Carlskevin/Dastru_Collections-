using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Acivity8
{
    internal class MusicInput
    {
        public static Music GetMusic()
        {
            try
            {
                Console.Write("Enter music type (Pop/Rock): ");
                string type = Console.ReadLine().ToLower();

                Console.Write("Enter artist/band name: ");
                string name = Console.ReadLine();

                Console.Write("Enter song title: ");
                string title = Console.ReadLine();

                if (type == "pop")
                    return new PopMusic(name, title);
                else if (type == "rock")
                    return new RockMusic(name, title);
                else
                    throw new Exception("Invalid music type!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Defaulting to Pop music.\n");
                return new PopMusic("Unknown", "Untitled");
            }
        }
    }
}