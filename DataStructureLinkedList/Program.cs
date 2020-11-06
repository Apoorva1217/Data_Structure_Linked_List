using System;
using System.Collections.Generic;

namespace DataStructureLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(56);
            linkedList.AddFirst(30);
            linkedList.AddFirst(70);
        }
    }
}
