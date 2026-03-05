using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belleza_Activity10
{
    internal class Queue
    {

        // Create an array to store queue elements
        private int[] queue = new int[5];
        private int front = -1;
        private int rear = -1;

        // Method to add an item to the queue
        public void Enqueue(int value)
        {
            if (rear == queue.Length - 1)
            {
                Console.WriteLine("Queue Overflow! Queue is full.");
            }
            else
            {
                if (front == -1)
                    front = 0;

                rear++;
                queue[rear] = value;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nItem inserted successfully.");
                Console.ResetColor();

            }
        }

        // Method to remove an item from the queue
        public void Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow! Queue is empty.");
            }
            else
            {
                Console.WriteLine("Removed item: " + queue[front]);
                front++;
            }
        }

        // Method to check the front item
        public void Peek()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Console.WriteLine("Front item: " + queue[front]);
            }
        }

        //Method to display all queue elements
        public void Display()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                Console.WriteLine("Queue elements:");
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(queue[i]);
                }
            }

        }
    }
}