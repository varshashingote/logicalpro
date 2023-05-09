using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties.LinkedList
{
    public class Node
    {
        public string data;
        public Node next;
        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
