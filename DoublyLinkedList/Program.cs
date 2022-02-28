using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doubleLinkedList = new DoublyLinkedList(3);
            doubleLinkedList.Display();
            doubleLinkedList.addStart(2);
            doubleLinkedList.Display();
            doubleLinkedList.addStart(1);
            doubleLinkedList.Display();
            doubleLinkedList.addEnd(4);
            doubleLinkedList.Display();
            doubleLinkedList.addAt(7,3);
            doubleLinkedList.Display();
            doubleLinkedList.addAt(7, 1);
            doubleLinkedList.Display();
            doubleLinkedList.addAt(7, 4);
            doubleLinkedList.Display();
            //Console.WriteLine("Start");
            //Node testNode = new Node();
            //Node populatedNode = new Node(1);
            //testNode.DisplayNodeDetails();
            //populatedNode.DisplayNodeDetails();
            //Console.WriteLine("End");
        }
    }
}
