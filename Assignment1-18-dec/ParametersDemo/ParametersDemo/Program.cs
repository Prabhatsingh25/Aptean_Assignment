using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersDemo
{
    class Program
    {
        public int Add, Subtract;
        public Program()
        {
            Add = 0;
            Subtract = 0;
        }
        static void Main(string[] args)
        {
            Calculator cal = new Calculator(1, 2);
            Program obj = cal.AddAndSubtract();
            Console.WriteLine(  "The Addition is "+ obj.Add);
            Console.WriteLine("The Subtraction is " + obj.Subtract);
            Console.Read();

        }
    }
}
