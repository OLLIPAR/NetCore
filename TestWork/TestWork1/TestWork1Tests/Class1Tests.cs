using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWork1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork1.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void STest()
        {
            var r = new Class1();
            double c = new Random().NextDouble();
            var result = r.S(c);
            Assert.AreEqual(r.S(c), result);
        }

        [TestMethod()]
        public void STest1()
        {
            var r = new Class1();
            double c = new Random().NextDouble();
            var result = r.S(c,c,c);
            Assert.AreEqual(r.S(c,c,c), result);
        }

        [TestMethod()]
        public void STest2()
        {
            var r = new Class1();
            double c = new Random().NextDouble();
            var result = r.S(c,c);
            Assert.AreEqual(r.S(c,c), result);
        }
        [TestMethod()]
        public void STest3()
        {
            var r = new Class1();
            double c = new Random().NextDouble();
            double b = new Random().NextDouble();
            var result = r.S(b, c);
            Assert.AreEqual(r.S(b, c), result);
        }
    }
}