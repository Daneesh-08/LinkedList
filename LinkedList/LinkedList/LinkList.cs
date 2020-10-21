﻿using System;
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
