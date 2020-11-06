using System;
using System.Collections.Generic;
using DataStructureLinkedList;
using static DataStructureLinkedList.RefactorLinkedList;

namespace DataStructureLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            SortList<int> sList = new SortList<int>();
            sList.addNode(56);
            sList.addNode(30);
            sList.addNode(40);
            sList.addNode(70);
            
            //Displaying original list  
            Console.WriteLine("Original list: ");
            sList.display();

            //Sorting list  
            sList.sortList();

            //Displaying sorted list  
            Console.WriteLine("Sorted list: ");
            sList.display();
        }
    }
}
