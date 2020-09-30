using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorisk_opgave;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace obligatorisk_opgave.Tests
{
    [TestClass()]
    public class BicycleTests
    {
        private Bicycle b1 = new Bicycle(0, "test", 2, 5);
        
        [TestMethod()]
        public void BicycleIdTest()
        {
            b1.Id = 2;
                Assert.AreEqual(2,b1.Id);
        }

        [TestMethod()]
        public void BicycleColourTest()
        {
            b1.Colour = "b";
            Assert.AreEqual("b", b1.Colour);

            b1.Colour = "blue";
            Assert.AreEqual("blue", b1.Colour);


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => b1.Colour = "");
            
        }


        [TestMethod()]
        public void BicyclePriceTest()
        {
            b1.Price = 1;
            Assert.AreEqual(1, b1.Price);

            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => b1.Price = 0);
        }

        [TestMethod()]
        public void BicycleGearTest()
        {
            b1.Gear = 3;
            Assert.AreEqual(3, b1.Gear);

            b1.Gear = 32;
            Assert.AreEqual(32, b1.Gear);


            Assert.ThrowsException<ArgumentOutOfRangeException>(() => b1.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => b1.Gear = 33);
        }



        [TestMethod()]
        public void BicycleTest()
        {
            b1 = new Bicycle(2, "Green", 400, 7);
            Assert.AreEqual(2, b1.Id);
            Assert.AreEqual("Green", b1.Colour);
            Assert.AreEqual(400, b1.Price);
            Assert.AreEqual(7, b1.Gear);
                

        }

        [TestMethod()]
        public void ToStringTest()
        {
        }
    }
}