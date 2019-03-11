using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
  public  enum State
    {
        ON,
        OFF
    }
  public enum SensorRead
    {
        Empty,
        NotEmpty
    }
  class CoffeeMaker
    {
        private MakerElement warmer, boiler,pot;
        private State indicator = State.OFF;
        private State valve = State.OFF;



        public CoffeeMaker(MakerElement warmer, MakerElement boiler, MakerElement pot)
        {
          this.warmer = warmer;
           this.boiler = boiler;
            this.pot = pot;
        }

        public void makeCoffee(SensorRead wRead, SensorRead bRead, SensorRead pRead,State btn)
        {


        }
        static void Main()
        {
            
        }
    }


}
