using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Acivity8
{
    internal class MusicList
    {
        private LinkedList<Music> musics = new LinkedList<Music>();

        public void Insert()
        {
            Music m = MusicInput.GetMusic();
            musics.AddLast(m);
            Console.WriteLine("\nMusic added successfully!\n");
        }

        public void Remove()
        {
            if (musics.Count == 0)
            {
                Console.WriteLine("\nList is empty!\n");
                return;
            }

            musics.RemoveFirst();
            Console.WriteLine("\nFirst music removed!\n");
        }

        public void Display()
        {
            if (musics.Count == 0)
            {
                Console.WriteLine("\nNo music to display.\n");
                return;
            }

            Console.WriteLine("=== MUSIC LIST ===\n");
            foreach (Music m in musics)
            {
                m.DisplayInfo();
                Console.WriteLine();

            }
        }
    }
}