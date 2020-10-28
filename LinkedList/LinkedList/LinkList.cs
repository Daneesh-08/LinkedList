using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkList
    {
        internal Node head;
        public LinkList()
        {
            this.head = null;
        }
        public void Add(int item)
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
        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
            }
        }
        public void Insert(int position, int data)
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
        public bool Search(int item)
        {
            if (head == null)
                return false;
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == item)
                        return true;
                    temp = temp.next;
                }
                return false;
            }
        }
        public void Sort()
        {
            Node temp = head;
            Node firstval = null;
            int val = 0;
            while (temp != null)
            {
                firstval = temp.next;
                while (firstval != null)
                {
                    if (temp.data > firstval.data)
                    {
                        val = firstval.data;
                        firstval.data = temp.data;
                        temp.data = val;
                    }
                    firstval = firstval.next;
                }
                temp = temp.next;
            }
        }
        public int Size()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }
        public void DeleteAnyNode(int position)
        {
            if (head == null)
                return;
            Node temp = head;
            if (position == 0)
            {
                head = temp.next;
                return;
            }
            for (int i = 0;temp != null && i < position - 1;i++)
                temp = temp.next;
            if (temp == null || temp.next == null)
                return;
            Node next = temp.next.next;
            temp.next = next;
        }
        internal Node Pop()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        internal Node PopLast()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
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