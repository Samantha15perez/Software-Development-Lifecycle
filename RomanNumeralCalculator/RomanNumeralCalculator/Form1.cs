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
            //This tests if the input value is a numeric value or not.

            string Input = textBox1.Text;

            int Num;

            bool isNum = int.TryParse(Input, out Num);

            //this checks to see if the input is flagged as a non-numeric value; in this case a roman numeral. 

            if (!isNum)
            {

            
            try
            {
                //if all goes well, the code uses the class we created to convert the input value. 

                int converter;
                converter = RomannumeralConverter.RomanToInteger(textBox1.Text);

                // and then places it into the output box.

                label1.Text = converter.ToString();
                    
                    if (converter > 3999)
                    {
                       MessageBox.Show("Please input a value less than 3999.");
                        label1.Text = "Error";
                        //if the input value is more than 3999, it raises an error and does not display an output. 
                    }
            }
            catch
            {
                MessageBox.Show("Please only use capital letters I, V, X, L, C, D, and M.");
                    //if the input value contains letters besides roman numerals, it raises an error. 
            }
            }
            else
            {
                MessageBox.Show("Please only use capital letters I, V, X, L, C, D, and M. Not Arabic Numbers. ");
                //if the input is numeric already, you can't convert it. so it raises an error. 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This tests if the input value is a numeric value or not.

            string Input = textBox1.Text;

            int Num;

            bool isNum = int.TryParse(Input, out Num);
                        
            if (isNum)
            {
                //if the input is numeric, the code continues

                if (Num <= 3999)
                {
                    //if the input is between 0 and 3999, the code continues as normal. 
                
                try
                {

                    string converter;
                    converter = ArabicToRomanConversion.ArabicToRoman(int.Parse(textBox1.Text));

                    label1.Text = converter.ToString();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please notify the developer.");
                }
                }
                else
                {
                    //if the input is not between 0 and 3999, it raises an error.
                    MessageBox.Show("Please type in a value between 0 and 3999.");
                }
            }
            else
            {
                //if the input is not numeric, it raises an error.
                MessageBox.Show("Whole numbers only, please!");
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

        //this code is irrelevant; as it is for the hidden (and disabled) hexadecimal button.

        private void button3_Click(object sender, EventArgs e)
        {
           try
            {
                int converter = int.Parse(textBox1.Text);
                
              

                label1.Text = Convert.ToString(converter, 16).ToUpper();
            }
            catch
            {
                MessageBox.Show("YA BROKE IT");
            }
           
            
        }
    }
}
