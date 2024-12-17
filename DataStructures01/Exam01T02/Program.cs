using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;
using Unit4.CollectionsLib;

namespace Exam01T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> l = new Node<int>(2,
                new Node<int>(6,
                    new Node<int>(7,
                        new Node<int>(2,
                            new Node<int>(4,
                                new Node<int>(11,
                                    new Node<int>(76,
                                        new Node<int>(43,
                                            new Node<int>(11)))))))));
            l.PrintList();
            AddSumOfTwo(l);
            l.PrintList();

        }

        public static void AddSumOfTwo(Node<int> lst)
        {
            int index = 0;
            int sum = 0;
            Node<int> p = lst;
            while (p!=null)
            {
                index += 1;
                sum += p.GetValue();

                if (index % 2 == 0)
                {
                    Node<int> newNode = new Node<int>(sum, p.GetNext());
                    p.SetNext(newNode);
                    p = p.GetNext();
                    sum = 0;
                }
                p = p.GetNext();
            }

        }

    }
}
