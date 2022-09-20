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
        public event EventHandler Tick;

        public int LogInterval
        {
            get => logInterval;
            set
            {
                logInterval = value;
                myTimer.Interval = value;
            } 
        }
        private int logInterval = 2000; //milliseconds

        public string LogFile
        {
            get => logFile;
            set => logFile = value;
        }

        private string logFile = @"C:\Users\nann_c1\Desktop\Log.csv";

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
            set
            {
                logString = value;
                OnTick(new EventArgs());
            } 
        }

        private string logString;

        public double Charge { get; set; }

        public Logger()
        {
            myTimer.Tick += new EventHandler(LogCharge);
            myTimer.Interval = LogInterval;
        }

        public virtual void OnTick(EventArgs e)
        {
            WriteFile();

            EventHandler handler = Tick;
            handler?.Invoke(this, e);
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

        void WriteFile()
        {
            File.AppendAllText(LogFile, LogString + Environment.NewLine);
        }
    }
}
