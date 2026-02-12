using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Acivity8
{
            class Music
        {
        //Properties Common to all music types  
            public string Name { get; set; }
            public string Genre { get; set; }
            public string Title { get; set; }

            public Music(string name, string genre, string title)
            {
                Name = name;
                Genre = genre;
                Title = title;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Genre : {Genre}");
                Console.WriteLine($"Title : {Title}");
            }
        }

        // Derived Class - Pop
        class PopMusic : Music
        {
            public PopMusic(string artist, string title)
                : base(artist, "Pop", title) { }

            public override void DisplayInfo()
            {
                Console.WriteLine("=== POP MUSIC ===");
                Console.WriteLine($"Artist: {Name}");
                base.DisplayInfo();
            }
        }

        // Derived Class - Rock
        class RockMusic : Music
        {
            public RockMusic(string band, string title)
                : base(band, "Rock", title) { }

            public override void DisplayInfo()
            {
                Console.WriteLine("=== ROCK MUSIC ===");
                Console.WriteLine($"Band: {Name}");
                base.DisplayInfo();
            }
        }
    }
