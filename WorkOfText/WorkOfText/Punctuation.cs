using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOfText
{
    class Punctuation
    {
        public static List<string> symbol;
        public void GetSymbol ()
        {
            symbol = new List<string>();
            string results = CleanerText.punctuation;
            Regex regex = new Regex(@"([,.!?])");
            MatchCollection matches = regex.Matches(results);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                symbol.Add(match.Value);
            }
            else
            {
                Console.WriteLine("No matches found");
            }
        }
    }
}
