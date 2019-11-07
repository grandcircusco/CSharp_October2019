using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17___DSandA
{
    class MostAwesomeList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void Add(string input)
        {
            Node newNode = new Node { Next = null, Data = input };

            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }
        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head; //marks the start of our search
            while (start != index)
            {
                start++;
                temp = temp.Next;
            }
            return temp;
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                Head = Head.Next;
            }
            else
            {
                Node thisNode = GetNode(index - 1);
                if (thisNode.Next.Next != null)
                {
                    thisNode.Next = thisNode.Next.Next;
                }
                else
                {
                    Tail = thisNode;
                }
            }
            Count--;
        }











        //public void RemoveAt(int index)
        //{
        //    if (index == 0)
        //    {
        //        Head = Head.Next;
        //    }
        //    else
        //    {
        //        Node thisNode = GetNode(index - 1);

        //        //using our already created GetNode method to locate the node via the index
        //        //this will allow us to talk to this particular Node's Next property
        //        for(int i = index; i <Count; i++)
        //        {
        //            //this is making sure that we're shifting the rest of the LinkedList
        //            if(thisNode.Next.Next != null)
        //            {
        //                thisNode.Next = thisNode.Next.Next;
        //            }
        //        }
        //    }
        //    Count--;
        //}
    }
}
