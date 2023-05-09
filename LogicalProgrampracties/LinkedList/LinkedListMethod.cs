using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.LinkedList
{
    public class LinkedListMethod
    {
        public Node head;


        public void Add(string data)
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
            Console.WriteLine("Inserted into Linked List :  {0}", node.data);
        }
        public void AddFirst(string data)
        {

            Node Node = new Node(data);
            Node.next = this.head;
            this.head = Node;
            Console.WriteLine("{0}is inserted into LikedList", Node.data);
        }
        public void AddLast(String data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newnode;
        }
        public void RemoveFirst()
        {

            if (head == null)
                Console.WriteLine("Its empty please add nodes");
            else
                Console.WriteLine("{0} is removed", head.data);
            head = head.next;
        }
        public void findRemoveLast()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("its empty please add nodes");
            if (temp.next == null)
            {
                string data = temp.data;
                temp = null;
                head = temp;
                Console.WriteLine("{0} Node is deleted", data);
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }

            }
            string lastDeleteNode = temp.next.data;
            temp.next = null;
            Console.WriteLine("{0} node is deleted ", lastDeleteNode);


        }

        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine(" Linked List is Empty ");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
