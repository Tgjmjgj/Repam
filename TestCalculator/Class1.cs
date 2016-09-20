using System;
using NUnit.Framework;

namespace TestCalculator
{
    
    public class Test
    {
        //Add
        [Test]
        public void FirstTestAdd()
        {
            Assert.AreEqual(190, Calculator.Calculator.Add(99, 91));
        }

        [Test]
        public void SecondTestAdd()
        {
            Assert.AreNotEqual(39290, Calculator.Calculator.Add(35020, 4589));
        }

        [Test]
        public void ThirdTestAdd()
        {
            Assert.AreEqual(-1, Calculator.Calculator.Add(-2, -1));
        }

        //Minus
        [Test]
        public void FirstTestMinus()
        {
            Assert.AreEqual(8, Calculator.Calculator.Minus(99, 91));
        }

        [Test]
        public void SecondTestMinus()
        {
            Assert.AreNotEqual(1, Calculator.Calculator.Add(1, 1));
        }

        [Test]
        public void ThirdTestMinus()
        {
            Assert.AreEqual(-3, Calculator.Calculator.Add(-2, -1));
        }

        //Divide
        [Test]
        public void FirstTestDivide()
        {
            Assert.AreEqual(-20, Calculator.Calculator.Divide(800, -40));
        }

        [Test]
        public void SecondTestDivide()
        {
            Assert.AreNotEqual(1, Calculator.Calculator.Divide(1, 0));
        }

        [Test]
        public void ThirdTestDivide()
        {
            Assert.AreEqual(2, Calculator.Calculator.Divide(-2, -1));
        }

        //Multiplier
        [Test]
        public void FirstTestMultiplier()
        {
            Assert.AreEqual(0, Calculator.Calculator.Multiplier(0, -40));
        }

        [Test]
        public void SecondTestMultiplier()
        {
            Assert.AreNotEqual(-4, Calculator.Calculator.Multiplier(-2, -2));
        }

        [Test]
        public void ThirdTestMultiplier()
        {
            Assert.AreEqual(-9, Calculator.Calculator.Divide(-3, 3));
        }
    }

}
