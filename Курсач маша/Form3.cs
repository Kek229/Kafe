using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач_маша
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          Data.b = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Data.c = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Data.d = textBox3.Text;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Data.e = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Data.f = textBox5.Text;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Data.g = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Data.h = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Data.i = textBox8.Text;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Data.j = textBox9.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Data.l = textBox10.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.b = textBox1.Text;
            Data.c = textBox2.Text;
            Data.d = textBox3.Text;
            Data.e = textBox4.Text;
            Data.f = textBox5.Text;
            Data.l = textBox10.Text;
            Data.j = textBox9.Text;
            Data.i = textBox8.Text;
            Data.h = textBox7.Text;
            Data.g = textBox6.Text;
            if (Data.m == true)
            {
                
                Form4 form4=new Form4();
                form4.ShowDialog();
                Data.m= false;
            }
            
        }
    }
}
