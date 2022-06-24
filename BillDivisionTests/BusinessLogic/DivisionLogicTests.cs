using Microsoft.VisualStudio.TestTools.UnitTesting;
using BillDivision.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillDivision.BusinessLogic.Tests
{
    [TestClass]
    public class DivisionLogicTests
    {
        [TestMethod()]
        public void BonAppetitTest_WhereCalculatedIsCorrect()
        {
            //Arrange
            int[] arrayOfPrice = { 3, 10, 2, 9 };
            int indexOfItemThatAnnaDidNotEat = 1;
            int amountCalculatedByTom = 14;
            string expected = "Bon Appetit";

            //Act
            string actual = DivisionLogic.BonAppetit(arrayOfPrice, indexOfItemThatAnnaDidNotEat,amountCalculatedByTom);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void BonAppetitTest_WhereCalculatedIsNotCorrect()
        {
            //Arrange
            int[] arrayOfPrice = { 3, 10, 2, 9 };
            int indexOfItemThatAnnaDidNotEat = 1;
            int amountCalculatedByTom = 12;
            string expected = "Bon Appetit";

            //Act
            string actual = DivisionLogic.BonAppetit(arrayOfPrice, indexOfItemThatAnnaDidNotEat, amountCalculatedByTom);

            //Assert;
            Assert.AreNotEqual(expected, actual);
        }
    }
}