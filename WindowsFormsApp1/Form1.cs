﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        double a = 0, b = 0, c = 0;
        char znak = '+';

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        double f, d;
        private void button13_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+': 
                    c = a + b;
                    break;
                case '-': 
                    c = a - b;
                    break;
                case '/':
                    c = a / b;
                    if (b == 0)
                    {
                        MessageBox.Show("Not 0");
                        textBox1.Text = "error";
                    }
                    break;
                case 'X':
                    c = a * b;
                    break;
            }
            textBox1.Text = c.ToString();
        }
    }
}
