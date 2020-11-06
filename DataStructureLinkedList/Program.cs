using System;
using System.Collections.Generic;

namespace DataStructureLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
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
        }
    }
}
