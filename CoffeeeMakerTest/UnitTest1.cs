using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeMaker;


namespace CoffeeeMakerTest
{
    [TestClass]
    public class BoilerTest
    {
        Boiler boiler = new Boiler();

        [TestMethod]
        public void Set_and_Get_Boiler_State()
        {
            boiler.BoilerState = State.ON;
            Assert.AreEqual(boiler.BoilerState, State.ON);
        }
        [TestMethod]
        public void CheckEmpty_with_Empty_sensor_read()
        {
            SensorRead read = SensorRead.Empty;
            bool result=  boiler.CheckEmpty(read);
            Assert.AreEqual(result,true);
        }
        [TestMethod]
        public void CheckEmpty_with_NotEmpty_sensor_read()
        {
            SensorRead read = SensorRead.NotEmpty;
            bool result = boiler.CheckEmpty(read);
            Assert.AreEqual(result, false);
        }

    }
}
