using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleNode_LinkList
{
    public class MiddleNodeLinkList
    {

        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public LinkedList MiddleNode(LinkedList linkedList)
        {
            LinkedList slowNode = linkedList;
            LinkedList fastNode = linkedList;
            while (slowNode != null && fastNode !=null)
            {
                slowNode = slowNode.next;
                fastNode = fastNode.next.next;
            }

            return slowNode;
        }
        static void Main(string[] args)
        {
        }
    }
}
