using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSmolkinaEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator calc=new Calculator();

        private void NumberClick(object sender, EventArgs e)
        {
            if (calc.isEqualClick)
            {
                Result.Text = "";
                Prev.Text = "";

            }
            Button button = (Button)sender;
            Result.Text = calc.DoNumber(button.Text);

        }


        private void Oper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Prev.Text = calc.PrintOper(button.Text);
            if (!Prev.Text.Equals(""))
            {
                Result.Text = "";
            }

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Prev.Text = calc.num1 + " " + calc.oper.ToString();
            Result.Text = calc.DoEqual();
            if (Result.Text.Equals("Нельзя делить на 0"))
            {
                Prev.Text = "";
            }
            else if (calc.num2.Equals(""))
            {
                Prev.Text += "=";
                Result.Text = calc.num1;
            }
            else
            {
                Prev.Text += calc.num2 + "=";
            }

        }

        private void Comma_Click(object sender, EventArgs e)
        {
            Result.Text = calc.DoComma();
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            Result.Text = calc.DoDel(Result.Text);

            if (Result.Text.Equals(""))
            {
                Prev.Text = "";

            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            Result.Text = calc.DoC();
            Prev.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Result.Text = calc.DoCE();
            if (calc.isEqualClick)
            {
                Prev.Text = "";
                calc.isEqualClick = false;
            }

        }
    }
}
