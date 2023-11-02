using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveKthNodeFromEnd
{
    public class RemoveKthNodeFromEnd
    {

        public class LinkedList
        {
            public int value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.value = value;
            }
        }

        public static void RemoveKthNode(LinkedList head,int k)
        {
            LinkedList start = head;
            LinkedList finish = head;

            int counter = 1;
            while(counter <=k)
            {
                finish = finish.Next;
                counter += 1;
            }
            if(finish == null)
            {
                head.value = head.Next.value;
                head.Next = head.Next.Next;
                return;
            }
            while(finish.Next != null)
            {
                finish = finish.Next;
                start = start.Next;

            }
            start.Next = start.Next.Next;

        }
        public static void Main(string[] args)
        {
            
        }
    }
}
