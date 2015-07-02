using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer
{
    public partial class frm_Organizer : Form
    {
        int timechosen;
        int timeelapsed;
        int timerstart;
        bool running, minimized;
        public frm_Organizer()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeelapsed++;
            pB_time.Value = (timeelapsed * 100) / timechosen;
            if (timeelapsed == timechosen)
            {
                running = false;
                timer.Stop();
                btn_Start.Text = "Start";
                nUD_hrs.Enabled = true;
                nUD_minutes.Enabled = true;
                cBx_Alerts.Enabled = true;
                cBx_Sound.Enabled = true;
                cBx_Force.Enabled = true;
                if (cBx_Sound.Checked)
                {
                    SystemSounds.Asterisk.Play();
                }
                if (cBx_Force.Checked)
                {
                    ExitWindowsEx(0, 0);
                }
            }

            ntfyIcon.Text = (timechosen - timeelapsed) / 60 + " minutes remaining";

            //alerts
            if (cBx_Alerts.Checked)
            {
                //5 minutes left
                if (timechosen - timeelapsed == 300)
                {
                    if (cBx_Sound.Checked)
                    {
                        SystemSounds.Asterisk.Play();
                    }
                    ntfyIcon.BalloonTipTitle = "5 MINUTES REMAINING";
                    ntfyIcon.BalloonTipText = "It is recommended to save your work";
                    ntfyIcon.ShowBalloonTip(3000);
                }
                if (timechosen == timeelapsed)
                {
                    if (cBx_Sound.Checked)
                    {
                        SystemSounds.Asterisk.Play();
                    }
                    ntfyIcon.BalloonTipTitle = "Time is UP";
                    ntfyIcon.BalloonTipText = "Timer has finished";
                    ntfyIcon.Text = "THE MANGO PROJECT";
                    ntfyIcon.ShowBalloonTip(3000);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_start.Stop();
            if (!running)
            {
                timechosen = Convert.ToInt32(nUD_hrs.Value * 3600 + nUD_minutes.Value * 60);
                timeelapsed = 0;
                timer.Start();
                nUD_hrs.Enabled = false;
                nUD_minutes.Enabled = false;
                cBx_Alerts.Enabled = false;
                cBx_Sound.Enabled = false;
                cBx_Force.Enabled = false;
                btn_Start.Text = "Stop";
                running = true;
                ntfyIcon.BalloonTipTitle = "Starting Timer";
                ntfyIcon.BalloonTipText = "Timer is starting for "+nUD_hrs.Value+ " hr and "+ nUD_minutes.Value +" min";
                ntfyIcon.ShowBalloonTip(3000);
                Hide();
                minimized = !minimized;
            }
            else
            {
                running = false;
                timer.Stop();
                btn_Start.Text = "Start";
                nUD_hrs.Enabled = true;
                nUD_minutes.Enabled = true;
                cBx_Alerts.Enabled = true;
                cBx_Sound.Enabled = true;
                cBx_Force.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_start.Start();
            Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cBx_Force_CheckedChanged(object sender, EventArgs e)
        {
            if (cBx_Force.Checked)
            {
                MessageBox.Show("This will log off your computer \nSAVE OFTEN");
            }
        }

        private void frm_Organizer_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                minimized = !minimized;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void timer_start_Tick(object sender, EventArgs e)
        {
            timerstart++;
            if (timerstart == 300)
            {
                SystemSounds.Asterisk.Play();
                timechosen = 9000;
                ntfyIcon.BalloonTipTitle = "Starting Timer";
                ntfyIcon.BalloonTipText = "Timer is starting for 2 hr and 30 min";
                ntfyIcon.ShowBalloonTip(3000);
                timer_start.Stop();
                timeelapsed = 0;
                timer.Start();
                nUD_hrs.Enabled = false;
                nUD_minutes.Enabled = false;
                cBx_Alerts.Enabled = false;
                cBx_Sound.Enabled = false;
                cBx_Force.Enabled = false;
                btn_Start.Text = "Stop";
                running = true;
                Hide();
                minimized = !minimized;
            }   
        }

        private void ntfyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!minimized)
            {
                Hide();
                minimized = !minimized;
            }
            else
            {
                Show();
                WindowState = FormWindowState.Normal;
                minimized = !minimized;
            }
        }
    }
}
