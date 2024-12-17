using System;
using Unit4.CollectionsLib;

namespace Infra
{
    public static class Helper
    {
        public static void PrintList<T>(this Node<T> lst)
        {
            Node<T> p = lst;
            while (p != null)
            {
                Console.Write(p.GetValue() + " ");
                p = p.GetNext();
            }

        }

        public static Queue<T> Clone<T>(Queue<T> queue)
        {
            Queue<T> tmp1 = new Queue<T>();
            Queue<T> tmp2 = new Queue<T>();

            while (!queue.IsEmpty())
            {
                T item = queue.Remove();
                tmp1.Insert(item);
                tmp2.Insert(item);
            }
            while (!tmp1.IsEmpty())
            {
                queue.Insert(tmp1.Remove());
            }
            return tmp2;
        }


    }
}