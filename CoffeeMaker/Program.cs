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
  public class Maker
    {
        public MakerElement warmer, boiler,pot;
        public State indicator = State.OFF;
        public State valve = State.OFF;

        public Maker(MakerElement warmer, MakerElement boiler, MakerElement pot)
        {
          this.warmer = warmer;
           this.boiler = boiler;
            this.pot = pot;
        }

        public void makeCoffee(SensorRead wRead, SensorRead bRead, SensorRead pRead,State btn)
        {
            if (!warmer.CheckEmpty(wRead))
            {
                if (pot.CheckEmpty(pRead))
                {
                    if (!boiler.CheckEmpty(bRead))
                    {
                        if (btn == State.ON)
                        {
                            valve = State.ON;
                            boiler.State = State.ON;

                        }
                    }
                    else

                    {
                        boiler.State = State.OFF;
                        indicator = State.ON;
                        warmer.State = State.ON;
                    }
                }
                else
                {
                    warmer.State = State.ON;
                    indicator = State.ON;
                }
            }
            else
            {
                indicator = State.OFF;
                warmer.State = State.OFF;
            }
        }
        static void Main()
        {
            
        }
    }


}
