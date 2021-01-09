using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int Rcounter = 0;
        int Lcounter = 0;
        int Mcounter = 0;

        int index = 0;
        string[] colors = { "yellow", "orange", "red", "purple", "blue", "aqua", "green" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == 7)
                index = 0;



            this.BackColor = Color.FromName(colors[index]);
            index++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Opacity>.05) 
            this.Opacity -=.05;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity +=.05;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "Right")
                Rcounter++;
            if (e.Button.ToString() == "Left")
                Lcounter++;
            if (e.Button.ToString() == "Middle")
                Mcounter++;

            label3.Text = Rcounter.ToString();
            label2.Text = Mcounter.ToString();
            label1.Text = Lcounter.ToString();
        }
    }
}
