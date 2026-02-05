using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Initialize array
            string[] sports = { "Basketball", "Volleyball", "Tennis" };

            // Pass array to linked list
            LinkedList<string> list = new LinkedList<string>(sports);

            Console.WriteLine("Initial:");
            Display(list);

            // AddFirst 
            list.AddFirst("Soccer");
          

            Console.WriteLine("\nAfter AddFirst: ");
            Display(list);

            // AddBefore 
            var node = list.Find("Volleyball");
            if (node != null)
                list.AddBefore(node, "Swimming");

           
            Console.WriteLine("\nAfter AddBefore: x");
            Display(list);

            // Remove
            list.Remove("Swimming");

            Console.WriteLine("\nAfter Remove:");
            Display(list);

            Console.ReadKey();
        }

        static void Display(LinkedList<string> list)
        {
            foreach (string item in list)
                Console.Write(item + " -> ");
            Console.WriteLine();
        }
    }
        }

   
