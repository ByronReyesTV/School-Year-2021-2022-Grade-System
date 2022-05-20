using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Year_2021_2022_Grade_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Full Name
            String label1 = textBox1.Text;
            String label2 = textBox2.Text;
            String label3 = textBox3.Text;
            String label4 = textBox4.Text;
            String name = label1 + label2 + label3;


            // Grade input
           double label5 = Convert.ToDouble(textBox5.Text);
           double label6 = Convert.ToDouble(textBox6.Text);
           double label7 = Convert.ToDouble(textBox7.Text);
           double label8 = Convert.ToDouble(textBox8.Text);
           double label9 = Convert.ToDouble(textBox9.Text);
           double label10 = Convert.ToDouble(textBox10.Text);
           double label11 = Convert.ToDouble(textBox11.Text);
           double label12 = Convert.ToDouble(textBox12.Text);

           // Math
           double sum = label5 + label6 + label7 + label8 + label9 + label10 + label11 + label12;
           double div = sum / 8;

            // Display
            label13.Text = name;
            label14.Text = label4;
            label15.Text = "The General Average is: " + div;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
