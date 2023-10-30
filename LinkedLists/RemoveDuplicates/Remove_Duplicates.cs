using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    public class Remove_Duplicates
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

        public LinkedList RemoveDuplicatesFromLinkedLists(LinkedList linkedList)
        {

            LinkedList curr = linkedList;
            while (curr != null && curr.next != null)
            {
                if(curr.value == curr.next.value)
                {
                    curr.next = curr.next.next;
                }
                else
                {
                    curr = curr.next;
                }
            }

            return linkedList;
        }
        static void Main(string[] args)
        {
        }
    }
}
