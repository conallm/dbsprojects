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
        bool newNumber = true;
        char op=' ';
        public Form1()
        {
            InitializeComponent();
        }

        private decimal evaluate(decimal op2)
        {
            decimal result;
            switch (op)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case ' ':
                    result = op2;
                    break;
                default:
                    throw new NotImplementedException();
            }
            newNumber = true;
            return result;
        }
        private void equals_Click(object sender, EventArgs e)
        {
            decimal op2 = decimal.Parse(textBox1.Text);
            decimal result = evaluate(op2);
            textBox1.Text = "" + result;
            op = ' ';


        }
        private void addDigit(char c)
        {
            //if (textBox1.Text == "0") 
            if (newNumber)
            {
                textBox1.Text = "";
                if(c!='0')
                    newNumber = false;
            }
            textBox1.Text += c;

        }
        private void setOperator(char v)
        {
            op1 = evaluate(decimal.Parse(textBox1.Text));
            op = v;
            textBox1.Text = ""+op1;
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
