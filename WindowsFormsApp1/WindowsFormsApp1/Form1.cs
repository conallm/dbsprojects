using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        decimal op1;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private decimal evaluate(decimal op3)
        {
            decimal result;
            switch (op)
            {
                case '+':
                    result = op1 + op3;
                    break;
                default:
                    throw new NotImplementedException();
            }
            return result;
        }
        private void equals_Click(object sender, EventArgs e)
        {
            decimal op2 = decimal.Parse(textBox1.Text);
            switch (op)
            {
                case '+':
                    decimal result = op1 + op2;
                    textBox1.Text = "" + result;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
        private void addDigit(char c)
        {
            if (textBox1.Text == "0") textBox1.Text = "" + c;
            textBox1.Text += c;

        }
        private void setOperator(char v)
        {
            op = v;
            op1 = decimal.Parse(textBox1.Text);
            textBox1.Text = "";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            addDigit('7');
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addDigit('8');
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addDigit('9');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addDigit('1');
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += '0';
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "2";
            textBox1.Text += '2';
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            setOperator('+');
        }



        private void btn3_Click(object sender, EventArgs e)
        {
            addDigit('3');
        }



        private void btn6_Click(object sender, EventArgs e)
        {
            addDigit('6');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addDigit('5');
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addDigit('4');
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf('.') < 0)
            {
                if (textBox1.Text == "") textBox1.Text = "0";
                textBox1.Text += '.';
            }
        }


    }
}
