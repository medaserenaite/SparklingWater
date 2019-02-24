using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SparklingWater;

namespace SparklingWater.UnitTests
{
    [TestClass]
    //classnameTests
    public class SparklingWaterTests
    {
        [TestMethod]
        //public void Main_Scenario_ExpecteBehaviour()
        //scenario=execution path
        public void Main_CoconutIsLastInLine_ReturnsSuccess()
        {
            //Arrange - initialize our objects
            int[] sodaCans = new int[13]{ 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4 };
            var expected = (sodaCans[12] == 4);

            //Act
            var actual = (sodaCans[12] == 4);

            //Assert
            Assert.Equals(expected, actual);
        }
    }
}


