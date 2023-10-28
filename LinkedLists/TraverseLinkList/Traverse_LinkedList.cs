using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraverseLinkList
{
    public class Traverse_LinkedList
    {

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int value)
            {
                val= value;
            }
        }

        public static void TraverseLinkedList(ListNode Head)
        {
            ListNode temp = Head;
            while(temp != null)
            {
                int val = temp.val;
                Console.WriteLine(val);
                temp = temp.next;
            }
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            ListNode l1 = new ListNode(4);
            ListNode l2 = new ListNode(8);
            ListNode l3 = new ListNode(13);

            l1.next = l2;
            l2.next = l3;
            l3.next = null;
            ListNode head = l1;
            TraverseLinkedList(head);
        }
    }
}
