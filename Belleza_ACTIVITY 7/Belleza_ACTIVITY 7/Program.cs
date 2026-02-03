using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_ACTIVITY_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Name: Carls Kevin Belleza
                // Date: 2/3/26
                // Section: IT402P
                // Activity: Linked List with Exception Handling and Sorting (Procedural)
        
                LinkedList<string> list = new LinkedList<string>();
                int number;

                // Exception handling for number of names
                try
                {
                    Console.WriteLine("Enter number of names (range 5 to 10): ");
                    number = int.Parse(Console.ReadLine());

                    if (number < 5 || number > 10)
                    {
                        Console.WriteLine("Please enter a number within the range of 5 to 10.");
                        Console.ReadKey(); return;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ReadKey(); return;
                }

                // User inputs names (no preloaded data)
                for (int i = 0; i < number; i++)
                {
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    list.AddFirst(name);
                }

                // Display all elements from linked list
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n(~~~ Linked List Names ~~~)");
                Console.ResetColor();

                foreach (string name in list)
                {
                    Console.WriteLine(name);
                }

                // Sort elements via array
                string[] namesArray = new string[list.Count];
                list.CopyTo(namesArray, 0);
                Array.Sort(namesArray);

                // Display sorted elements
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n(~~~ Sorted Linked List Names ~~~)");
                Console.ResetColor();

                foreach (string name in namesArray)
                {
                    Console.WriteLine(name);
                }

                Console.ReadKey();
            }
        }
    }
}
