using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0123456789
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            textBox1.Text = "";
        }
        public int c01;
        public int c02;
        public int c21;
        public int sum;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btEnter_Click(object sender, EventArgs e)
        {
           








        }

        private void btadd_Click(object sender, EventArgs e)
        {
            label2.Text += "+";
            if (textBox2.Text!=" ") c01 = Convert.ToInt32(textBox2.Text);

            if (Convert.ToBoolean(c01)==true)
            {
                c02 = c01 + c02;

                textBox1.Text = Convert.ToString(c02);
                textBox2.Text = " ";

                label1.Text = "+";
                label2.Text += "true";
            }
            else
            {
                label2.Text += "false";
            }


        }
        
        private void btded_Click(object sender, EventArgs e)
        {
            label2.Text += "-";
            
            if (textBox2.Text != " ") c01 = Convert.ToInt32(textBox2.Text);

            if (Convert.ToBoolean(c01) == true)
            {
                if (Convert.ToInt32(c02)!=0)c02 = c02 - c01;
                else
                {
textBox1.Text = Convert.ToString(c01);
                textBox2.Text = " ";

                label1.Text = "-";
                label2.Text += "true";
                }
                
            }
            else
            {
                label2.Text += "false";
            }

        }

        private void btmulit_Click(object sender, EventArgs e)
        {
            
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
          
        }
                            
        private void bt00_Click(object sender, EventArgs e)
        {
            textBox2.Text += 00;
            label2.Text += 00;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            textBox2.Text += 0;
            label2.Text += 0;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            
            textBox2.Text += 1;
            label2.Text += 1;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            textBox2.Text += 2;
            label2.Text += 2;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            textBox2.Text += 3;
            label2.Text += 3;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            textBox2.Text += 4;
            label2.Text += 4;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            textBox2.Text += 5;
            label2.Text += 5;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            textBox2.Text += 6;
            label2.Text += 6;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            textBox2.Text += 7;
            label2.Text += 7;
        }
        
        private void bt8_Click(object sender, EventArgs e)
        {
            textBox2.Text += 8;
            label2.Text += 8;
        }
        
        private void bt9_Click(object sender, EventArgs e)
        {
            textBox2.Text += 9;
            label2.Text += 9;
        }

        private void btdot_Click(object sender, EventArgs e)
        {
            textBox2.Text += ".";
            label2.Text += ".";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
