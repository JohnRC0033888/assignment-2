﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
//Allows an error message to show if answer is invalid

                double resistance1 = double.Parse(textBox1.Text);
                double resistance2 = double.Parse(textBox2.Text);
                double resistance3 = double.Parse(textBox3.Text);
                double resistance4 = double.Parse(textBox4.Text);
                double resistance5 = double.Parse(textBox5.Text);
//allows us to be able to write in the text boxs
                double Total_Resistance = resistance1 + resistance2 + resistance3 + resistance4 + resistance5;
                MessageBox.Show("Total_Resistance = " + Total_Resistance.ToString("0.00") + "ohms");
            }//allows us to complete calculation
            catch
            {
                MessageBox.Show("Error in interpreting values");
            }
        }//tells us if the code will not work

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//Allows an error message to show if answer is invalid


                double resistance6 = double.Parse(textBox6.Text);
                double resistance7 = double.Parse(textBox7.Text);
                double resistance8 = double.Parse(textBox8.Text);
                double resistance9 = double.Parse(textBox9.Text);
                double resistance10 = double.Parse(textBox10.Text);
                //allows us to be able to write in the text boxs
                double Total_Resistance = (1.0/ (1.0 / resistance6 + 1.0 / resistance7 + 1.0 / resistance8 + 1.0 / resistance9 + 1.0 / resistance10))
                    ;
                MessageBox.Show("Total_Resistance = " + Total_Resistance.ToString("0.00") + "ohms");
                //allows us to complete calculation
            }
            catch
            {
                MessageBox.Show("Error in interpreting values");
            }//tells us if the code will not work
        }
    }
}
             

                

            

