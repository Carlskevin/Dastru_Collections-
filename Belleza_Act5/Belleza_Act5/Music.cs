using Belleza_Act5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Act5
{
    internal class Music
    {

        // Music Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        // Parameterized Constructor
        public Music(string name, string genre, string title)
        {
            Name = name;
            Genre = genre;
            Title = title;
        }

        // Virtual Method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Genre : {Genre}");
            Console.WriteLine($"Title : {Title}");
        }

        // USER INPUT METHOD 
        public static Music UserInput()
        {
            Console.Write("Enter music type (Pop/Rock): ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter artist/band name: ");
            string name = Console.ReadLine();

            Console.Write("Enter song title: ");
            string title = Console.ReadLine();

            if (type == "pop")
            {
                return new PopMusic(name, title);
            }
            else if (type == "rock")
            {
                return new RockMusic(name, title);
            }
            else
            {
                Console.WriteLine("Invalid type. Defaulting to Pop music.");
                return new PopMusic(name, title);
            }
        }
    }

    // DERIVED CLASS
    class PopMusic : Music
    {
        public string Artist { get; set; }

        public PopMusic(string artist, string title)
            : base(artist, "Pop", title)
        {
            Artist = artist;
        }

        public override void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("POP MUSIC");
            Console.ResetColor();
            Console.WriteLine($"Artist: {Artist}");
            base.DisplayInfo();
        }
    }

   
    class RockMusic : Music
    {
        public string Band { get; set; }

        public RockMusic(string band, string title)
            : base(band, "Rock", title)
        {
            Band = band;
        }

        public override void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ROCK MUSIC");
            Console.ResetColor();
            Console.WriteLine($"Band: {Band}");
            base.DisplayInfo();
        }
    }
}
