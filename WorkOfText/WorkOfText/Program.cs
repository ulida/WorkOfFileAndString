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
            str.Close();

            
            using (StreamReader punctuation = new StreamReader(s)) 
            {
                string patternPuntuation = @"[[\](){}<>*_-]";
                var punctuation1 = Regex.Replace (s,patternPuntuation ," ");
                                              
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

            using (StreamReader ArraySort = new StreamReader(s))
            {
                Regex wordssort = new Regex(@"\b.*\b");
                MatchCollection matches2 = wordssort.Matches(s);
                string[] array = matches2(new char[ ], StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(array);//перевод строки в массив и вывод по алфовиту масива
                File.WriteAllText("output.txt", array.ToString());
            };
                                            

            Console.ReadLine();


        }
    }

}

