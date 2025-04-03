

using System;
using System.CodeDom.Compiler;
using Unit4.CollectionsLib;

namespace ClassTest02
{
    public class ClassTest02Q02
    {
        public static bool Find(Queue<int> q)
        {
            int a = q.Remove();
            int b = q.Remove();
            int c = q.Remove();
            int d = q.Remove();

            return FindRecursion(q, a, b, c, d);
        }

        private static bool FindRecursion(Queue<int> q, int a, int b, int c, int d)
        {
            if (!IsValid(a, b, c, d))
                return false;
            if (q.IsEmpty())
                return true;
            int next = q.Remove();
            return FindRecursion(q, b, c, d, next);
        }

        private static bool IsValid(int a, int b, int c, int d)
        {
            if (c % 2 == 1)
            {
                if (a >= 10 && a <= 99 && b >= 10 && b <= 99
                    && d >= 100 && d <= 999)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
    }
}