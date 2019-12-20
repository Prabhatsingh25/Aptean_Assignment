using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorConfiger
{
  
    class Color
    {
        public string HexCode, RgbCode;
        int R=0, G=0, B=0;
        public string RR, GG, BB;


        public Color()
        {

        }
        public void EnterHexCode()
        {
            Console.WriteLine("Enter HEX Code: ");
            HexCode = Console.ReadLine();
        }

        public void EnterRgbCode()
        {

            Console.WriteLine("Enter Red component: ");
            R = int.Parse(Console.ReadLine());
            RR = DecimalToHexadecimal(R);
            Console.WriteLine("Enter Green component: ");
            G = int.Parse(Console.ReadLine());
            GG = DecimalToHexadecimal(G);
            Console.WriteLine("Enter Blue component: ");
            B = int.Parse(Console.ReadLine());
            BB = DecimalToHexadecimal(B);

        }
        public void GetHexCode()
        {
            Console.WriteLine(HexCode);
            
        }
        public void GetRgbCode()
        {
            if (R.Equals(0))
            {  
                Console.WriteLine("There is no rgb value");
                return;
            }
            Console.WriteLine(RR+","+GG+","+BB);
        }

        public void GetRedComponent()
        {
            
            Console.WriteLine(RR);
        }

        public void GetGreenComponent()
        {
            //GG = DecimalToHexadecimal(G);
            Console.WriteLine(GG);
        }
        public void GetBlueComponent()
        {
            //BB = DecimalToHexadecimal(B);
            Console.WriteLine(BB);
        }

        public string DecimalToHexadecimal(int dec)
        {
            if (dec <= 0)
                return "00";

            int hex = dec;
            string hexStr = string.Empty;

            while (dec > 0)
            {
                hex = dec % 16;

                if (hex < 10)
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString());
                else
                    hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString());

                dec /= 16;
            }

            return hexStr;
        }



        static void Main(string[] args)
        {
            Color obj = new Color();

            int ModeInput=1,choice=0;
            do
            {
                if(ModeInput==1)                                     // update when user press 7. Try another color 
                {
                    Console.WriteLine("Select any one of them");
                    Console.WriteLine("1.	HEX Code");
                    Console.WriteLine("2.	RGB Code");
                    int Input = int.Parse(Console.ReadLine());
                    if(Input==1)
                    {
                        obj.EnterHexCode();
                    }
                    else
                    {
                        obj.EnterRgbCode();
                    }
                    ModeInput = 0;

                }

                Console.WriteLine("Select any one from the following");
                Console.WriteLine("1.	Get HEX code");
                Console.WriteLine("2.	Get RGB code ");
                Console.WriteLine("3.	Get Red component ");
                Console.WriteLine("4.	Get Blue component ");
                Console.WriteLine("5.	Get Green component ");
                Console.WriteLine("6.	Get color's common name");
                Console.WriteLine("7.	Try another color");
                Console.WriteLine("8.	Exit");

                int Select = int.Parse(Console.ReadLine());
                switch(Select)
                {
                    case 1:
                            obj.GetHexCode();
                            break;
                    case 2: 
                            obj.GetRgbCode();
                            break;
                    case 3: obj.GetRedComponent();
                            break;
                    case 4: obj.GetGreenComponent();
                            break;
                    case 5: obj.GetBlueComponent();
                            break;
                    case 6: break;
                    case 7: ModeInput = 1;
                            break;
                    case 8: choice = 1;
                            break;
                    default: Console.WriteLine("select the correct option");
                             break;

                }

            } while (choice != 1);

        }
    }
}
