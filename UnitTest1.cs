using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice;

namespace practiceUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getPlusSign()
        {
            //arrange
            var x = new PerformArithmetic();
            var y = new PerformFileOperations();
            //act
            y.typeOfArithmetic = "add";
            x.getOperand(y);

            //assert
            Assert.AreEqual(x.operand, "+");
        }
        [TestMethod]
        public void getMinusSign()
        {
            //arrange
            var x = new PerformArithmetic();
            var y = new PerformFileOperations();
            //act
            y.typeOfArithmetic = "subtract";
            x.getOperand(y);

            //assert
            Assert.AreEqual(x.operand, "-");
        }
        [TestMethod]
        public void getMultiplicationSign()
        {
            //arrange
            var x = new PerformArithmetic();
            var y = new PerformFileOperations();
            //act
            y.typeOfArithmetic = "multiply";
            x.getOperand(y);

            //assert
            Assert.AreEqual(x.operand, "*");
        }
        [TestMethod]
        public void getDivisionSign()
        {
            //arrange
            var x = new PerformArithmetic();
            var y = new PerformFileOperations();
            //act
            y.typeOfArithmetic = "divide";
            x.getOperand(y);

            //assert
            Assert.AreEqual(x.operand, "/");
        }
    }
}
