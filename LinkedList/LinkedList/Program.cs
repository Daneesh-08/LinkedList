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
            list.Insert(2,30);
            list.Display();
            _ = list.PopLast();
            Console.WriteLine("After deleting last element of Sequence : ");
            list.Display();
        }
    }
}
