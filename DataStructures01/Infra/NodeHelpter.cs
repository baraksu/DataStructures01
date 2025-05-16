using System;
using Unit4.CollectionsLib;

namespace Infra
{
    public class NodeHelpter
    {
        public static void PrintList<T>(Node<T> lst)
        {
            Node<T> p = lst;
            while (p != null)
            {
                Console.Write(p.GetValue() + " ");
                p = p.GetNext();
            }

        }
    }
}