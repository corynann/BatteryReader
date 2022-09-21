using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml;
using Timer = System.Windows.Forms.Timer;

namespace BatteryReader
{
    public enum LoggerState
    {
        Inactive,
        Running,
        Paused,
        Terminated
    }

    internal class Logger
    {
        #region Properties
        
        Timer myTimer = new Timer();


        public LoggerState State
        {
            get => state;
            private set => state = value;
        }
        private LoggerState state;


        /// <summary>
        /// Interval in milliseconds
        /// </summary>
        public int LogInterval
        {
            get => logInterval;
            set
            {
                logInterval = value;
                myTimer.Interval = value;
            } 
        }
        private int logInterval = 10000; 

        /// <summary>
        /// Location of Saved Data
        /// </summary>
        public string LogFile
        {
            get => logFile;
            set => logFile = value;
        }
        private string logFile = "Log.csv";//@"C:\Users\nann_c1\Desktop\Log.csv";

        /// <summary>
        /// Current Battery reading (%)
        /// </summary>
        public double CurrentCharge
        {
            get => currentCharge;
            set => currentCharge = value;
        }
        double currentCharge = 0;

        /// <summary>
        /// DateTime of Charge reading
        /// </summary>
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
                OnLog(new EventArgs());
            } 
        }
        private string logString;

        #endregion

        #region Initialize

        public Logger()
        {
            Initialize();
        }

        void Initialize()
        {
            myTimer.Tick += LogCharge;
            myTimer.Interval = LogInterval;
        }

        #endregion
        
        #region Events

        public event EventHandler Started;
        public virtual void OnStart(EventArgs e)
        {
            myTimer.Start();

            EventHandler handler = Started;
            handler?.Invoke(this, e);
        }

        public event EventHandler Stopped;

        public virtual void OnStop(EventArgs e)
        {
            myTimer.Stop();

            EventHandler handler = Stopped;
            handler?.Invoke(this, e);
        }

        public event EventHandler Logged;
        public virtual void OnLog(EventArgs e)
        {
            WriteFile();

            EventHandler handler = Logged;
            handler?.Invoke(this, e);
        }


        #endregion

        #region Commands

        public void Start()
        {
            OnStart(new EventArgs());
        }

        public void Stop()
        {
            OnStop(new EventArgs());
        }

        #endregion

        #region Private Methods

        void LogCharge(object sender, EventArgs e)
        {
            CurrentCharge = BatteryTools.GetBatteryCharge();
            LoggedDateTime = DateTime.Now;

            LogString = CurrentCharge + " " + LoggedDateTime.ToShortTimeString();
        }

        void WriteFile()
        {
            string newLine = CurrentCharge + ", " + LoggedDateTime + Environment.NewLine;
            File.AppendAllText(LogFile, newLine);
        }
        
        #endregion
    }
}
