using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Azimut;

namespace UnitTestAzimut
{
    [TestClass]
    public class UnitTestPoint
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodCtor_ThrowsArgumentOutOfRangeException()
        {
            //Arrange
            Point p;
            double a = -1000.0, b = -1000.0;

            //Act
            p = new Point(a, b);
        }

        [TestMethod]
        public void TestMethodCtor_CreatePoint()
        {
            //Arrange
            Point p;
            double a = 0.0, b = 0.0;

            //Act
            p = new Point(a, b);

            //Assert
            Assert.IsNotNull(p);
        }
    }
}
