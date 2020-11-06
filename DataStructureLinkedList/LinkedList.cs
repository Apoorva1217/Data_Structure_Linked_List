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

        /// <summary>
        /// UC 3 Ability to create Linked List by appending 30 and 70 to 56
        /// </summary>
        /// <param name="data"></param>
        internal void Append(int data)
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
            Console.WriteLine("{0} appended", node.data);
        }

        /// <summary>
        /// UC 4 Ability to insert 30 between 56 and 70
        /// </summary>
        /// <param name="x"></param>
        internal void InsertAtMid(int x)
        {
            if (head == null)
            {
                head = new Node(x);
            }
            else
            {
                Node newNode = new Node(x);

                Node ptr = head;
                int length = 0;

                /// calculate length of the linked list i.e, the number of nodes  
                while (ptr != null)
                {
                    length++;
                    ptr = ptr.next;
                }

                /// 'count' the number of nodes after which the new node is to be inserted  
                int count = ((length % 2) == 0) ? (length / 2) : (length + 1) / 2;
                ptr = head;

                /// 'ptr' points to the node after which the new node is to be inserted  
                while (count-- > 1)
                {
                    ptr = ptr.next;
                }

                /// insert the 'newNode' and adjust the required links  
                newNode.next = ptr.next;
                ptr.next = newNode;
            }
        }

        /// <summary>
        /// UC 5 Ability to delete the first element in the LinkedList of sequence 56->30->70
        /// </summary>
        internal void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is Empty, deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.head.data);
            this.head = this.head.next;
        }
    }
}
