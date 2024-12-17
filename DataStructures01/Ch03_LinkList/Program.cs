using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;
using Unit4.CollectionsLib;

namespace Ch03_LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> n4 = new Node<int>(4);
            Node<int> n8 = new Node<int>(8, n4);
            Node<int> n2 = new Node<int>(2, n8);
            Node<int> n1 = new Node<int>(1, n2);
            Node<int> n5 = new Node<int>(5, n1);
            
            Node<int> lst = n5;

            lst.PrintList();
            int x = Sod2(lst, 2);
            Console.WriteLine(x);
            //mainLst = Move(mainLst, 2);

           

            Console.ReadKey();


        }

        public static int Sod2(Node<int> node, int a)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.GetValue() % a == 0)
            {
                return Sod2(node.GetNext(), a) + node.GetValue();
            }
            return Sod2(node.GetNext(),a);
        }

      
    

        public static Node<int> Move(Node<int> lst, int n)
        {
            int size = Size(lst);

            int k = size - n;

            Node<int> pos = GetLast(lst);
            
            pos.SetNext(lst);

            while (k > 0)
            {
                pos = lst;
                lst = lst.GetNext();
                k--;
            }

            pos.SetNext(null);
            return lst;


        }

        private static Node<int> GetLast(Node<int> lst)
        {
            Node<int> pos = lst;
            while (pos.HasNext())
            {
                pos = pos.GetNext();
            }

            return pos;
        }

        private static int Size(Node<int> lst)
        {
            int count = 0;
            Node<int> pos = lst;
            while (pos != null)
            {
                count++;
                pos = pos.GetNext();
            }

            return count;
        }
    }
}
