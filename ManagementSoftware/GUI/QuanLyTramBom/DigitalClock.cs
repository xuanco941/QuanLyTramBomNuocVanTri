using ManagementSoftware.Models.TramBomNuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSoftware.GUI.QuanLyTramBom
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
        }
        int TIME_INTERVAL_IN_MILLISECONDS = 500;
        System.Threading.Timer timer;
        void CallBack(Object obj)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            ChangeTime(new object());

            if (timer != null)
            {
                timer.Change(Math.Max(0, TIME_INTERVAL_IN_MILLISECONDS - watch.ElapsedMilliseconds), Timeout.Infinite);
            }
        }
        private void DigitalClock_Load(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(CallBack, null, TIME_INTERVAL_IN_MILLISECONDS, Timeout.Infinite);

        }


        void ChangeTime(object o)
        {
            if (IsHandleCreated && InvokeRequired)
            {
                BeginInvoke(new Action<object>(ChangeTime), o);
                return;
            }

            hours.Text = DateTime.Now.ToString("HH:mm:ss");
            day.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void DigitalClock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer != null)
            {
                this.timer.Change(Timeout.Infinite, Timeout.Infinite);
                timer.Dispose();
                timer = null;
            }
        }
    }
}
