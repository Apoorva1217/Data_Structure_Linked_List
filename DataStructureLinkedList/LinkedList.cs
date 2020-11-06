using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    public class LinkedList<T>
    {
        internal Node head;

        /// <summary>
        /// UC 2 Ability to create Linked List by adding 30 and 56 to 70
        /// </summary>
        /// <param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }

        /// <summary>
        /// Display method to print linked list
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
