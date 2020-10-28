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
            list.Append(56);
            list.Append(70);
            list.Insert(2, 30);
            list.Display();
            if (list.Search(30))
            {
                list.Insert(3, 40);
                list.Display();
            }
            else
                Console.WriteLine("Node not Found !!");
        }
    }
}