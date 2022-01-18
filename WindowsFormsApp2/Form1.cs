using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            string time = " ";
            if (h < 10)
            {
                time += "0";
            }
            else
            {
                time += h;
            }
            time += ":";
            if (m < 10)
            {
                time += "0"+m;
            }
            else
            {
                time += m;
            }
            time += ":";
            if (s < 10)
            {
                time += "0"+s;
            }
            else
            {
                time += s;
            }
            label2.Text = time;
            string data = " ";
            int day = DateTime.Now.Day;
            int mans = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            if (day<10)
            {
                data += "0";
            }
            else
            {
                data += day;
            }
            data += "."; 
            if (mans<10)
            {
                data += "0"+mans;
            }
            else
            {
                data += mans+mans;
            }
            data += ".";
            if (year<10)
            {
                data += "0";
            }
            else
            {
                data +=year;
            }
            data += "г.";
            label1.Text = data;
        }
        
    }
}
