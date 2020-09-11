using System;
using Xunit;
using ROSHAMBO;

namespace ROSHAMBOTest
{
    public class UnitTest1
    {
        [Fact]
        public void RockBeatsScissorsTest()
        {
            //Arrange
            var stringOne = "Rock";
            var stringTwo = "Scissors";
            Roshambo roshambo = new Roshambo();

            //Act
            var result = roshambo.Play(stringOne, stringTwo);
            //Assert
            Assert.True(result);
        }
    }
}
