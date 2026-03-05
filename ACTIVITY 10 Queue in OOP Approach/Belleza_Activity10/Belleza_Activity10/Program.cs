using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Activity10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of QueueClass
            Queue q = new Queue ();
            int choice = 0;

            // Loop for the menu until user chooses Exit
            do
            {
                // Display menu
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n--- QUEUE MENU ---");
                Console.ResetColor();
                Console.WriteLine("\n1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nEnter choice: ");
                Console.ResetColor();

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        
                        // Ask user for a number to insert in queue
                        case 1:
                            Console.Write("Enter number: ");
                            int value = Convert.ToInt32(Console.ReadLine());
                            q.Enqueue(value);
                            break;

                            // Call dequeue method to remove item
                        case 2:
                            q.Dequeue();
                            break;
                        
                            // Call peek method to see the front item
                        case 3:
                            q.Peek();
                            break;
                        
                            // Call display method to show queue items
                        case 4:
                            q.Display();
                            break;
                           
                        case 5:
                            Console.WriteLine("\nProgram Ended.");
                            break;

                        // If the user enters an invalid menu number
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // Handle error if user enters letters instead of numbers
                    Console.WriteLine("Invalid input! Please enter numbers only.");
                }

            } while (choice != 5);

        }
    }
}
