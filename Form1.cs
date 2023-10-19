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

            if (calc.CanDoNumber())
            {
                if (calc.isEqualClick)
                {
                    Result.Text = "";
                    Prev.Text = "";
                    calc.Clear();

                }
                Button button = (Button)sender;
                Result.Text = calc.DoNumber(button.Text);
            }
            

        }


        private void Oper_Click(object sender, EventArgs e)
        {
            if (calc.CanDoEqual()&&!calc.isEqualClick)
            {
                
                Result.Text = calc.DoEqual();
                
            }
            if (calc.CanPrintOper())
            {
                Button button = (Button)sender;


                Prev.Text = calc.PrintOper(button.Text);
                calc.num2 = Result.Text;
                calc.AutoNum2 = true;
            }
            

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (calc.CanDoEqual())
            {
                Prev.Text = calc.num1 + " " + calc.oper.ToString() + " " + calc.num2 + " " + "=";
                Result.Text = calc.DoEqual();
                if (Result.Text.Equals("Нельзя делить на 0"))
                {
                    Prev.Text = "";
                }
                
            }

            

        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if (calc.isEqualClick)
            {
                calc.Clear();
                Prev.Text = "";
                calc.num1 = "0";
            }
            
            if (calc.CanDoComma())
            {
                Result.Text = calc.DoComma();
            }
            
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (calc.CanDoDel(Result.Text))
            {
                Result.Text = calc.DoDel();
            }
            if (calc.isEqualClick)
            {
                calc.Clear();
                Prev.Text = "";
                Result.Text = "";
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
