using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
   public class Pot
    {
        private State potState;
        public State PotState
        {
            get { return potState; }
            set { potState = value; }
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
