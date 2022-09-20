using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace BatteryReader
{
    internal class Logger
    {
        Timer myTimer = new Timer();

        private static int LogInterval { get; set; } = 1000; //Seconds

        public double CurrentCharge
        {
            get => currentCharge;
            set => currentCharge = value;
        }
        double currentCharge = 0;

        public DateTime LoggedDateTime
        {
            get => loggedDateTime;
            set => loggedDateTime = value;
        }
        private DateTime loggedDateTime;

        public string LogString
        {
            get => logString;
            set => logString = value;
        }

        private string logString;

        public double Charge { get; set; }
        public Logger()
        {
            myTimer.Tick += new EventHandler(LogCharge);
            myTimer.Interval = LogInterval; 
        }



        public double GetCharge()
        {
            Charge = BatteryTools.GetBatteryCharge();
            return Charge;
        }


        public void Start()
        {
            myTimer.Start();
        }

        public void Stop()
        {
            myTimer.Stop();
        }
        public void LogCharge(object sender, EventArgs e)
        {
            Charge = BatteryTools.GetBatteryCharge();
            LoggedDateTime = DateTime.Now;
            LogString = Charge + " " + LoggedDateTime;

            Debug.WriteLine(LogString);
        }


    }
}
