using Collect;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CollectTests
{
    [TestClass]
    public class CollectTests
    {
        private static Dictionary<string, double[]> expectedRoots;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            expectedRoots = new Dictionary<string, double[]>
        {
            { "D<0", new double[] { } },      
            { "D=0", new double[] { -1 } },   
            { "D>0", new double[] { -3, -1 } }
        };
        }

        [TestMethod]
        public void FindRoots_ShouldReturnEmptyArray_WhenDiscriminantIsLessThanZero()
        {
            // Arrange
            double a = 1, b = 0, c = 1;
            double[] expected = expectedRoots["D<0"];

            // Act
            double[] actual = MathOperations.FindRoots(a, b, c);

            // Assert
            CollectionAssert.AreEquivalent(expected, actual, $"Ошибка: Ожидался один корень, но массив отличается от ожидаемого.");
        }

        [TestMethod]
        public void FindRoots_ShouldReturnSingleRoot_WhenDiscriminantIsEqualToZero()
        {
            // Arrange
            double a = 1, b = 2, c = 1;
            double[] expected = expectedRoots["D=0"];

            // Act
            double[] actual = MathOperations.FindRoots(a, b, c);

            // Assert
            CollectionAssert.AreEquivalent(expected, actual, $"Ошибка: Ожидался один корень, но массив отличается от ожидаемого.");
        }

        [TestMethod]
        public void FindRoots_ShouldReturnTwoRoots_WhenDiscriminantIsGreaterThanZero()
        {
            // Arrange
            double a = 1, b = 4, c = 3;
            double[] expected = expectedRoots["D>0"];

            // Act
            double[] actual = MathOperations.FindRoots(a, b, c);

            // Assert
            CollectionAssert.AllItemsAreUnique(actual, "Ошибка: Ожидались два уникальных корня, но найдены повторяющиеся значения.");
        }

        [TestMethod]
        public void CalculatePercentage_ShouldReturnCorrectPercentage_WhenValidInput()
        {
            // Arrange
            double number = 200.0, percent = 50.0;
            double expected = 100.0;

            // Act
            double actual = MathOperations.CalculatePercentage(number, percent);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001, $"Ошибка: Ожидалось {expected}, но получено {actual}");
        }
    }
}