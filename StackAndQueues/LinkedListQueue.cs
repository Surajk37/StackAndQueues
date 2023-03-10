using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    class LinkedListQueue
    {
        Node head = null;

        //Enqueue Function
        public void Enqueue(int data)
        {
            //Node Object
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //Display Added Data
            Console.WriteLine("{0} inserted into Queue ", node.data);
        }

        //Dequeue Function
        internal void Dequeue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("\tDequeue value : {0}", this.head.data);
            this.head = this.head.next;
        }
        //Deletion till Queue Will Empty
        internal void IsEmpty()
        {
            while (this.head != null)
            {
                Dequeue();

            }
        }
        //Display Queue Data
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Queue Data : " + temp.data);
                temp = temp.next;
            }
        }
    }
}
