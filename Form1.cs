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
            
            txt_Status.Text = "Waiting";
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
    }
}