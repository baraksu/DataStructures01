using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatkonetGamliel02;
using Unit4.CollectionsLib;

namespace MatkonetGamliel02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinNode<TwoItems> t = new BinNode<TwoItems>
            (
                new BinNode<TwoItems>(new TwoItems(4, 7)),
                new TwoItems(3, 7),
                new BinNode<TwoItems>(new TwoItems(3, 8))
            );

            bool isMinMax = IsMinMax(t);

            Console.WriteLine($"is min max:{isMinMax}");


        }

        private static bool IsMinMax(BinNode<TwoItems> node)
        {
            if (node.GetLeft() == null && node.GetRight() == null)
                return true;
            if (node.GetLeft() == null || node.GetRight() == null)
                return false;

            if (node.GetValue().GetMax() < GetMax(node.GetLeft()) ||
                node.GetValue().GetMax() < GetMax(node.GetRight()))
                return false;

            if (node.GetValue().GetMin() > GetMin(node.GetLeft()) ||
                node.GetValue().GetMin() > GetMin(node.GetRight()))
                return false;

            return IsMinMax(node.GetLeft()) && IsMinMax(node.GetRight());

        }

        public static int GetMax (BinNode<TwoItems> node)
        {
            if (node == null)
                return 0;


            return Math.Max(Math.Max(
                GetMax(node.GetLeft()) ,
                GetMax(node.GetRight())), node.GetValue().GetMax());


        }
        public static int GetMin(BinNode<TwoItems> node)
        {
            if (node == null)
                return 0;


            return Math.Max(Math.Min(
                GetMin(node.GetLeft()),
                GetMin(node.GetRight())), node.GetValue().GetMin());


        }
    }
}
