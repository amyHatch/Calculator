using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {


        string op = "";
        string arg1 = "";
        string arg2 = "";
        string arg3 = "0";   

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }   

        private void button11_Click(object sender, EventArgs e)
        {
            arg1 = textBox1.Text;
            textBox1.Text = "";
            op = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            arg1 = textBox1.Text;
            textBox1.Text = "";
            op = "-";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            arg1 = textBox1.Text;
            textBox1.Text = "";
            op = "*";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            arg1 = textBox1.Text;
            textBox1.Text = "";
            op = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            arg2 = textBox1.Text;
            int answer = 0;
            if (op == "+")
            {
                answer = Int32.Parse(arg1) + Int32.Parse(arg2);
            }
               textBox1.Text = answer + "";
               if (op == "-")
                   
               {
                   answer = Int32.Parse(arg1) - Int32.Parse(arg2);
               }
                textBox1.Text = answer + "";
                if (op == "/")
                {
                    answer = Int32.Parse(arg1) / Int32.Parse(arg2);
                }
                textBox1.Text = answer + "";
                if (op == "*")
                {
                    answer = Int32.Parse(arg1) * Int32.Parse(arg2);
                }
                textBox1.Text = answer + "";
            }
        private void button16_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = arg3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        



        
    }
}
