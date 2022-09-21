using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Timers;
using LiveCharts.Charts;
using LiveCharts.Defaults;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace BatteryReader
{
    public partial class Form1 : Form
    {
        #region Properties

        Logger lg = new Logger();

        private int startWidth = 585;
        private int startHeight = 291;
        private bool IsSettingsVisible = false;
        private int SettingsWidth = 404;

        #endregion

        #region Initialize

        public Form1()
        {
            InitializeComponent();

            Initialize();
        }
        void Initialize()
        {
            lg.Logged += Update;
            lg.Started += Running;
            lg.Stopped += Stopped;

            Width = startWidth;
            Height = startHeight;

            txt_LogFile.Text = lg.LogFile;
            int_Interval.Value = lg.LogInterval / 1000; //convert to secs

            InitializeChart();

            Inactive();
        }

        #endregion

        #region Controls

        private void btn_Start_Click(object sender, EventArgs e)
        {
            lg.Start();
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            lg.Stop();
        }
        
        private void btn_Settings_Click(object sender, EventArgs e)
        {
            if (IsSettingsVisible)
            {
                Width -= SettingsWidth;
                IsSettingsVisible = false;
            }
            else
            {
                Width += SettingsWidth;
                IsSettingsVisible = true;
            }
        }

        private void int_Interval_ValueChanged(object sender, EventArgs e)
        {
            lg.LogInterval = (int)int_Interval.Value * 1000;
        }

        #endregion Controls

        #region States

        void Inactive()
        {
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;

            txt_Status.Text = "Waiting";
        }

        void Running(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
            txt_LogFile.Enabled = false;

            txt_Status.Text = "Running";
        }

        void Stopped(object sender, EventArgs e)
        {
            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            txt_LogFile.Enabled = true;

            txt_Status.Text = "Stopped";
        }

        #endregion

        #region Chart

        private ObservableCollection<double> chartValues;
        private int X;

        void InitializeChart()
        {
            chartValues = new ObservableCollection<double>();

            chart_Battery.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = chartValues,
                    GeometrySize = 0,
                    LineSmoothness = 1,
                    Fill = null
                }
            };
        }
        

        #endregion

        #region Private Methods
        
        void Update(object sender, EventArgs e)
        {
            var last = txt_LogBox.Text;
            txt_LogBox.Text = lg.LogString + Environment.NewLine + last;
            
            chartValues.Add(lg.CurrentCharge);
        }

        #endregion
    }
}