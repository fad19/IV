using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL_add_2_numbners
{
    class Program
    {
        static void Main(string[] args)
        {
            int carry = 0;
            LinkedListNode<int> first = new LinkedListNode<int>(9);
            LinkedListNode<int> second = new LinkedListNode<int>(9);
            LinkedListNode<int> third = new LinkedListNode<int>(9);
        
            LinkedListNode<int> first2 = new LinkedListNode<int>(5);
            LinkedListNode<int> secon2 = new LinkedListNode<int>(9);
            LinkedListNode<int> thir2 = new LinkedListNode<int>(2);

            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddFirst(first);
            list1.AddFirst(second);
            list1.AddFirst(third);
       
            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddFirst(first2);
            list2.AddFirst(secon2);
            list2.AddFirst(thir2);

            
            var r = addList(list1,list2,carry);
        }

        public static string addList(LinkedList<int> l1,LinkedList<int> l2, int carry)
        {
            string resultTotal=string.Empty; int value = 0;
            int cry = 0; string printResult = string.Empty;

            LinkedListNode<int> l1Head = l1.Last;
            LinkedListNode<int> l1Next = null ;


            LinkedListNode<int> l2Head = l2.Last;
            LinkedListNode<int> l2Next = null;

            while (l1Head != null && l2Head != null)
            {
                value = cry;
                if (l1Head != null)
                {
                    l1Next = l1Head;

                    value += l1Head.Value;
                    l1Head = l1Next.Previous;
                }

                if (l2.First != null)
                {
                    l2Next = l2Head;
                    value += l2Head.Value;
                    l2Head = l2Next.Previous;
                }
                if (value >= 10)
                {
                    cry = value % 10;
                    resultTotal += cry.ToString();
                }
                if(value<10 && l1Next.Previous==null && l2Next.Previous==null)
                {
                    resultTotal += value.ToString();
                }
                if (cry > 0)
                {
                    cry = 1;
                }
            }
            
          string  final = new string(resultTotal.Reverse().ToArray());
        
            return final;

        }
    }
}
