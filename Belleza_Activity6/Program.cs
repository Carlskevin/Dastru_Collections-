using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Activity6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Carls Kevin Belleza    
            // 1/22/26      
            //Section: IT402P
            //Activity: Inserting Nodes to the Linked List (Procedural Approach)

            LinkedList<string> list = new LinkedList<string>();

            //allow user to enter number of nodes 
            Console.WriteLine("Enter a number names the range of 5 to 10.");
            int number = int.Parse(Console.ReadLine());

           
            if (number < 5 || number > 10)
            {
                Console.WriteLine("Please enter a number within the range");
                return;
            }

            //input names of friends 
            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                list.AddFirst(name);
            }
            // Display linked list
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n(~~~ My Friends Names~~~)");
            Console.ResetColor();
            foreach (string name in list)

            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
