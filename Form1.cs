using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SN_380
{
    public partial class Form1 : Form
    {
        double a;
        double b;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button2.Text;
            label1.Text += button2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button6.Text;
            label1.Text += button6.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button15.Text;
            label1.Text += button15.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button20.Text;
            label1.Text += button20.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button7.Text;
            label1.Text += button7.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button14.Text;
            label1.Text += button14.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button19.Text;
            label1.Text += button19.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button8.Text;
            label1.Text += button8.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button13.Text;
            label1.Text += button13.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            textBox1.Text += button18.Text;
            label1.Text += button18.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
            label1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            b = double.Parse(textBox1.Text);
            double result;
            if(sign == "+")
            {
                result = a + b;
                textBox1.Text = result.ToString();
            }
            if(sign =="-")
            {
                result = a - b;
                textBox1.Text = result.ToString();
            }
            if (sign == "x")
            {
                result = a * b;
                textBox1.Text = result.ToString();
            }
            if (sign == "/")
            {
                if (b == 0)
                {
                    MessageBox.Show("Can't not devide by 0");
                }
                else
                {
                    result = a / b;
                    textBox1.Text = result.ToString();
                }
            }
            textBox2.Text += Environment.NewLine + label1.Text + "=" + textBox1.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            sign = "+";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text += button28.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            sign = "-";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text += button29.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            sign = "x";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text += button30.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sign = "/";
            a = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text += button5.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Remove(textBox1.Text.Length - 1);
            }
            if (label1.Text == "")
            {
                label1.Text = "0";
            }    
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            }
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(textBox1.Text) * (-1.0);
            textBox1.Text = System.Convert.ToString(x);
            label1.Text = System.Convert.ToString(x);
        }

        private void button16_Click(object sender, EventArgs e)
        { 
            double x;
            x = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "";
            label1.Text += "1/" + x;
            textBox1.Text += 1 / x;
            textBox2.Text += Environment.NewLine + label1.Text + "=" + textBox1.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double x;
            x = double.Parse(textBox1.Text);
            label1.Text = "³√" + x;
            textBox1.Text = Math.Cbrt(x).ToString();
            textBox2.Text += Environment.NewLine + label1.Text + "=" + textBox1.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double x;
            x = double.Parse(textBox1.Text);
            label1.Text = x + "³";
            textBox1.Text = Math.Pow(x, 3).ToString();
            textBox2.Text += Environment.NewLine + label1.Text + "=" + textBox1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double x;
            x = double.Parse(textBox1.Text);
            label1.Text = x + "²";
            textBox1.Text = Math.Pow(x, 2).ToString();
            textBox2.Text += Environment.NewLine + label1.Text + "=" + textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double x;
            x = double.Parse(textBox1.Text);
            label1.Text = "²√" + x;
            textBox1.Text = Math.Sqrt(x).ToString();
            textBox2.Text += Environment.NewLine + label1.Text + "=" + textBox1.Text;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = "HISTORY:";
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll_2(object sender, ScrollEventArgs e)
        {
            
        }
    }
}
