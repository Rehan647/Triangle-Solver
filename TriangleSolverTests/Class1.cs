using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestFixture] // NUnit annotation for test class
    public class TriangleSolverTests
    {
        [Test] // NUnit annotation for test method
        public void Test_EquilateralTriangle()
        {
            string expected = "Equilateral triangle";
            string result = Triangle.AnalyzeTriangle(3, 3, 3);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_IsoscelesTriangle_Case1()
        {
            // Arrange
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(5, 5, 3);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_IsoscelesTriangle_Case2()
        {
            // Arrange
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(6, 4, 6);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_IsoscelesTriangle_Case3()
        {
            // Arrange
            string expected = "Isosceles triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(2, 7, 7);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_ScaleneTriangle_Case1()
        {
            // Arrange
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(3, 4, 5);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_ScaleneTriangle_Case2()
        {
            // Arrange
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(7, 8, 9);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_ScaleneTriangle_Case3()
        {
            // Arrange
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(5, 12, 13);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_ScaleneTriangle_Case4()
        {
            // Arrange
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(9, 10, 11);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Test_ScaleneTriangle_Case5()
        {
            // Arrange
            string expected = "Scalene triangle";

            // Act
            string result = Triangle.AnalyzeTriangle(8, 15, 17);

            // Assert
            Assert.AreEqual(expected, result);
        }




    }

}
