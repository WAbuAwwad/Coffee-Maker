﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
  public  class MakerElement
    {
     
        public State State { get; set; }

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
