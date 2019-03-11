using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    
  
    public  class Boiler
    {
     private State boilerState;
     public State BoilerState
        { 
            get { return boilerState; }
            set { boilerState = value; }
        }

     public bool CheckEmpty(SensorRead read)
        {
            if (read == SensorRead.Empty)
            {
                return true;
            }
            else return false;
        }

    }
}
