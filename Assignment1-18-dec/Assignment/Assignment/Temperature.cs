using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Temperature
    {
        int degree; 
        public Temperature()
        {
            Console.WriteLine("Please enter the degree");
            degree = int.Parse(Console.ReadLine());
        }

        public void TemperatureDetails()
        {
            if(degree > 32)
                Console.WriteLine("It is hot today");
            else if(degree == 32)
                Console.WriteLine("The temperature is 32");
            else
                Console.WriteLine("The climate is good today");
            
            Console.Read();
        }
        static void Main(string[] args)
        {
            Temperature obj = new Temperature();
            obj.TemperatureDetails();
        }



    }
}
