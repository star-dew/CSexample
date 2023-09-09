using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temp)
        {
            if (temp < -5 || temp> 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temp;
        }   // public 메소드를 통해 protected 필드 접근

        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water: {temperature}");
        }

    }
}
