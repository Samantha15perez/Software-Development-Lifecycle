using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RomanNumeralCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int converter;
                converter = RomannumeralConverter.RomanToInteger(textBox1.Text);

                label1.Text = converter.ToString();
            }
            catch
            {
                MessageBox.Show("Please only use the numbers 0-9 and letters I, V, X, L, C, D, and M.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                string converter;
                converter = ArabicToRomanConversion.ArabicToRoman(int.Parse(textBox1.Text));

                label1.Text = converter.ToString();
            }
            catch
            {
                MessageBox.Show("Please only use the numbers 0-9 and letters I, V, X, L, C, D, and M.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           try
            {
                int converter = int.Parse(textBox1.Text);



                //converter = Convert.ToInt64(textBox1.Text, 16);



                label1.Text = Convert.ToString(converter, 16).ToUpper();
            }
            catch
            {
                MessageBox.Show("YA BROKE IT");
            }
           
            
        }
    }
}
