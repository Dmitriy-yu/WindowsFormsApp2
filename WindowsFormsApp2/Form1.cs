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
     
        DateTime time = new DateTime();
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
                time += "0"+h;
            }
            else
            {
                time += h+time;
            }
            time += ":";
            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }
            time += ":";
            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }
            label2.Text = time;
            //label2.Text = (DateTime.Now.Hour +":")+(DateTime.Now.Minute  + ":")+(DateTime.Now.Second);
            //Более короткая запись                                                                                                                                                              Вариант более сокращенно
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

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
  
        }
  
        private void timer2_Tick(object sender, EventArgs e)
        {
            time = time.AddMilliseconds(5000);
            label3.Text = time.ToString("HH:mm:ss");
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;
            if (progressBar1.Minimum<progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value +10;
            }
            if (progressBar1.Value==1000)
            {
                progressBar1.Value = 0;
                timer1.Stop();
            }
            
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled == true)
                timer2.Enabled = false;
            MessageBox.Show("Сбросить","Вышло время",MessageBoxButtons.OKCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            label3.Text = "00:00:00";
            progressBar1.Value = 0;
          

        }

      
    }   
   
}
