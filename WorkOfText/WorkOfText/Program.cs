using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOfText
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkOfText text = new WorkOfText();
            text.ReadText();

            CleanerText clear = new CleanerText();
            clear.GetClearString();

            Sentences sente = new Sentences();
            sente.GetSenteces();

            Punctuation symbol = new Punctuation();
            symbol.GetSymbol();

            Console.WriteLine("\n The file is cleared, divided into sentences, words and punctuation marks ");
            
            CommonLetter letter = new CommonLetter();
            letter.Letter();
            Console.WriteLine("\n Recorded file with the output of words and their number ");


            Outputsentences sent = new Outputsentences();
            sent.LongSentence();
            sent.ShortSentence();
            sent.OutputSentences();
            Console.WriteLine("\n Recorded file with the output long and short sentence ");



            Console.ReadLine();


        }
    }

}

