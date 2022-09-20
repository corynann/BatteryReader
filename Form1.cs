using System.Diagnostics;
using System.Timers;

namespace BatteryReader
{
    public partial class Form1 : Form
    {
        Logger lg = new Logger();

        

        public Form1()
        {
            InitializeComponent();

            lg.Tick += Update;

            txt_Status.Text = "Waiting";
            txt_LogFile.Text = lg.LogFile;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            lg.Start();
            txt_Status.Text = "Running";
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            lg.Stop();
            txt_Status.Text = "Stopped";
        }

        void Update(object sender, EventArgs e)
        {
            var last = txt_LogBox.Text;
            txt_LogBox.Text = lg.LogString;
            txt_LogBox.AppendText(Environment.NewLine);
            txt_LogBox.AppendText(last);
        }
    }
}