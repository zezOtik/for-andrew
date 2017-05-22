using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace андрей
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text),
                   b = Convert.ToDouble(textBox2.Text),
                   c = Convert.ToDouble(textBox3.Text);
            double r1, r2, r,r3;
            if (x < 3)
            {
                r = Math.Pow(Math.Abs(c), 0.5);
                r1 = b*Math.Pow(x,2);
                r2 = c*Math.Pow(x, 3);
                r3 = Math.Pow(Math.Abs(x), 0.5);
                if (r < r3)
                {
                    r = r3;
                    if (r < r1)
                    {
                        if (r > r2) r = r2;
                        else r = r;
                    }
                    else 
                    {
                        r = r1;
                        if (r < r2) r = r;
                        else r = r2;
                    }
                }
                else
                {
                    if (r < r1)
                    {
                        if (r > r2) r = r2;
                        else r = r;
                    }
                    else
                    {
                        r = r1;
                        if (r < r2) r = r;
                        else r = r2;
                    }
                }
            }
            if (x > 3)
            {
                r = Math.Exp(x);
                r1 = b - c * x * x;
                if (r < r1) r = r1;
            }
            else r = Math.Atan(b * b / (c * c + x * x));
            
            textBox4.Text = Convert.ToString(r);        

        }
    }
}
