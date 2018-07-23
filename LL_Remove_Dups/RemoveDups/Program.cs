using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            HashSet<int> set1 = new HashSet<int>();

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

            set1 = deleteDups(list);

            foreach (var i in set1)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }

        public static HashSet<int> deleteDups(LinkedList<int> node)
        {
        HashSet<int> set = new HashSet<int>();
        LinkedListNode<int> headNode = node.First;

            LinkedListNode<int> previous = null;

            while(headNode !=null)
            {
               
                if(set.Contains(headNode.Value))
                {
                    previous= headNode.Next;
                }
                else
                {
                    set.Add(headNode.Value);
                    previous = headNode;
                }
                headNode = headNode.Next;
            }
    return set;
        }
    }
}
