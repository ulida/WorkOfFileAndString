using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOfText
{
    class Sentences
    {
        public static List<string> sentence;
        public void GetSenteces()
        {
            sentence = new List<string>();
            string results = CleanerText.punctuation;
            Regex sent = new Regex(@"[A-Za-z]+[^.!?]*[.!?]", RegexOptions.IgnoreCase);
            MatchCollection matches = sent.Matches(results);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    match.Value.Trim();
                    if (sent.IsMatch(match.Value) && (match.Value.Count() > 2))
                    {
                        sentence.Add(match.Value.Trim().Replace("/n", ""));
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("No matches found");
            }

          
        }



    } 
           
}
