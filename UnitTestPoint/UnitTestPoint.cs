using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Azimut;

namespace UnitTestAzimut
{
    [TestClass]
    public class UnitTestPoint
    {
        [DataTestMethod]
        [DataRow(-1000.0, -1000.0)]
        [DataRow(1000.0, 1000.0)]       
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodCtor_ThrowsArgumentOutOfRangeException(double a, double b)
        {
            //Arrange
            Point p;

            //Act
            p = new Point(a, b);
        }


        [DataTestMethod]
        [DataRow(-90, 0.0)]
        [DataRow(90, 0.0)]
        [DataRow(0.0, -180.0)]
        [DataRow(0.0, 180.0)]

        [DataRow(-89.9, 0.0)]
        [DataRow(89.9, 0.0)]
        [DataRow(0.0, -179.9)]
        [DataRow(0.0, 179.9)]
        [DataRow(-89.9, -179.9)]
        [DataRow(89.9, 179.9)]
        [DataRow(89.9, -179.9)]
        [DataRow(-89.9, 179.9)]     
        public void TestMethodCtor_CreatePoint(double a, double b)
        {
            //Arrange
            Point p;

            //Act
            p = new Point(a, b);

            //Assert
            Assert.IsNotNull(p);
        }
    }
}
