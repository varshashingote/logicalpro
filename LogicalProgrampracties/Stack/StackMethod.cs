using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.Stack
{
   public class stackMethod
    {

        public Node top;
        public stackMethod()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;

            Console.WriteLine("Push element in stack" + data);
        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("poped Element Are:" + top.data);
            top = top.next;
        }
        public void peek()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("Peek element is" + top.data);
        }
        public void display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty ");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }

    }
}

