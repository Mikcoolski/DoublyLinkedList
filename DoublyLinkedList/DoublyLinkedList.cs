using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        //Constructor 
        public DoublyLinkedList()
        {
            head = new Node();
            tail = head;
            size = 0;
        }

        //Constructor with predetermined value
        public DoublyLinkedList(int data)
        {
            head = new Node(data);
            tail = head;
            size = 0;
        }

        //Add Node at the beginning of the Doubly Linked List
        public void addStart(int data)
        {
            Node newNode = new Node(data);
            this.head.prevNode = newNode;
            newNode.nextNode = this.head;
            this.head = newNode;
            if (this.size == 0)
                this.tail = this.head.nextNode;
            this.size++;
        }

        //Add Node at the end of the Doubly Linked List
        public void addEnd(int data)
        {
            Node newNode = new Node(data);
            this.tail.nextNode = newNode;
            newNode.prevNode = this.tail;
            this.tail = newNode;
            this.size++;
        }

        //Add Node at a predetermined location in the Doubly Linked List
        public void addAt(int data, int location)
        {
            Node newNode = new Node(data);
            Node insertAt = this.findNode(location);
            newNode.nextNode = insertAt.nextNode;
            insertAt.nextNode = newNode;
            newNode.prevNode = insertAt;
            insertAt.nextNode.prevNode = newNode;
            this.size++;
        }

        public Node findNode(int data)
        {
            Node currentNode = this.head;

            while(currentNode.value != data)
            {
                currentNode = currentNode.nextNode;
            }
            return currentNode;
        }

        //Display the contents of the Doubly Linked List
        public void Display()
        {
            Node currentNode = this.head;

            if (this.size == 0)
            {
                Console.Write("[");
                Console.Write(currentNode.value);
                Console.Write("]");
            }
            else
            {
                for (int i = 0; currentNode != null; i++)
                {
                    Console.Write("[");
                    Console.Write(currentNode.value);
                    Console.Write("]");
                    currentNode = currentNode.nextNode;
                }
            }
            Console.WriteLine("");
        }
        
    }
}
