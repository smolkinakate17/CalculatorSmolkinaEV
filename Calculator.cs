using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSmolkinaEV
{
    public class Calculator
    {
        #region private fields
        private string _num1 = "";
        private string _num2 = "";
        private char? _oper = null;
        private bool _comma = false;
        private string _result = "";
        private bool _isEqualClick = false;
        private int _count;
        #endregion

        #region public fields
        public string num1
        {

            get { return _num1; }
        }

        public string num2
        {

            get { return _num2; }
        }

        public char? oper
        {

            get { return _oper; }
        }



        public bool isEqualClick
        {
            get { return _isEqualClick; }
            set { _isEqualClick = value; }
        }

        #endregion

        #region private func return bool (checks)
        private bool CanDoDel(string str)
        {
            return !str.Equals("");
        }
        private bool IsFirstNumber()
        {
            return _oper == null;
        }

        private bool CanDoNumber()
        {
            return _count < 13;
        }


        private bool CanPrintOper()
        {
            return _num1 != "" && _oper == null;
        }
        private bool CanDoComma()
        {
            if (!(_num1.Contains(",") && _num2.Contains(",")) && _count < 13)
            {
                _comma = true;
                return true;
            }
            return false;
        }
        private bool CanDoOper()
        {
            return !(_oper == null);
        }
        private bool CanDoEqual()
        {
            return _num1 != "" && _num2 != "";
        }
        #endregion

        #region private void func for arithmetic operations
        private void sum()
        {
            if (_num1.Contains(",") || _num2.Contains(","))
            {
                _result = (double.Parse(_num1) + double.Parse(_num2)).ToString();
            }
            else
            {
                try
                {
                    _result = (int.Parse(_num1) + int.Parse(_num2)).ToString();
                }
                catch (Exception e)
                {
                    _result = (double.Parse(_num1) + double.Parse(_num2)).ToString();
                }
            }
        }
        private void minus()
        {
            if (_num1.Contains(",") || _num2.Contains(","))
            {
                _result = (double.Parse(_num1) - double.Parse(_num2)).ToString();
            }
            else
            {
                try
                {
                    _result = (int.Parse(_num1) - int.Parse(_num2)).ToString();
                }
                catch (Exception e)
                {
                    _result = (double.Parse(_num1) - double.Parse(_num2)).ToString();
                }

            }
        }
        private void div()
        {
            if (!_num2.Equals("0"))
            {
                if (_num1.Contains(",") || _num2.Contains(","))
                {
                    _result = (double.Parse(_num1) / double.Parse(_num2)).ToString();
                }
                else
                {
                    if ((int.Parse(_num1) % int.Parse(_num2)) != 0)
                    {
                        _result = (double.Parse(_num1) / double.Parse(_num2)).ToString();
                    }
                    else
                    {
                        try
                        {
                            _result = (int.Parse(_num1) / int.Parse(_num2)).ToString();
                        }
                        catch (Exception e)
                        {
                            _result = (double.Parse(_num1) / double.Parse(_num2)).ToString();
                        }
                    }

                }
            }
            else
            {
                Clear();
                _result = "Нельзя делить на 0";
            }
        }
        private void mult()
        {
            if (_num1.Contains(",") || _num2.Contains(","))
            {
                _result = (double.Parse(_num1) * double.Parse(_num2)).ToString();
            }
            else
            {
                try
                {
                    _result = (int.Parse(_num1) * int.Parse(_num2)).ToString();
                }
                catch (Exception ex)
                {
                    _result = (double.Parse(_num1) * double.Parse(_num2)).ToString();
                }

            }
        }
        private string Del(string str)
        {
            return str.Substring(0, str.Length - 1);
        }
        #endregion

        #region public func
        public string DoNumber(string str)
        {
            if (_isEqualClick)
            {
                Clear();

            }
            if (CanDoNumber())
            {
                _count++;
                if (IsFirstNumber())
                {
                    _num1 += str;
                    return _num1;
                }
                else
                {
                    _num2 += str;
                    return _num2;
                }
            }
            else
            {
                if (IsFirstNumber())
                {
                    return _num1;
                }
                else
                {
                    return _num2;
                }

            }

        }
        public string PrintOper(string str)
        {
            string number = _num1;
            Clear();
            _num1 = number;
            if (CanPrintOper())
            {
                if (_isEqualClick)
                {
                    _isEqualClick = false;
                }
                _oper = char.Parse(str);
                _comma = false;
                _count = 0;
                return _num1 + " " + _oper.ToString() + " ";
            }
            else
            {
                return " ";
            }
        }

        public string DoEqual()
        {
            if (CanDoEqual())
            {
                DoOper();
                if (_result.Equals("Нельзя делить на 0"))
                {
                    Clear();
                    _isEqualClick = true;
                    return "Нельзя делить на 0";

                }
                else
                {
                    string res = _result;
                    string number2 = _num2;
                    char? operat = _oper;
                    Clear();
                    _isEqualClick = true;
                    _num2 = number2;
                    _oper = operat;
                    _num1 = res;
                    return res;
                }
            }
            else
            {
                if (!_num1.Equals(""))
                {
                    _isEqualClick = true;
                    return _num1;
                }
                return "";
            }
        }

        public string DoComma()
        {
            if (CanDoComma())
            {
                if (IsFirstNumber())
                {
                    _num1 += ",";
                    return _num1;
                }
                else
                {
                    _num2 += ",";
                    return _num2;
                }
            }
            else
            {
                if (IsFirstNumber())
                {
                    return _num1;
                }
                else
                {
                    return _num2;
                }
            }
        }

        public string DoDel(string str)
        {
            if (CanDoDel(str))
            {
                if (_isEqualClick)
                {
                    Clear();
                    return "";
                }
                else
                {
                    if (IsFirstNumber())
                    {
                        _num1 = Del(_num1);
                        return _num1;
                    }
                    else
                    {
                        _num2 = Del(_num2);
                        return _num2;
                    }
                }

            }
            else
            {
                return "";
            }

        }
        public void DoOper()
        {
            if (CanDoOper())
            {
                switch (_oper)
                {
                    case '+': sum(); break;
                    case '-': minus(); break;
                    case '/': div(); break;
                    case 'x': mult(); break;
                    default: break;
                }
            }


        }

        public string DoC()
        {
            Clear();
            return "";
        }

        public string DoCE()
        {
            if (IsFirstNumber())
            {
                return "";
            }
            else
            {
                if (_isEqualClick)
                {
                    Clear();
                    _isEqualClick = true;
                    return "";
                }
                else
                {
                    _num2 = "";
                    return "";
                }
            }
        }
        #endregion
        private void Clear()
        {
            _num1 = "";
            _num2 = "";
            _count = 0;
            _oper = null;
            _result = "0";
            _isEqualClick = false;
            _comma = false;
        }
    }
}
