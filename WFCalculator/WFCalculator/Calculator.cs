using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn0.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbResult.Text += btn9.Text;
        }



        private void btnDot_Click(object sender, EventArgs e)
        {
            txbResult.Text += btnDot.Text;
        }

        string CalResult;
        string option;
        int num1;
        int num2;
        int result;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txbResult.Text);

            txbResult.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txbResult.Text);

            txbResult.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txbResult.Text);

            txbResult.Clear();
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txbResult.Text);

            txbResult.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txbResult.Text);

            int Calculator()
            {
                if (option == "+")
                {
                    result = num1 + num2;
                }
                if (option == "-")
                {
                    result = num1 + num2;
                }
                if (option == "*")
                {
                    result = num1 + num2;
                }
                if (option == "/")
                {
                    result = num1 + num2;
                }

                return result;
            }

            txbResult.Clear();

            txbResult.Text = Calculator().ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txbResult.Clear();
            //num1 = 0;
            //num2 = 0;
            //result = 0;
        }
    }
}
