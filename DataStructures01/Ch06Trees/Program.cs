using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace Ch06Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BinNode<int> t8 = new BinNode<int>(
            //    new BinNode<int>(
            //        new BinNode<int>(2),
            //        1,
            //        null),
            //    8,
            //    new BinNode<int>(
            //        new BinNode<int>(
            //        null,
            //        54,
            //        new BinNode<int>(56)),
            //    9,
            //    new BinNode<int>(
            //        null,
            //        7,
            //        new BinNode<int>(0))
            //    ));

            BinNode<int> t1 = new BinNode<int>(1);
            BinNode<int> t2 = new BinNode<int>(2);
            BinNode<int> t3 = new BinNode<int>(3);

            BinNode<int> t4 = new BinNode<int>(4);
            BinNode<int> t5 = new BinNode<int>(5);
            BinNode<int> t6 = new BinNode<int>(6);
            BinNode<int> t7 = new BinNode<int>(7);


            t1.SetLeft(t2);
            t1.SetRight(t3);

            t2.SetLeft(t4);
            t2.SetRight(t5);
            t3.SetLeft(t6);
            t3.SetRight(t7);

            int level = FindLevel(t1, 6);
            Console.WriteLine($"Level for number: {6} is {level}");




            //PrintLevel(t8, 2);

            //PrintPreOrder(t8);

            //PrintMeZugiWithoutSonEZugi(t8);

            Console.ReadKey();

        }

        private static int FindLevel(BinNode<int> t1, int number)
        {
            Queue<BinNode<int>> queue = new Queue<BinNode<int>>();
            queue.Insert(t1);
            BinNode<int> tmp;
            int currentLevelNodes, nextLevelNodes,level;
            level = 0;
            nextLevelNodes = 0;
            currentLevelNodes = 1;
            
            while (!queue.IsEmpty())
            {
                tmp = queue.Remove();
                if (tmp.GetValue() == number)
                {
                    return level;
                }
                --currentLevelNodes;
                if (tmp.GetLeft() != null)
                {
                    queue.Insert(tmp.GetLeft());
                    nextLevelNodes++;
                }
                if (tmp.GetRight() != null)
                {
                    queue.Insert(tmp.GetRight());
                    nextLevelNodes++;
                }

                if (currentLevelNodes ==0)
                {
                    currentLevelNodes = nextLevelNodes;
                    nextLevelNodes = 0;
                    level++;
                }
            }

            return -1;

        }

        private static void PrintLevel(BinNode<int> t8, int i)
        {
            int level = 0;
            int numberOfNodeInLevelNextLevel = 0;
            int numberOfNodeCurrentLevel = 1;

            Queue<BinNode<int>> queue = new Queue<BinNode<int>>();
            queue.Insert(t8);
            while (queue.IsEmpty())
            {
                
            }

        }

        private static void PrintMeZugiWithoutSonEZugi(BinNode<int> node)
        {
            if (node == null)
                return;

            if (node.GetValue() % 2 == 0)
            {
                if ((node.GetLeft() == null
                    || node.GetLeft().GetValue() % 2 == 0)
                    && (node.GetRight() == null ||
                        node.GetRight().GetValue() % 2 == 0))
                {
                    Console.WriteLine(node.GetValue());
                }

                // אם יש לי בן שיהיה זוגי
            }
            PrintMeZugiWithoutSonEZugi(node.GetLeft());
            PrintMeZugiWithoutSonEZugi(node.GetRight());
        }

        static void PrintPreOrder(BinNode<int> node)
        {
            if (node == null)
                return;

            PrintPreOrder(node.GetLeft());
            PrintPreOrder(node.GetRight());

            Console.WriteLine(node.GetValue());
        }
    }
}
