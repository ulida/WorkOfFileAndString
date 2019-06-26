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

            StreamReader str = new StreamReader(@"C:\C sharp\WorkOfText\WorkOfText\bin\Debug\text.txt");
            var s = str.ReadToEnd(); 
           

            
            using (StreamReader punctuation = new StreamReader(s)) 
            {
                string patternPuntuation = @"[[\](){}<>*_-]";
                var punctuation1 = Regex.Replace (s,patternPuntuation ," ");
                Console.WriteLine(s);
            };

            using (StreamReader words = new StreamReader(s))  
            {
                Regex word = new Regex(@"\b.*\b",RegexOptions.IgnoreCase);
                if (word.IsMatch(s))
                {
                    Console.WriteLine(word.Matches(s));
                }
                if (!word.IsMatch(s))
                {
                    Console.WriteLine("Exception");
                }
            };

            using (StreamReader sentences = new StreamReader(s))  
            {
                Regex sentence = new Regex(@"[A-Za-z]+[^.!?]*[.!?]", RegexOptions.IgnoreCase);
                if (sentence.IsMatch(s))
                {
                    Console.WriteLine(sentence.Matches(s));
                }
                if (!sentence.IsMatch(s))
                {
                    Console.WriteLine("Exception");
                }
                
            };

            using (StreamReader Wordcount = new StreamReader(s))
            {
                string[] inputSentence =s.Split();
                int count = 0;
                string pattern = @"(?:\b\w+\ \s|\S)*" + s + @"(?:\b\w+\b\ \s|\S)?";
                Regex rx = new Regex(pattern, RegexOptions.IgnoreCase);
                for (int i = 0; i < inputSentence.Length; i++)
                {
                    var mc = rx.Matches(inputSentence[i]); foreach (Match m in mc) { count++; }
                }
                Console.WriteLine("{0}", count);

            };
          
            str.Close();
            Console.ReadLine();


        }
    }

}

