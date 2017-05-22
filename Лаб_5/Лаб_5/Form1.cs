using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1;
            s1 ="Ответ:" + "\n";

            string s2;
            s2 = "Ответ:" + "\n";

            double x = -2;

            while (x <= 6)
            {
                double znachfunc = 0;

                if (x < 0)
                {
                    znachfunc = Math.Abs(x);
                }

                if (x == 0 || (x > 0 && x <= 5))
                {
                    znachfunc = 5 * Math.Exp(x);
                    znachfunc = Math.Round(znachfunc, 2);
                }

                if (x > 5)
                {
                    znachfunc = 2 * Math.Sin(x);
                    znachfunc = Math.Round(znachfunc, 2);
                }

                s1 += x + "\n";
                s2 += znachfunc + "\n";

                x += 0.5;
            }
            

            richTextBox1.Text = Convert.ToString(s1);
            richTextBox2.Text = Convert.ToString(s2); 


        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
