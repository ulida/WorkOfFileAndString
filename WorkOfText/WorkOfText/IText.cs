using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOfText
{
    interface IText
    {
       void ReadText();
       void OutputWord(string str, int count);
       void OutputSentence (string str, int count, string massage);


    }
}
