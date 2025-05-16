

using Infra;
using Matkonet01.Q01;
using Matkonet01.Q02;
using System;
using System.Runtime.InteropServices;
using Unit4.BinTreeCanvasLib;
using Unit4.CollectionsLib;

namespace Matkonet01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            ///////// -- Q01 ------
            
            Node<Malshab> lst = new Node<Malshab>(new Malshab(1, 0.2),
                new Node<Malshab>(new Malshab(3, 0.3),
                new Node<Malshab>(new Malshab(6, 0.1),
                new Node<Malshab>(new Malshab(78, 0.7)))));
            Candidate candidate = new Candidate();
            candidate.SetLst(lst);
            Console.WriteLine("\n -- lst --");
            NodeHelpter.PrintList(lst);
            Node<Malshab>top =  candidate.TopMotivated(1);
            Console.WriteLine("\n -- result -- ");
            NodeHelpter.PrintList(candidate.GetLst());
            Console.WriteLine("\n -- max --");
            NodeHelpter.PrintList(top);
            
            ///////// -- Q02 ------

            //Queue<Area> q = new Queue<Area>();
            //q.Insert(new Area("דימונה", 0.9f));
            //q.Insert(new Area("תל אביב", 0.8f));
            //q.Insert(new Area("עריית גבש", 0.7f));
            //q.Insert(new Area("yeshiva", 0.6f));
            //QueueHelper.Print(q);

            //Israel israel = new Israel();
            //israel.SetQ(q);
            //israel.UpdateYeshivaPriority(3, 4);
            //QueueHelper.Print(israel.GetQ());


            // Qq03
            //BinNode<int> t = new BinNode<int>(
            //    new BinNode<int>(
            //        new BinNode<int>(
            //            new BinNode<int>(9), 
            //            128,
            //            null),
            //        64,
            //        new BinNode<int> (5)
            //        ),
            //    32,
            //    new BinNode<int>(
            //        new BinNode<int> (
            //            new BinNode<int>(11),
            //            8,
            //            new BinNode<int>(
            //                new BinNode<int>(
            //                    new BinNode<int> (1),
            //                    2,
            //                    new BinNode<int> (79)),
            //                4,
            //                null)
            //            ),
            //        16,
            //        new BinNode<int>(7)
            //        )
            //    );

            //TreeCanvas.AddTree(t);
            //TreeCanvas.TreeDrawPostOrder();
            //int num = MaxGeometricSeries(t);
            //Console.WriteLine(" -- Result --");
            //Console.WriteLine(num);

        }
        public static int MaxGeometricSeries(BinNode<int> tr)
        {
            double mLeft = (double)tr.GetValue() / tr.GetLeft().GetValue();
            double mRight = (double)tr.GetValue() / tr.GetRight().GetValue();

            return
            Math.Max(
                MaxGeometricSeriesWithMana(tr.GetLeft(), mLeft),
                MaxGeometricSeriesWithMana(tr.GetRight(), mRight)) + 1;


        }

        private static int MaxGeometricSeriesWithMana(BinNode<int> node, double mana)
        {
            int left = 0;
            int right = 0 ;
            Console.WriteLine($"[{node.GetValue()}");
            if (node.GetLeft() != null &&
                (double)node.GetValue()/node.GetLeft().GetValue() == mana)
            {
                left = MaxGeometricSeriesWithMana(node.GetLeft(), mana) ;
            }

            if (node.GetRight() != null &&
                (double)node.GetValue() / node.GetRight().GetValue() == mana)
            {
                right = MaxGeometricSeriesWithMana(node.GetRight(), mana) ;
            }
            if (left > right)
            {
                Console.WriteLine($"->{node.GetLeft()}]");
            }else if (right> left)
            {
                Console.WriteLine($"->{node.GetRight()}]");
            }
            else
            {
                Console.WriteLine("]");
            }
            return Math.Max(left, right) + 1;


        }
    }
}
