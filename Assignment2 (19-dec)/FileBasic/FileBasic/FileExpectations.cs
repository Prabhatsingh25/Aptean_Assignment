using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileBasic
{

    class FileExpectations
    {

        string FileName = "";

        public void CreateFile()
        {
            FileName = "";
            Console.WriteLine("enter file name to create");
            string fname = Console.ReadLine();
            FileName += ConfigurationManager.AppSettings["root"].ToString() + fname +
                ConfigurationManager.AppSettings["extension"].ToString();


            // Create a new file     
            StreamWriter sw = new StreamWriter(FileName);
            // To write on the console screen 
            Console.WriteLine("Enter the Text that you want to write on File");

            // To read the input from the user 
            string str = Console.ReadLine();

            // To write a line in buffer 
            sw.WriteLine(str);

            // To write in output stream 
            sw.Flush();

            // To close the stream 
            sw.Close();

        }

        public void DeleteFile()
        {
            Console.WriteLine("enter the file name to delete");
            string fname = Console.ReadLine();

            FileName = "";
            try
            {
                FileName += ConfigurationManager.AppSettings["root"].ToString() + fname +
                ConfigurationManager.AppSettings["extension"].ToString();
                Console.WriteLine(FileName);
                if (File.Exists(FileName))
                    File.Delete(FileName);
                else
                    throw new FileNotFoundException();

            }
            catch (Exception)
            {
                Console.WriteLine("File Does not Exist");
            }

        }


        public int CountWordFromFile(string name)
        {

            FileName = name;

            StreamReader sr = new StreamReader(FileName);

            int counter = 0;
            string delim = " ,."; //maybe some more delimiters like ?! and so on
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();//each time you read a line you should split it into the words
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length; //and just add how many of them there is
            }


            sr.Close();
            //Console.WriteLine("The word count is {0}", counter);
            return counter;
        }

        public void CountWordFromAllFile()
        {
            int TotalWord = 0;

            string[] files = Directory.GetFiles(@"C:\Dir\");

            foreach (string file in files)
            {
               // Console.WriteLine(file);
                TotalWord += CountWordFromFile(file);
            }
            Console.WriteLine(TotalWord);

        }
        static void Main(string[] args)
        {

            FileExpectations obj = new FileExpectations();
            char choice = new char();
            do
            {
                Console.WriteLine("               Select an option:");
                Console.WriteLine("1.Add new file to collection");
                Console.WriteLine("2.Delete a given file from collection");
                Console.WriteLine("3.Count of words in a file");
                Console.WriteLine("4.Count of words in all files");


                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                            obj.CreateFile();
                            break;
                    case 2:
                            obj.DeleteFile();
                            break;
                    case 3:
                            string name = "";
                            Console.WriteLine("Please enter the file name");
                            string fname = Console.ReadLine(); 
                            name += ConfigurationManager.AppSettings["root"].ToString() + fname +
                            ConfigurationManager.AppSettings["extension"].ToString();
                            Console.WriteLine("The word count is {0}", obj.CountWordFromFile(name));
                            break;
                    case 4:
                            Console.WriteLine("Total Word in all the files are ");
                            obj.CountWordFromAllFile();
                            break;
                    default: break;
                }
                Console.WriteLine(" Do you want to exit !!  (Y/N)");
                choice = char.Parse(Console.ReadLine());
            } while (choice != 'Y');


            Console.Read();


        }
    }


}


