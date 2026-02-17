using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void hour_Click(object sender, EventArgs e)
        {

        }

        private int intS = 0;
        private int intM = 0;
        private int intH = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        private void button5_Click(object sender, EventArgs e)
        {
       
            timer1.Enabled = false;
            timer2.Enabled = false;
             intS = 0;
             intM = 0;
             intH = 0;
            hour.Text = "00";
            minute.Text = "00";
            sec.Text = "00";
            button4.Enabled = true ;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            hour.Text = DateTime.Now.Hour.ToString();
            minute.Text = DateTime.Now.Minute.ToString();
            sec.Text = DateTime.Now.Second.ToString();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour.Text = DateTime.Now.Hour.ToString();
            minute.Text = DateTime.Now.Minute.ToString();
            sec.Text = DateTime.Now.Second.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            timer2.Enabled = true;

            intS++;

            sec.Text = intS.ToString();
            minute.Text = intM.ToString();
            hour.Text = intH.ToString();
            if (intS == 60)
            {
                intS = 0;
               
                intM++;
            }
            if (intM == 60)
            {
                intM = 0;
                intH++;
            }

            button4.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }


        bool isClock = true;
        private void button3_Click(object sender, EventArgs e)
        {
            isClock = !isClock;

            if (isClock)
            {
                timer2.Stop();  
                timer1.Start();  
            }
            else
            {
                timer1.Stop();  
                timer2.Start();  
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            intS++;

            sec.Text = intS.ToString();
            minute.Text = intM.ToString();
            hour.Text = intH.ToString();
            if (intS == 60)
            {
                intS = 0;

                intM++;
            }
            if (intM == 60)
            {
                intM = 0;
                intH++;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int lapCount = 0; 
        private void button7_Click(object sender, EventArgs e)
        {
            lapCount++;
          
            listBox1.Items.Add("Lap : " + lapCount + " - " + intH +" : " + intM + " : " + intS);

        }
    }
}
