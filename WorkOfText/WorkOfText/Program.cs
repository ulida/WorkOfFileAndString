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
            string text;
            using (StreamReader file = new StreamReader(@"C:\C sharp\WorkOfText\WorkOfText\bin\Debug\text.txt"))
            {
                text = file.ReadToEnd();
            };
                                    
            string patternPuntuation = @"[[\](){}<>*_-\\]";
            var punctuation = Regex.Replace (text, patternPuntuation, "");
            Console.WriteLine(text);
                         
            using (StreamReader outputwords = new StreamReader(text))  
            {
                Regex word = new Regex(@"\b\w*\b",RegexOptions.IgnoreCase);
                if (word.IsMatch(text))
                {
                    foreach(char words in text)
                    {
                        Console.WriteLine(word.Matches(text));
                    }
                                
                }
                if (!word.IsMatch(text))
                {
                    Console.WriteLine("Exception");
                }
            };

            using (StreamReader outputsentences = new StreamReader(text))  
            {
                Regex sentence = new Regex(@"[A-Za-z]+[^.!?]*[.!?]", RegexOptions.IgnoreCase);
                if (sentence.IsMatch(text))
                {
                    Console.WriteLine(sentence.Matches(text));
                }
                if (!sentence.IsMatch(text))
                {
                    Console.WriteLine("Exception");
                }
                
            };
            
            using (StreamReader Wordcount = new StreamReader(text))
            {
                string[] inputSentence =text.Split();
                int count = 0;
                string pattern = @"(?:\b\w+\ \s|\S)*" + text + @"(?:\b\w+\b\ \s|\S)?";
                Regex rx = new Regex(pattern, RegexOptions.IgnoreCase);
                for (int i = 0; i < inputSentence.Length; i++)
                {
                    var mc = rx.Matches(inputSentence[i]); foreach (Match m in mc) { count++; }
                }
                Console.WriteLine("{0}", count);

            };
         
            Console.ReadLine();


        }
    }

}

