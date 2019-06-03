using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Test
{
    class CountingDigits : Ex04.Menus.Interfaces.Operations
    {
        public CountingDigits(Menu i_Parent, string i_Title) : base(i_Parent, i_Title)
        {

        }

        public override void ApplyOperation()
        {
            CountDigits();
        }
        internal void CountDigits()
        {
            string inputSentence = "";
            int numberOfDigits = 0;

            Console.WriteLine("Please enter a sentence");
            inputSentence = Console.ReadLine();
            foreach (char currLetterInSentence in inputSentence)
            {
                if(char.IsDigit(currLetterInSentence))
                {
                    numberOfDigits++;
                }
            }

            Console.WriteLine(string.Format("You have {0} number of digits in the inputted sentence.", numberOfDigits));
        }
        
    }
}
