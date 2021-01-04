﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double val = 0;
        String text = "";
        bool oper_press = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if((output.Text == "0")||(oper_press))
            {
                output.Clear();
            }

            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
            oper_press = false;
        }

        private void button2_click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void op_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = Double.Parse(output.Text);

            oper_press = true;


        }

        private void cp_press(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    output.Text = (val + Double.Parse(output.Text)).ToString();
                    break;

                case "-":
                    output.Text = (val - Double.Parse(output.Text)).ToString();
                    break;

                case "X":
                    output.Text = (val * Double.Parse(output.Text)).ToString();
                    break;

                case "/":
                    output.Text = (val / Double.Parse(output.Text)).ToString();
                    break;

                default:
                    break;

            }
             oper_press = false;
        }

        private void c_press(object sender, EventArgs e)
        {
            output.Clear();
            val = 0;
        }
    }
}
