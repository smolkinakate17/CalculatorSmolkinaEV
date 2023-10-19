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
        private string _num1 = "0";
        private string _num2 = "0";
        private char? _oper = null;
        private bool _comma = false;
        private string _result = "";
        private bool _isEqualClick = false;
        private int _count;
        private bool autoNum2 = false;
        #endregion

        #region public fields
        public bool AutoNum2
        {
            get { return autoNum2; }
            set { autoNum2 = value; }
        }
        public string num1
        {

            get { return _num1; }
            set { _num1 = value; }
        }

        public string num2
        {

            get { return _num2; }
            set { _num2 = value; }  
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

        #region public func return bool (checks)
        public bool CanDoDel(string str)
        {
            return !str.Equals("");
        }
        public bool IsFirstNumber()
        {
            return _oper == null;
        }

        public bool CanDoNumber()
        {
            return _count < 13;
        }


        public bool CanPrintOper()
        {
            
            if (_num1.Contains(","))
            {
                int index = _num1.IndexOf(",");
                if(num1.Substring(index + 1).Equals(""))
                {
                    return false;
                }
            }
            if (_isEqualClick)
            {
                _isEqualClick = false;
                _oper = null;
            }
            return _num1 != "" && _oper == null;
        }
        public bool CanDoComma()
        {
            if (!(_comma) && _count < 13)
            {
                if(IsFirstNumber()&&_num1.Equals(""))
                {
                    return false;
                }
                if (!IsFirstNumber() && _num2.Equals(""))
                {
                    return false;
                }
                
                _comma = true;
                return true;
            }
            return false;
        }
        public bool CanDoOper()
        {
            return !(_oper == null);
        }
        public bool CanDoEqual()
        {
            if (_num2.Contains(","))
            {
                int index = _num2.IndexOf(",");
                if (num2.Substring(index + 1).Equals(""))
                {
                    return false;
                }
            }
            return _num1 != "" && _num2 != "" && _oper!=null;
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
            _count++;
            if (IsFirstNumber())
            {
                if (_num1.Equals("0"))
                {
                    _num1 = "";
                }
                _num1 += str;
                return _num1;
            }
            else
            {
                if (autoNum2)
                {
                    _num2 = "";
                    autoNum2 = false;
                }
                _num2 += str;
                return _num2;
            }

            

        }
        public string PrintOper(string str)
        {
            _oper = char.Parse(str);
            isEqualClick = false;
            _comma = false;
            _count = 0;
            return _num1 + " " + str + " ";

            
            
        }

        public string DoEqual()
        {
            DoOper();
            _comma = false;
            _count = 0;
            if (_result.Equals("Нельзя делить на 0"))
            {
                Clear();
                _isEqualClick = true;
                return "Нельзя делить на 0";
            }
            _isEqualClick = true;
            _num1 = _result;
            return _result;
                

        }

        public string DoComma()
        {

            if (IsFirstNumber())
            {
                _num1 += ",";
                return _num1;
            }
            else
            {
                if (autoNum2)
                {
                    _num2 = "0";
                    autoNum2 = false;
                }
                _num2 += ",";
                return _num2;
            }


        }

        public string DoDel()
        {

            if (_isEqualClick)
            {
                Clear();
                _isEqualClick = true;
                return "";
            }
            if (IsFirstNumber())
            {
                _num1 = Del(_num1);
                return _num1;
            }
            _num2 = Del(_num2);
            return _num2;
           

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
        public void Clear()
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
