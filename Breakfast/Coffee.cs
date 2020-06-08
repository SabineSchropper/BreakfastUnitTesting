using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Breakfast
{
    public class Coffee
    {
        private string temperature;
        public string Temperature
        {
            get
            {
                SimulateTemperature();
                return temperature;
            }
        }
        
        public Coffee()
        {
            //SimulateTemperature();
        }

        public void SimulateTemperature()
        {
            if(temperature == null)
            {
                temperature = "Hot";
            }
            else if(temperature == "Hot")
            {
                temperature = "Quite hot";
            }
            else if (temperature == "Quite hot")
            {
                temperature = "Not so hot";
            }
            else if (temperature == "Not so hot")
            {
                temperature = "Cold";
            }

            /*Thread.Sleep(500);
            Temperature = "Quite Hot";
            Thread.Sleep(500);
            Temperature = "Not so Hot";
            Thread.Sleep(500);
            Temperature = "Cold";*/

        }
    }
  
}
