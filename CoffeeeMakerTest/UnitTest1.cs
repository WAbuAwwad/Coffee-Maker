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


    [TestClass]
    public class coffeeMakingTest
    {

        MakerElement warmer = new MakerElement();
        MakerElement boiler = new MakerElement();
        MakerElement pot = new MakerElement();
      
        [TestMethod]
        public void Brew_Coffee()
        {
            Maker maker = new Maker(warmer, boiler, pot);
            SensorRead wRead = SensorRead.NotEmpty;
            SensorRead bRead = SensorRead.NotEmpty;
            SensorRead pRead = SensorRead.Empty;
            State Button = State.ON;
            maker.makeCoffee(wRead, bRead, pRead, Button);
            Assert.AreEqual(maker.valve, State.ON);
            Assert.AreEqual(maker.boiler.State, State.ON);
          
        }
        [TestMethod]
        public void Brew_Coffee_Done()
        {
            Maker maker = new Maker(warmer, boiler, pot);
            SensorRead wRead = SensorRead.NotEmpty;
            SensorRead bRead = SensorRead.Empty;
            SensorRead pRead = SensorRead.Empty;
            State Button = State.ON;
            maker.makeCoffee(wRead, bRead, pRead, Button);
            Assert.AreEqual(maker.indicator, State.ON);
            Assert.AreEqual(maker.boiler.State, State.OFF);
            Assert.AreEqual(maker.warmer.State, State.ON);
        }
        [TestMethod]
        public void Pour_Coffee_RemovePot()
        {
            Maker maker = new Maker(warmer, boiler, pot);
            SensorRead wRead = SensorRead.Empty;
            SensorRead bRead = SensorRead.Empty;
            SensorRead pRead = SensorRead.NotEmpty;
            State Button = State.ON;
            maker.makeCoffee(wRead, bRead, pRead, Button);
            Assert.AreEqual(maker.warmer.State, State.OFF);
            Assert.AreEqual(maker.indicator, State.OFF);
        
        }
        [TestMethod]
        public void Pour_Coffee_ReturnPot()
        {
            Maker maker = new Maker(warmer, boiler, pot);
            SensorRead wRead = SensorRead.NotEmpty;
            SensorRead bRead = SensorRead.Empty;
            SensorRead pRead = SensorRead.NotEmpty;
            State Button = State.ON;
            maker.makeCoffee(wRead, bRead, pRead, Button);
            Assert.AreEqual(maker.warmer.State, State.ON);
            Assert.AreEqual(maker.indicator, State.ON);

        }

    }
}

