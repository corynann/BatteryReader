using System.Diagnostics;
using System.Timers;

namespace BatteryReader
{
    public partial class Form1 : Form
    {
        Logger lg = new Logger();

        private int startWidth = 247;
        private int startHeight = 291;

        public Form1()
        {
            InitializeComponent();

            lg.Tick += Update;

            Width = startWidth;
            Height = startHeight;

            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            txt_Status.Text = "Waiting";

            txt_LogFile.Text = lg.LogFile;
            int_Interval.Value = lg.LogInterval / 1000;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            lg.Start();

            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;
            txt_LogFile.Enabled = false;

            txt_Status.Text = "Running";
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            lg.Stop();

            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            txt_LogFile.Enabled = true;

            txt_Status.Text = "Stopped";
        }

        void Update(object sender, EventArgs e)
        {
            var last = txt_LogBox.Text;
            txt_LogBox.Text = lg.LogString + Environment.NewLine + last;
            //txt_LogBox.AppendText(Environment.NewLine);
            //txt_LogBox.AppendText(last);
        }


        private bool IsSettingsVisible = false;
        private int SettingsWidth = 404;
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
    }
}