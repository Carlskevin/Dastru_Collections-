using Belleza_ACTIVITY_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_ACTIVITY_2
{
    internal class Music
    {
        // Music Properties 
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        //Parameterized Constructor
        public Music(string name, string genre, string title)
        {
            Name = name;
            Genre = genre;
            Title = title;
        }
        public virtual void DisplayInfo() //Virtual method      
        {
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Title : {Title}");
        }

        }
    }
        // Derived Class 1
        class PopMusic : Music
        {
            public string Artist { get; set; }   // get/set property

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
                    Console.WriteLine($"\nArtist: {Artist}");
                    base.DisplayInfo();
                }
                    }
                // Derived Class 2
                class RockMusic : Music
                {
                    public string Band { get; set; }    // get/set property

                    public RockMusic(string band, string title)
                        : base(band, "Rock", title)
                    {
                        Band = band;
                    }

                    public override void DisplayInfo()
                    {
                        Console.ForegroundColor= ConsoleColor.Green;
                        Console.WriteLine("ROCK MUSIC");
                        Console.ResetColor();
                        Console.WriteLine($"\nBand: {Band}");
                        base.DisplayInfo();
                    }

                }
