using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryReader
{
    internal class BatteryTools
    {
        private PowerStatus pwrPowerStatus;

        public static double GetBatteryCharge()
        {
            double batteryCharge = 0;


            PowerStatus pwr = SystemInformation.PowerStatus;
            return pwr.BatteryLifePercent * 100;
        }
    }
}
