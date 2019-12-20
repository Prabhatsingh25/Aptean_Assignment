using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class StringManipulation
    {
        public string FirstString, SecondString;
        public StringBuilder StringBuilderString;
        public StringManipulation()
        {
            Console.WriteLine("Please enter the first String");
            FirstString = Console.ReadLine();
            Console.WriteLine("Please enter the second String");
            SecondString = Console.ReadLine();
            StringBuilderString = new StringBuilder("StringBuilder", 100);
        }

        public int CountCapitalAndSmallCharA()
        {
            int sum = 0;
            for (int i = 0; i < FirstString.Length; i++)
            {
                if (FirstString[i] == 'a' || FirstString[i] == 'A')
                    sum++;
            }

            for (int i = 0; i < SecondString.Length; i++)
            {
                if (SecondString[i] == 'a' || SecondString[i] == 'A')
                    sum++;
            }
            return sum;
        }


        public void ModifyString()
        {
            FirstString = FirstString.Replace('a', '@');
            FirstString = FirstString.Replace('A', '@');
            SecondString = SecondString.Replace('a', '@');
            SecondString = SecondString.Replace('A', '@');
            Console.WriteLine("First String after Modification : "+FirstString);
            Console.WriteLine("Second String after Modification : " + SecondString);
        }

        public void StringInUpperCase()
        {
            FirstString = FirstString.ToUpper();
            SecondString = SecondString.ToUpper();
            Console.WriteLine("First String in Upper Case : " + FirstString);
            Console.WriteLine("Second String in Upper Case : " + SecondString);
        }

        public void ConcatStrings()
        {
            string NewString;
            NewString = FirstString + SecondString;
            Console.WriteLine("Concated String  : " + NewString);
        }

        public void OperationOnStringBuilder()
        {
            Console.WriteLine("String after Append operation on StringBuilder is : "
                +StringBuilderString.Append(" get appended"));
            Console.WriteLine("String after Insert operation on StringBuilder is : "
                + StringBuilderString.Insert(14," get Inserted "));
            Console.WriteLine("String after removing 'get' by Remove operation on StringBuilder is : "
                + StringBuilderString.Remove(28,3));
            Console.WriteLine("String after Replace operation on StringBuilder is : "
                + StringBuilderString.Replace("StringBuilder", "ReplaceStringBuilder"));


        }

        public static void Main(string[] args)
        {
            StringManipulation obj = new StringManipulation();
            Console.WriteLine("total no of captal 'A' and small 'a' is : " + obj.CountCapitalAndSmallCharA());
            obj.ModifyString();
            obj.StringInUpperCase();
            obj.ConcatStrings();
            obj.OperationOnStringBuilder();
            Console.Read();
        }
    }
}







