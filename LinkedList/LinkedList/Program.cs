using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List !!");
            Console.WriteLine("\n");
            LinkList list = new LinkList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
        }
    }
}
