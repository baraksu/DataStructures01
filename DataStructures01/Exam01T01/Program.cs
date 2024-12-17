using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exam01T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2));
            Console.WriteLine(Sum(3));
            Console.WriteLine(Sum(4));
            Console.WriteLine(Sum(5));
            Console.WriteLine(Sum(6));
            Console.WriteLine(Sum(7));
            Console.WriteLine(Sum(8));
            Console.WriteLine(Sum(9));
            Console.WriteLine(Sum(10));



            ////////////////////
            //Console.WriteLine("*** Item At ");
            //Console.WriteLine(ItemAt(2));
            //Console.WriteLine(ItemAt(3));
            //Console.WriteLine(ItemAt(4));
            //Console.WriteLine(ItemAt(5));
            //Console.WriteLine(ItemAt(6));
            //Console.WriteLine(ItemAt(7));
            //Console.WriteLine(ItemAt(8));
            //Console.WriteLine(ItemAt(9));
            //Console.WriteLine(ItemAt(10));
            //Console.WriteLine("*** Sum ");
            //Console.WriteLine(Sum2(2));
            //Console.WriteLine(Sum2(3));
            //Console.WriteLine(Sum2(4));
            //Console.WriteLine(Sum2(5));
            //Console.WriteLine(Sum2(6));
            //Console.WriteLine(Sum2(7));
            //Console.WriteLine(Sum2(8));
            //Console.WriteLine(Sum2(9));
            //Console.WriteLine(Sum2(10));


        }


        // 1,2,3,7,11,16,22,29,37
        public static int Sum(int n)
        {
            return SumWithIndex(n,1, 1, 0);
        }

        static int SumWithIndex(int index,int  currentIndex,int itemAtIndex, int sum)
        {
            int nextItem = itemAtIndex + (currentIndex -1);
            int nextSum = sum + nextItem;

            Console.WriteLine($"currentIndex: {currentIndex}, itemAtIndex: {itemAtIndex}, sum: {sum}, nextItem: {nextItem}, nextSum: {nextSum}");
            
            if (currentIndex == index)
            {
                return nextSum;
            }

            return SumWithIndex(index, currentIndex + 1, nextItem, nextSum);

        }

        public static int ItemAt(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return ItemAt(n-1)+ n - 1;
        }

        public static int Sum2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return Sum2(n - 1) + ItemAt(n);
        }






        







    }
}
