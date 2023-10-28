using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintlinkedList
{
    internal class PrintLinkList
    {
        public class ListNode
        {
           public int value;
           public ListNode next;

           public ListNode(int val)
           {
                value = val;
           }
        }
        public static void Main(string[] args)
        {
            ListNode l1 = new ListNode(4);
            ListNode l2 = new ListNode(8);
            ListNode l3 = new ListNode(15);

            l1.next = l2;
            l2.next = l3;
            l3.next = null;

            ListNode ptr = l1;

            while(ptr != null)
            {
                Console.WriteLine(ptr.value);
                ptr = ptr.next;
                
            }
            Console.ReadKey();
        }
    }
}
