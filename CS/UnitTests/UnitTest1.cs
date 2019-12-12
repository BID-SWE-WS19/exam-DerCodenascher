using BID.SWE.EXAM.Impl;
using NUnit.Framework;
using System.IO;

namespace UnitTests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Test1() {
            var mycl = new myclass1();
            Assert.AreEqual("Cell is on Position X:6 Y:7", mycl.PrintPostion(6, 7));
        }

        [Test]
        public void Test2() {
            var mycl = new myclass1();
            Assert.AreEqual("Cell rot born on 14.12.2019 is alive", mycl.PrintState(true, new System.DateTime(2019, 12, 14), "rot"));
        }

        [Test]
        public void Test3() {
            var mycl = new myclass2();
            mycl.Grow();
            Assert.AreEqual(4, mycl.Grow());
        }

        [Test]
        public void Test4() {
            var mycl = new myclass2();
            Assert.AreEqual("True", mycl.IsAlive(8).ToString());
        }

        [Test]
        public void Test5() {
            var mycl = new myclass2();
            Assert.AreEqual("False", mycl.IsAlive(3).ToString());
        }

        [Test]
        public void Test6() {
            var mycl = new myclass3();
            Assert.AreEqual("BID-Map", mycl.GetMapName());
        }

        [Test]
        public void Test7() {
            var mycl = new myclass3();
            Assert.AreEqual(36, mycl.GetMapSize(6));
        }

        [Test]
        public void Test8() {
            var mycl = new myclass3();
            Assert.AreEqual(5, mycl.AddNewCells(5));
        }

        [Test]
        public void Test9() {
            var ex = new Exercise3();
            var arr = ex.Method2();
            Assert.AreEqual(typeof(Springen), ((Bewegung[])arr)[0].GetType());
            Assert.AreEqual(typeof(Laufen), ((Bewegung[])arr)[1].GetType());
        }
    }
}