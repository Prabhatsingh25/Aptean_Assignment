using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readonly
{
    class ReadonlyImplement
    {
        readonly string name = "Prabhat";
        int Age;
        public ReadonlyImplement()
        {
            Age = 23;
            Console.WriteLine("Name = "+name);
            name = "abc";           
            Console.WriteLine("If we update name in constructor we encounter with a Error.....!!!");
        }
        static void Main(string[] args)
        {
            ReadonlyImplement obj = new ReadonlyImplement();
            Console.Read();
        }
    }
}
