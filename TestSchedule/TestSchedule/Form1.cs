using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Schedule sc = new Schedule();

        private void button1_Click(object sender, EventArgs e)
        {
            if (sc.checkScheduleStarted() == false)
            {
                sc.Start(int.Parse(txtHour.Text), int.Parse(txtMinute.Text));
                btnSchedule.Text = "Trạng thái chờ";
            }
            else
            {
                sc.Stop();
                btnSchedule.Text = "Tiến hành chờ";
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second;
            bool loopCycle = true;
            do
            {
                if (5 + DateTime.Now.Second > 60)
                {

                    second = (DateTime.Now.Second + 5) - 60;
                }
                else if (5 + DateTime.Now.Second == 60)
                {
                    second = 0;
                }
                else
                {
                    second = DateTime.Now.Second + 5;
                }
                if (sc.checkScheduleStarted() == false)
                {
                    sc.Start30(hour, minute, second);
                    btn30.Text = "5 giây chờ làm việc";
                    System.Threading.Thread.Sleep(5000);                    
                }
                else
                {
                    sc.Stop();
                    btn30.Text = "5 giây";
                    loopCycle = false;
                }
            } while (loopCycle == true);   
        }
    }
}
