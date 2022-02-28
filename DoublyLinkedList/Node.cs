using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node
    {
        //object fields
        public int value;
        public Node nextNode;
        public Node prevNode;

        //constructor for empty node point to null
        public Node()
        {
            value = 0;
            nextNode = null;
            prevNode = null;

        }

        //constructor for a new node with defined value type 
        public Node(int data)
        {
            value = data;
            nextNode = null;
            prevNode = null;
        }

        //Display the Node in context fields for debugging
        public void DisplayNodeDetails ()
        {
            Console.WriteLine(this.value);
        }
    }
}
