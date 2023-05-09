using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Queue
{
    internal class QueueMethod
    {
        Node head = null;
        public void Enque(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
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
            Console.WriteLine("Element Inserted into Queue{0}:", node.data);



        }

        public void deque()
        {

            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("Deque Element is{0}" + temp.data);

        }
        public void display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
            }
            while (temp != null)
            {
                Console.WriteLine("" + temp.data);
                temp = temp.next;
            }
        }


    }
}
