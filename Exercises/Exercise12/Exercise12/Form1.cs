using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise12
{
    public partial class Form1 : Form
    {
        char opt;
        bool optEngajed = false;
        bool equalEngajed = false;
        bool numEngajed = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '9';
            numEngajed = true;
        }
         
        private void button8_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '8';
            numEngajed = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '7';
            numEngajed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '6';
            numEngajed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '5';
            numEngajed = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '4';
            numEngajed = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '3';
            numEngajed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '2';
            numEngajed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '1';
            numEngajed = true;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (equalEngajed)
            {
                textBox1.Text = "";
                equalEngajed = false;
            }
            textBox1.Text += '0';
            numEngajed = true;
        }

        private void dividButton_Click(object sender, EventArgs e)
        {
            if ((!optEngajed && numEngajed) || equalEngajed)
            {
                textBox1.Text += "÷";
                opt = '÷';
                optEngajed = true;
                numEngajed = false;
                equalEngajed = false;
            }

        }

        private void multiButton_Click(object sender, EventArgs e)
        {
            if ((!optEngajed && numEngajed) || equalEngajed)
            {
                textBox1.Text += "×";
                opt = '×';
                optEngajed = true;
                numEngajed = false;
                equalEngajed = false;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if ((!optEngajed && numEngajed) || equalEngajed)
            {
                textBox1.Text += "+";
                opt = '+';
                optEngajed = true;
                numEngajed = false;
                equalEngajed = false;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if ((!optEngajed && numEngajed) || equalEngajed)
            {
                textBox1.Text += "-";
                opt = '-';
                optEngajed = true;
                numEngajed = false;
                equalEngajed = false;
            }

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if(optEngajed)
            {
                string[] numsString = textBox1.Text.Split(opt);
                int[] nums = new int[numsString.Length];
                double result = 0;
                for (int i = 0; i < numsString.Length; i++)
                    nums[i] = int.Parse(numsString[i]);
                switch (opt)
                {
                    case ('-'):
                        result = nums[0] - nums[1];
                        break;
                    case ('+'):
                        result = nums[0] + nums[1];
                        break;
                    case ('÷'):
                        result = nums[0] / nums[1];
                        break;
                    case ('×'):
                        result = nums[0] * nums[1];
                        break;
                }
                textBox1.Text = result.ToString();
                equalEngajed = true;
                numEngajed = false;
                optEngajed = false;
                opt = ' ';
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (optEngajed)
                {
                    optEngajed = false;
                    opt = ' ';
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            optEngajed = false;
            opt = ' ';
            numEngajed = false;
            equalEngajed = false;
        }
    }
}
