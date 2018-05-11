using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTier;

namespace ApplicationTemplate.Tests
{
    [TestClass]
    public class SailboatDtoTests
    {
        [TestMethod]
        public void CalculateMaxHullSpeed_WhenCalled_Calculates_Max_Hull_Speed()
        {
            //Arrange
            var sailboatDto = new SailboatDto()
            {
                 Name = "TestSailboat",
                 Type = "Ketch",
                 WaterLineLengthInFeet = 23.5m
            };

            //Act
            sailboatDto.CalculateMaxHullSpeed();

            var result = TruncateDecimal(sailboatDto.MaxHullSpeed.Value, 3);
            decimal expected = 6.495m;

            //Assert
            Assert.AreEqual(expected, result);
        }

        public decimal TruncateDecimal(decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal tmp = Math.Truncate(step * value);
            return tmp / step;
        }
    }
}
