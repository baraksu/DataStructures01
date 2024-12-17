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
        public void Q02_EmptyQueues()
        {
            Assert.IsTrue(Chapter05.Q02_Equal_It<bool>(null, null));
            Assert.IsFalse(Chapter05.Q02_Equal_It<bool>(null, new Queue<bool>()));
            Assert.IsFalse(Chapter05.Q02_Equal_It<bool>(new Queue<bool>(),null));

        } 
        [TestMethod]
        public void Q02_FullEqualQueues()
        {
            var q1 = new Queue<int>();
            var q2 = new Queue<int>();

            q1.Insert(5);
            q2.Insert(5);
                
            Assert.IsTrue(Chapter05.Q02_Equal_It(q1,q2));

        }
        [TestMethod]
        public void Q02_OneIsBiggerQueues()
        {
            var q1 = new Queue<int>();
            var q2 = new Queue<int>();

            q1.Insert(5);
            q2.Insert(5);
            q2.Insert(6);

            Assert.IsFalse(Chapter05.Q02_Equal_It(q1, q2));

        }
        
        [TestMethod]
        public void Q02_EmptyQueuesRecursive()
        {
            Assert.IsTrue(Chapter05.Q02_Equal_BeforeRecursive<bool>(null, null));
            Assert.IsFalse(Chapter05.Q02_Equal_BeforeRecursive<bool>(null, new Queue<bool>()));
            Assert.IsFalse(Chapter05.Q02_Equal_BeforeRecursive<bool>(new Queue<bool>(),null));

        } 
        [TestMethod]
        public void Q02_FullEqualQueuesRecursive()
        {
            var q1 = new Queue<int>();
            var q2 = new Queue<int>();

            q1.Insert(5);
            q2.Insert(5);
                
            Assert.IsTrue(Chapter05.Q02_Equal_BeforeRecursive(q1,q2));

        }
        [TestMethod]
        public void Q02_OneIsBiggerQueuesRecursive()
        {
            var q1 = new Queue<int>();
            var q2 = new Queue<int>();

            q1.Insert(5);
            q2.Insert(5);
            q2.Insert(6);

            Assert.IsFalse(Chapter05.Q02_Equal_BeforeRecursive(q1, q2));

        }
    }
}
