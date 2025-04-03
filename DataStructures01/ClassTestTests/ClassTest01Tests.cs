using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassTest01;
using Infra;
using Unit4.CollectionsLib;

namespace ClassTestTests
{
    [TestClass]
    public class ClassTest01Tests
    {
        [TestMethod]
        public void Sod2_01()
        {
            Node<int> n5 = new Node<int>(5,
                new Node<int>(1,
                    new Node<int>(2,
                        new Node<int>(8,
                            new Node<int>(4)))));
            Q02.Sod2(n5,2);

        }
    }
}
