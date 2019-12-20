using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Acronym
    {
        string Sentence;
        string AcronmyOfString ="";
        string NormalSentence ="";

        public Acronym()
        {
            Console.WriteLine("Enter the Sentence");
            Sentence = Console.ReadLine();
        }

       
        public void FindAcronmy()
        {
            
            int i, j = 1;
            AcronmyOfString  += NormalSentence[0];
            for (i=1;i<NormalSentence.Length;i++)
            {
                if(NormalSentence[i] ==' ')
                {
                    
                    AcronmyOfString += NormalSentence[i+1];
                    j++;
                }
            }
          
        }
        public void GetAcronmy()
        {
            Console.WriteLine("The Acronmy of the givven Sentence is :");
            Console.WriteLine(AcronmyOfString.ToUpper());
        }

        public void RemoveSpecialCharacter()
        {
            int j = 0;
            for (int i = 0; i < Sentence.Length; i++)
            {
                if ((Sentence[i] >= 'A' && Sentence[i] <= 'Z') || (Sentence[i] >= 'a' && Sentence[i] <= 'z') || Sentence[i]==' ')
                {
                    NormalSentence += Sentence[i];
                    j++;
                }
        }
    }

    

    static void Main(string[] args)
        {
            Acronym obj = new Acronym();
            obj.RemoveSpecialCharacter();
            obj.FindAcronmy();
            obj.GetAcronmy();
            Console.Read();
        }
    }
}
