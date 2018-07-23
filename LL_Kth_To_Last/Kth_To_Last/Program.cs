using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_To_Last
{
    class Program
    {
        static void Main(string[] args)
        {
          
            LinkedListNode<int> first = new LinkedListNode<int>(9);
            LinkedListNode<int> second = new LinkedListNode<int>(5);
            LinkedListNode<int> third = new LinkedListNode<int>(3);
            LinkedListNode<int> fourth = new LinkedListNode<int>(5);
            LinkedListNode<int> fifth = new LinkedListNode<int>(7);

            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(first);
            list.AddFirst(second);
            list.AddFirst(third);
            list.AddFirst(fourth);
            list.AddFirst(fifth);

            LinkedListNode<int> nthValue = new LinkedListNode<int>(3);
             int value = NthToLast(list,nthValue.Value);
           //  bool value = deleteMiddleWithoutFirstLastNotNecessarilyMiddle(list,nthValue);
        }

        public static int NthToLast(LinkedList<int> list, int nValue)
        {
            int result = 0;


            LinkedListNode<int> p1 = list.First;
            LinkedListNode<int> p2 = list.First;


            for(int i=0; i<nValue;i++)
            {
                if (p1 != null)
                { p1 = p1.Next; }
                else
                {
                    throw new Exception();
                }

            }

            while(p1.Next!=null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
                
            }
            result = p2.Value;

            return result;
        }

        // remove will work, for the given list , else 
        public static bool deleteMiddleWithoutFirstLastNotNecessarilyMiddle(LinkedList<int> list, LinkedListNode<int> node)

        {
            if(node==null||node.Next==null)
            {
                return false;
            }

            if(list.Contains(node.Value))
            {
               list.Remove(node.Value);
            }
            LinkedListNode<int> next = list.Find(node.Value).Next;
            node.Value = next.Value;
            next = next.Next;




            return true;

        }
    }
}
