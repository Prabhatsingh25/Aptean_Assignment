using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detail
{
    class Building
    {
        public int occupants, floors,area;
        public Building(int occupants, int floors,int area)
        {
            this.occupants = occupants;
            this.floors = floors;
            this.area = area;
        }
        public int Area()
        {
            return area;
        }
        static void Main(string[] args)
        {
            Building house = new Building(4,2,2500);
            Console.WriteLine("Area of House = " + house.Area());
            Console.WriteLine("occupants of House = " +house.occupants);
            Console.WriteLine("floors of House = " + house.floors);
            Console.WriteLine("Area per person in House is = "+ house.Area()/house.occupants);


            Building office = new Building(25,3,4200);
            Console.WriteLine("Area of Office = " + office.Area());
            Console.WriteLine("occupants of Office = " + office.occupants);
            Console.WriteLine("floors of Office = " + office.floors);
            Console.WriteLine("Area per person in House is = " + office.Area() / office.occupants);
            Console.Read();
        }
    }
}
