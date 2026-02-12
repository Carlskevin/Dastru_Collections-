using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Acivity8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Carls Kevin Belleza                      
            //ACTIVITY 8:  Linked List in OOP

            MusicList list = new MusicList();
            int choice;
            do
            {
                Console.WriteLine("=== MUSIC SYSTEM ===");
                Console.WriteLine("1. Insert Music");
                Console.WriteLine("2. Remove Music");
                Console.WriteLine("3. Display Music");
                Console.WriteLine("4. Exit");
                Console.Write("\n Choose: ");
                
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        list.Insert();
                        break;
                    case 2:
                        list.Remove();
                        break;
                    case 3:
                        list.Display();
                        break;
                }

            } while (choice != 4);
            Console.ReadKey();

        }
    }
}
