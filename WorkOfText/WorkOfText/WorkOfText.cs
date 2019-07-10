using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOfText
{
    class WorkOfText : IText
    {
        string readplace = @"text.txt";
        string wordoutput = @"word.txt";
        string sentenceoutput = @"sentence.txt";
        public static string text;
        public DateTime dateTime;
        public string name;
        public void ReadText()
        {
            using (StreamReader file = new StreamReader(readplace))
            {
                text = file.ReadToEnd();
            };

        }
        public void OutputWord(string str, int count)
        {
            using (StreamWriter Wordcount = new StreamWriter(wordoutput, true))
            {
                string[] inputSentence = text.Split();
                string pattern = @"(?:\b\w+\ \s|\S)*" + text + @"(?:\b\w+\b\ \s|\S)?";
                Regex rx = new Regex(pattern, RegexOptions.IgnoreCase);
                for (int i = 0; i < inputSentence.Length; i++)
                {
                    var mc = rx.Matches(inputSentence[i]); foreach (Match m in mc) { count++; }
                }
                Wordcount.WriteLine("{0}", count);

            }
        }
        public void OutputSentence(string str, int count, string massage)
        {
            using (StreamWriter OutputSentence = new StreamWriter(sentenceoutput, true))
            {
                OutputSentence.WriteLine(massage);
                OutputSentence.WriteLine($"String - {str}");
                OutputSentence.WriteLine($"Count  - {count}");
               
             };

           
        }


    }
}
