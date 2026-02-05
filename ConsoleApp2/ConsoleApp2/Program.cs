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
            string correctName = "okay";
            string correctPassword = "123";
            

            while (true)
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your password:");
                string password = Console.ReadLine();

                if (name == correctName && password == correctPassword)
                {
                    Console.WriteLine("Welcome to the program!");
                    break;
                   
                }
                else
                {
                    Console.WriteLine("Invalid credentials. Please try again.");
                }
            }
            Console.ReadKey();
        }
    }
}
