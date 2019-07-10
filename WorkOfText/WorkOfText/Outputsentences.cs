using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOfText
{
    class Outputsentences
    {
        WorkOfText text = new WorkOfText();
        string Shortsentence;
        string LongestSentence;
        int count = 1;
        string sentenceoutput = @"longandshortsentence.txt";

        List<string> sentences = Regex.Split("", @"(?<=[\.!\?])\s+").ToList();
               
        public string LongSentence()
        {
            foreach (var item in sentences)
            {
                if (item.Length > count) LongestSentence = item;count = item.Length;
            }
            return LongestSentence;
        }

        public string ShortSentence()
        {
            foreach (var item in sentences)
            {
                if (item.Length < count) Shortsentence = item; count = item.Length;
            }
            return Shortsentence;
        }

        public void OutputSentences()
        {
            using (StreamWriter Sentences = new StreamWriter(sentenceoutput, true))
            {
                Sentences.WriteLine("The shortest sentence in the text :", Shortsentence);
                Sentences.WriteLine(new string('-', 10));
                Sentences.WriteLine("The longest sentence in the text :", LongestSentence);
            }
        }
        







    }
}
