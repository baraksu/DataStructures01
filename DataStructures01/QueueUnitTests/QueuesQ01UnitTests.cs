using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Queue01;
using Unit4.CollectionsLib;

namespace QueueUnitTests
{
    [TestClass]
    public class QueuesQ01UnitTests
    {
        [TestMethod]
        public void Q01_OneItem()
        {
            Queue<int> q  = new Queue<int>();
            q.Insert(1);

            bool r = Chapter05.Q01_ExistSequence(q, 1);
            Assert.IsFalse(r);
                
        }
        [TestMethod]
        public void Q01_TwoItems()
        {
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(1);

            bool r = Chapter05.Q01_ExistSequence(q, 1);
            Assert.IsTrue(r);
        }
        [TestMethod]
        public void Q01_TwoItemsNotInSeq()
        {
            Queue<int> q = new Queue<int>();
            q.Insert(1);
            q.Insert(2);
            q.Insert(1);

            bool r = Chapter05.Q01_ExistSequence(q, 1);
            Assert.IsFalse(r);
        }
        [TestMethod]
        public void Q01_TwoItemsAfterFirstInSeq()
        {
            Queue<int> q = new Queue<int>();
            q.Insert(2);
            q.Insert(1);
            q.Insert(1);

            bool r = Chapter05.Q01_ExistSequence(q, 1);
            Assert.IsTrue(r);
        }

    }
}
