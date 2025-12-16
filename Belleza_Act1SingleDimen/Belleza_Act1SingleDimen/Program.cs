using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Act1SingleDimen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare Array
            string[] Music = new string[5];


            Console.ForegroundColor = ConsoleColor.Green;    
            //Accept user input
            Console.WriteLine("Enter your top 5 favorite music: \n");
            for (int idx = 0; idx < Music.Length; idx++)
            {
                Music[idx]=Console.ReadLine();
            }
            Array.Sort(Music);  
            //Display the array elements 
            Console.WriteLine("\n ======= Your Top 5 Music in Ascending Order =======");
            foreach (string music in Music)
            {
                Console.WriteLine(music);
            }

            Console.ReadKey();
        }
    }
}
