using System;
using System.Collections.Generic;

namespace DataStructureLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();

            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Display();

            int x = 30;
            linkedList.InsertAtMid(x);
            linkedList.Display();

            linkedList.Pop();
            linkedList.Display();

            linkedList.PopLast();
            linkedList.Display();

            int position = linkedList.Search(30);
            Console.WriteLine("Index position of element 30 : " + position);

            linkedList.InsertAtParticularPosition(position+2, 40);
            linkedList.Display();
        }
    }
}
