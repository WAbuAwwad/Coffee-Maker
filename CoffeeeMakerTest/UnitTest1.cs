using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeMaker;


namespace CoffeeeMakerTest
{
    [TestClass]
    public class MakerElementTest
    {
        MakerElement element = new MakerElement();

        [TestMethod]
        public void Set_and_Get_Element_State()
        {
            element.State = State.ON;
            Assert.AreEqual(element.State, State.ON);
        }
        [TestMethod]
        public void CheckEmpty_with_Empty_sensor_read()
        {
            SensorRead read = SensorRead.Empty;
            bool result = element.CheckEmpty(read);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void CheckEmpty_with_NotEmpty_sensor_read()
        {
            SensorRead read = SensorRead.NotEmpty;
            bool result = element.CheckEmpty(read);
            Assert.AreEqual(result, false);
        }

    }
}

