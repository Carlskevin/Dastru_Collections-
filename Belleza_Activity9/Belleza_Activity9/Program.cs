using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Activity9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stack = new int[5];  
            int top = -1;               
            int choice = 0;

            do
            {
                Console.WriteLine("\n--- STACK MENU ---");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: 
                            if (top == stack.Length - 1)
                            {
                                Console.WriteLine("Stack Overflow! Stack is full.");
                            }
                            else
                            {
                                Console.Write("Enter number: ");
                                int value = Convert.ToInt32(Console.ReadLine());
                                top++;
                                stack[top] = value;
                                Console.WriteLine("Item pushed successfully.");
                            }
                            break;

                        case 2:
                            if (top == -1)
                            {
                                Console.WriteLine("Stack Underflow! Stack is empty.");
                            }
                            else
                            {
                                Console.WriteLine("Popped item: " + stack[top]);
                                top--;
                            }
                            break;

                        case 3: 
                            if (top == -1)
                            {
                                Console.WriteLine("Stack is empty.");
                            }
                            else
                            {
                                Console.WriteLine("Top item: " + stack[top]);
                            }
                            break;

                        case 4: 
                            if (top == -1)
                            {
                                Console.WriteLine("Stack is empty.");
                            }
                            else
                            {
                                Console.WriteLine("Stack elements:");
                                for (int i = top; i >= 0; i--)
                                {
                                    Console.WriteLine(stack[i]);
                                }
                            }
                            break;

                        case 5:
                            Console.WriteLine("Program Ended. Thank you for using.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter numbers only.");
                }

            } while (choice != 5);
        }
    }
}