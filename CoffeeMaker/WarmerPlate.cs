using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
   public class WarmerPlate
    {    
        private State warmerState;
        public State WarmerState
        {
            get { return warmerState; }
            set { warmerState = value; }
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
