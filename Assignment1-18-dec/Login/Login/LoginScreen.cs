using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class LoginScreen
    {
        public string LoginId, Password;

        public LoginScreen()
        {
            LoginId = "BootCamp";
            Password = "hpel";
        }
        public void Login()
        {
            int count = 0;
            while(count<3)
            {
                Console.WriteLine("Enter LoginId and Password Please");
                string enterdLoginId,enterdPassword;
                enterdLoginId = Console.ReadLine();
                enterdPassword = Console.ReadLine();

                if (LoginId.Equals(enterdLoginId) && Password.Equals(enterdPassword))
                {
                    Console.WriteLine("Welcome to C# Applications");
                    Console.Read();
                    break;
                }
                else if (count < 3)
                {
                    Console.WriteLine("Invalid login");
                    count++;
                }
                else
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            LoginScreen obj = new LoginScreen();
            obj.Login();
        }
    }
}
