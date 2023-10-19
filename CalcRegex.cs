using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatorSmolkinaEV
{
    public class CalcRegex
    {
        private string patternSum = "[0-9]+,*[0-9]* \\+ [0-9]+,*[0-9]*";
        private string patternMinus = "[0-9]+,*[0-9]* \\- [0-9]+,*[0-9]*";
        private string patternDiv = "[0-9]+,*[0-9]* \\/ [0-9]+,*[0-9]*";
        private string patternMult = "[0-9]+,*[0-9]* x [0-9]+,*[0-9]*";
        private string patternNumber = "[0-9]+,*[0-9]*";
        private string input = "";
      

        private bool comma = false;
        private bool oper = false;
        private int count = 0;

        public string NumberClick(string oldstr,string str)
        {
            if (count < 16)
            {
                if (oper)
                {
                    oper = false;
                    return str;
                    
                }
               
                count++;
                return oldstr+str;
            }
            return "";
        }
        public string OperClick(string str)
        {
            if(oper)
            {
                return input;
            }
            input=str;
            oper = true;
            count = 0;  
            return input;
        }

        public string EqualClick(string str)
        {
            input += " " + str + " "+"= ";
            oper = false;
            return input;

        }
        private string sum()
        {
            Regex regex = new Regex(patternNumber);
            MatchCollection matches = regex.Matches(input);
            try
            {
                input = (int.Parse(matches[0].Value) + int.Parse(matches[1].Value)).ToString();
            }
            catch(Exception e)
            {
                input = (double.Parse(matches[0].Value) + double.Parse(matches[1].Value)).ToString();
            }
            
            return input;
        }
        private string minus()
        {
            Regex regex = new Regex(patternNumber);
            MatchCollection matches = regex.Matches(input);
            try
            {
                input = (int.Parse(matches[0].Value) - int.Parse(matches[1].Value)).ToString();
            }
            catch (Exception e)
            {
                input = (double.Parse(matches[0].Value) - double.Parse(matches[1].Value)).ToString();
            }

            return input;
        }
        private string div()
        {
            Regex regex = new Regex(patternNumber);
            MatchCollection matches = regex.Matches(input);
            if (matches[1].Value.Equals("0"))
            {
                return "Нельзя делить на ноль";
            }
            if (matches[0].Value.Contains(",") || matches[1].Value.Contains(','))
            {
                input = (double.Parse(matches[0].Value) / double.Parse(matches[1].Value)).ToString();
            }
            else
            {
                if (int.Parse(matches[0].Value) % int.Parse(matches[1].Value) == 0)
                {
                    input = (int.Parse(matches[0].Value) / int.Parse(matches[1].Value)).ToString();
                }
                else
                {
                    input = (double.Parse(matches[0].Value) / double.Parse(matches[1].Value)).ToString();
                }
            }
            return input;
        }
        private string mult()
        {
            Regex regex = new Regex(patternNumber);
            MatchCollection matches = regex.Matches(input);
            try
            {
                input = (int.Parse(matches[0].Value) * int.Parse(matches[1].Value)).ToString();
            }
            catch (Exception e)
            {
                input = (double.Parse(matches[0].Value) * double.Parse(matches[1].Value)).ToString();
            }

            return input;
        }
        public string DoPattern()
        {
            oper = false;
            comma = false;
            Regex regex = new Regex(patternSum);
            MatchCollection matches = regex.Matches(input);
            if(matches.Count > 0)
            {
                return sum();
            }
            regex = new Regex(patternMinus);
            matches= regex.Matches(input);
            if (matches.Count > 0)
            {
                return minus();
            }
            regex = new Regex(patternDiv);
            matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                return div();
            }
            regex = new Regex(patternMult);
            matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                return mult();
            }
            regex = new Regex(patternNumber);
            matches = regex.Matches(input);
            return matches[0].Value;

        }

    }
}
