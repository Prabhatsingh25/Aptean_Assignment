using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersDemo
{
    class Calculator
    {
        public int FirstIntegerValue, SecondIntegerValue;
        public Calculator(int FirstValue,int SecondValue)
        {
            FirstIntegerValue = FirstValue;
            SecondIntegerValue = SecondValue;
        }
        public Program AddAndSubtract()
        {
            Program obj = new Program();
            obj.Add = FirstIntegerValue + SecondIntegerValue;
            obj.Subtract = Math.Abs(FirstIntegerValue - SecondIntegerValue);
            return obj;

        }
    }
}
