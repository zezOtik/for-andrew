using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andrey3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1;
            string s2;

            s1 = "Step:" + "\n";
            s2 = "Answer:" + "\n";

            double A,X;
            X = - 0.25;
            A = 0.5*(Math.Pow(Math.Sin(X),2) - 1);
            s2 += A + "\n";
            int k = 0;
            s1 += k + "\n";


            while (Math.Round(A,3) != Math.Round(X,3))
            {
                X = A;
                A = 0.5 * (Math.Pow(Math.Sin(X), 2) - 1);
                k += 1;
                s1 += k + "\n";
                s2 += A + "\n";
            }

            richTextBox1.Text = Convert.ToString(s1);
            richTextBox2.Text = Convert.ToString(s2); 

        }
    }
}
