using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;
using Infra;


namespace Queue01
{
    
    public class Chapter05
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Queue<string> s = new System.Collections.Generic.Queue<string>();
             s.Enqueue("s");
             

            Unit4.CollectionsLib.Queue<string> q = new Queue<string>();
            q.Insert("tt");


        }

        public static bool Q02_Equal_It<T>(Queue<T> q1, Queue<T> q2)
        {
            if (q1 == null && q2 == null)
                return true;
            if (q1 == null || q2 == null)
                return false;

            if (q1.IsEmpty() && q2.IsEmpty())
                return true;

            if (q1.IsEmpty() || q2.IsEmpty())
                return false;

            Queue<T> tmp1 = Infra.Helper.Clone(q1);
            Queue<T> tmp2 = Infra.Helper.Clone(q2);


            while (!tmp1.IsEmpty() && !tmp2.IsEmpty())
            {
                T a1 = tmp1.Remove();
                T b2 = tmp2.Remove();
                if (!a1.Equals(b2))
                    return false;
            }

            if (tmp1.IsEmpty() && tmp2.IsEmpty())
                return true;
            return false;


        }

        public static bool Q02_Equal_BeforeRecursive<T>(Queue<T> q1, Queue<T> q2)
        {
            if (q1 == null && q2 == null)
                return true;
            if (q1 == null || q2 == null)
                return false;

            Queue<T> tmp1 = Infra.Helper.Clone(q1);
            Queue<T> tmp2 = Infra.Helper.Clone(q2);

            bool result = Q02_Equal_Rec(tmp1, tmp2);

            return result;
        }

        public static bool Q02_Equal_Rec<T>(Queue<T> q1, Queue<T> q2)
        {
            if (q1.IsEmpty() && q2.IsEmpty())
                return true;

            if (q1.IsEmpty() || q2.IsEmpty())
                return false;

            T a1 = q1.Remove();
            T b2 = q2.Remove();
            if (!a1.Equals(b2))
                return false;
            return Q02_Equal_Rec(q1, q2);
        }





























    }
}
