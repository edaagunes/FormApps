﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kahramanmaraş");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kasiyer");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
        }
    }
}
