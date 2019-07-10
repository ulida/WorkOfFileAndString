using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOfText
{
    class CleanerText
    {
        public static string punctuation;
        WorkOfText t = new WorkOfText();
        string text;
        public void GetClearString()
        {
            string patternPuntuation = @"[[[\]\(\)\{\}\<\>\_\\\n\=\+\;\:\*\-]";
            punctuation = Regex.Replace(text, patternPuntuation, "");
           
            
        }
    }
}
