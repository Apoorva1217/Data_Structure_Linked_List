using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureLinkedList
{
    public class LinkedList
    {
        public Node head;

        /// <summary>
        /// UC 2 Ability to create Linked List by adding 30 and 56 to 70
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
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
        public void Append(int data)
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
        public void InsertAtMid(int x)
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
        public void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is Empty, deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.head.data);
            this.head = this.head.next;
        }

        /// <summary>
        /// UC 6 Ability to delete the last element in the LinkedList of sequence 56->30->70
        /// </summary>
        public void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is Empty, deletion is not possible");
                return;
            }
            if (this.head.next == null)
            {
                Console.WriteLine("Stack is Empty, deletion is not possible");
                return;
            }
            Node tail = head;
            while (tail.next.next != null)
            {
                tail = tail.next;
            }
            tail.next = null;
            Console.WriteLine("LinkedList after deletion of last element");
        }

        /// <summary>
        /// UC 7 Ability to search LinkedList to find Node with value 30
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Search(int key)
        {
            Node node = this.head;
            int count = 0;

            while (node != null)
            {
                if (node.data == key)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }

        /// <summary>
        /// UC8 Ability to insert 40 after 30 to the Linked List sequence of 56->30->70
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;

                    if (position != 1)
                    {
                        Console.WriteLine("Position out of range");
                    }
                }
            }
            Console.WriteLine(head);
            return head;
        }

        /// <summary>
        /// UC 9 Ability to delete 40 from the Linked List sequence of 56->30->40->70 and show the size of LinkedList is 3
        /// </summary>
        /// <param name="position"></param>
        public void DeleteNode(int position)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;
            if (position == 0)
            {
                head = temp.next;
                return;
            }

            /// Find previous node of the node to be deleted 
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }

            /// If position is more than number of nodes 
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }

        /// <summary>
        /// Count the elements present in the linked list
        /// </summary>
        internal void Size()
        {
            Node temp = head;
            int size = 0;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            Console.WriteLine("The size of linked list is : " + size);
        }
    }
}
