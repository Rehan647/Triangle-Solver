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

  



    }

}
