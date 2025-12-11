using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRRAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;  
            Console.WriteLine("Coach List: ");
            Console.ResetColor();

            string[] CoachNames = {"\nLoon", "Okay", "Cuyos", "Salvo", "Rodrigo" };
            Array.Sort(CoachNames);

            foreach (string Coachnames in CoachNames)
            {
                Console.WriteLine(Coachnames);
            }
            Console.ReadLine();
        }
    }
}
