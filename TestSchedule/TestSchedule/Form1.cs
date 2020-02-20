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
        ScheduleTwo sc2 = new ScheduleTwo();

        private void button1_Click(object sender, EventArgs e)
        {

                string key = txtKey.Text;
                sc.Start(int.Parse(txtHour.Text), int.Parse(txtMinute.Text), key);

                      
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int hour = int.Parse(txtHour.Text);
            int minute = int.Parse(txtMinute.Text);
            string key = txtKey.Text;
            sc.Update(hour, minute, key);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            int second = int.Parse(txtSecond.Text);
            string key = txtKey.Text;
            sc.runSecond(second, key);
        }

        private void btnEditSecond_Click(object sender, EventArgs e)
        {
            int second = int.Parse(txtSecond.Text);
            string key = txtKey.Text;
            sc.updateSecond(second, key);
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            int second = int.Parse(txtSecond.Text);
            string key = txtKey.Text;
            sc.repeatJob(second, key);
        }
    }
}
