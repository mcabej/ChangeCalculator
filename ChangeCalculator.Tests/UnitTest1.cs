using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static ChangeCalculator.ChangeCalc;

namespace ChangeCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPaymentValid_SufficientPayment_True()
        {
            // Arrange & Act
            var actual = IsPaymentValid(10, 20);
            
            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void IsPaymentValid_InSufficientPayment_False()
        {
            // Arrange & Act
            var actual = IsPaymentValid(10, 5);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void GetChange()
        {
            // Arrange
            var expectedValues = new List<string>
            {
                "1 x £10",
                "2 x £2",
                "1 x 50p"
            };

            // Act
            var change = ChangeCalc.GetChange(5.5M, 20);

            // Assert
            CollectionAssert.AreEqual(expectedValues, change);
        }

        [TestMethod]
        public void GetChange_Decimal()
        {
            // Arrange
            var expectedValues = new List<string>
            {
                "1 x £10",
                "1 x £5",
                "1 x 1p"
            };

            // Act
            var change = ChangeCalc.GetChange(4.99M, 20);

            // Assert
            CollectionAssert.AreEqual(expectedValues, change);
        }
    }
}
