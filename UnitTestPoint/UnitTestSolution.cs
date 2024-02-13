using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Azimut;
using System.Collections;

namespace UnitTestAzimut
{
    public class TestData
    {
        public (Point, Point)[] data = new (Point, Point)[] 
        { 
            (new Point(50, 50), new Point(50, 50)),
            (new Point(77.1539, -139.398), new Point(-77.1804, -139.55)),
            (new Point(77.1539, 120.398), new Point(77.1804, 129.55)),
            (new Point(77.1539, -120.398), new Point(77.1804, 129.55)),
        };
    }


    [TestClass]
    public class UnitTestSolution
    {    
        [DataTestMethod]
        [DynamicData(nameof(TestData), DynamicDataSourceType.Property)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethodCtor_ThrowsArgumentOutOfRangeException(Point p1, Point p2)
        {
            //Arrange
            Solution s;

            //Act
            s = new Solution(p1, p2);

            //Assert
        } 
    }
}
