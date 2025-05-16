using System;
using Unit4.CollectionsLib;

namespace Infra
{
    public static class QueueHelper
    {
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

        public static void Copy<T>(Queue<T> from, Queue<T> to)
        {
            while (!from.IsEmpty())
            {
                to.Insert(from.Remove());
            }
        }

        public static void Print<T>(Queue<T> queue)
        {
            Queue<T> tmp = new Queue<T>();
            Console.WriteLine("\n -- Q --");
            while (!queue.IsEmpty())
            {
                tmp.Insert(queue.Head());
                Console.WriteLine(queue.Remove());
            }
            Copy(tmp, queue);
            Console.WriteLine("-- endQ --");
        }
    }
}