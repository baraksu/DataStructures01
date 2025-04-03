using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassTest02;
using Unit4.CollectionsLib;

namespace ClassTestTests
{

    [TestClass]
    public class ClassTest02Tests
    {
        [TestMethod]
        public void Q01FindMiddle()
        {
            Node<char> lst = new Node<char>('a',
                new Node<char>('b',
                new Node<char>('E',
                new Node<char>('F',
                new Node<char>('i',
                new Node<char>('j'))))));

            Console.WriteLine("lst");
            Infra.Helper.PrintList(lst);
            Node<char> newList = ClassTest02Q01.GetMiddleChars(lst);
            Console.WriteLine("");
            Console.WriteLine("newLst");
            Infra.Helper.PrintList(newList);
            Assert.IsTrue(newList!=null);


        }

        [TestMethod]
        public void Q02QueueTest()
        {
            Queue<int> q = new Queue<int>();
            q.Insert(22);
            q.Insert(18);
            q.Insert(5);
            q.Insert(128);
            q.Insert(12);
            q.Insert(14);
            q.Insert(98);
            q.Insert(10);
            q.Insert(7);
            q.Insert(816);
            q.Insert(862);
            q.Insert(54);
            q.Insert(28);
            var find = ClassTest02Q02.Find(q);
            Assert.IsTrue(find);
        }
    }
}
