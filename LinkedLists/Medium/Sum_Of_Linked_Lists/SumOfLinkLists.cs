using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Linked_Lists
{
    public class SumOfLinkLists
    {
        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value= value;
                this.next= null;
            }
        }


        public LinkedList SumOfLinkedLists(LinkedList linkedListOne,LinkedList linkedListTwo)
        {
            int numberOne = LinkedListToInt(linkedListOne);
            int numberTwo = LinkedListToInt(linkedListTwo);

            return NumberToLinkedList(numberOne + numberTwo);
        }

        private int LinkedListToInt(LinkedList linkedList)
        {
            return 0;
        }

        private LinkedList NumberToLinkedList(int number)
        {
            LinkedList linkedList = new LinkedList(0);

            return linkedList;
        }
         
        static void Main(string[] args)
        {
        }
    }
}
