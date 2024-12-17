using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;
using Unit4.CollectionsLib;

namespace ClassTest01
{
    public class Q02
    {
        static void Main(string[] args)
        {
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
            return Sod2(node.GetNext(), a);
        }
    }
}
