using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkList
    {
        internal Node head;
        public LinkList()
        {
            this.head = null;
        }
        internal void Add(int item)
        {
            Node node = new Node(item);
            if (this.head == null)
                this.head = node;
            else
            {
                node.next = head;
                head = node;
            }
        }
        internal void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        internal void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Oops ! Wrong Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;               
                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;                
            }
        }
        internal Node Pop()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        internal void Display()
        {
            if (head == null)
            {
                System.Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                        Console.Write("-> ");
                    temp = temp.next;
                }
            }
            Console.WriteLine("\n");
        }
    }
}
