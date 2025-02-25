using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "aaaa";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculation_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(num1.Text);
            int b;
            b = Convert.ToInt32(num2.Text);
            int c;
            string d;
            if (symbol.Text == "+")
            {
                c = a + b;
                d = Convert.ToString(c);
                MessageBox.Show(d, "计算结果");
            }
            if (symbol.Text == "-")
            {
                c = a - b;
                d = Convert.ToString(c);
                MessageBox.Show(d, "计算结果");
            }
            if (symbol.Text == "*")
            {
                c = a * b;
                d = Convert.ToString(c);
                MessageBox.Show(d, "计算结果");
            }
            if (symbol.Text == "/")
            {
                c = a / b;
                d = Convert.ToString(c);
                MessageBox.Show(d, "计算结果");
            }
        }
    }
}
