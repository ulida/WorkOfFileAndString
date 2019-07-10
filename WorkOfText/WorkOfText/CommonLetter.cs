using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WorkOfText
{
    class CommonLetter
    {
        public static List<string> word;

        WorkOfText text = new WorkOfText();
        public int value;
        public string key;
        public void Letter()
        {
            Dictionary<string, int> CommonLetter = new Dictionary<string, int>();
            CommonLetter.Add("A", CleanerText.punctuation.Count(x => x == 'A'));
            CommonLetter.Add("B", CleanerText.punctuation.Count(x => x == 'B'));
            CommonLetter.Add("C", CleanerText.punctuation.Count(x => x == 'C'));
            CommonLetter.Add("D", CleanerText.punctuation.Count(x => x == 'D'));
            CommonLetter.Add("E", CleanerText.punctuation.Count(x => x == 'E'));
            CommonLetter.Add("F", CleanerText.punctuation.Count(x => x == 'F'));
            CommonLetter.Add("G", CleanerText.punctuation.Count(x => x == 'G'));
            CommonLetter.Add("H", CleanerText.punctuation.Count(x => x == 'H'));
            CommonLetter.Add("I", CleanerText.punctuation.Count(x => x == 'I'));
            CommonLetter.Add("J", CleanerText.punctuation.Count(x => x == 'J'));
            CommonLetter.Add("K", CleanerText.punctuation.Count(x => x == 'K'));
            CommonLetter.Add("L", CleanerText.punctuation.Count(x => x == 'L'));
            CommonLetter.Add("M", CleanerText.punctuation.Count(x => x == 'M'));
            CommonLetter.Add("N", CleanerText.punctuation.Count(x => x == 'N'));
            CommonLetter.Add("O", CleanerText.punctuation.Count(x => x == 'O'));
            CommonLetter.Add("P", CleanerText.punctuation.Count(x => x == 'P'));
            CommonLetter.Add("Q", CleanerText.punctuation.Count(x => x == 'Q'));
            CommonLetter.Add("R", CleanerText.punctuation.Count(x => x == 'R'));
            CommonLetter.Add("S", CleanerText.punctuation.Count(x => x == 'S'));
            CommonLetter.Add("T", CleanerText.punctuation.Count(x => x == 'T'));
            CommonLetter.Add("U", CleanerText.punctuation.Count(x => x == 'U'));
            CommonLetter.Add("V", CleanerText.punctuation.Count(x => x == 'V'));
            CommonLetter.Add("W", CleanerText.punctuation.Count(x => x == 'W'));
            CommonLetter.Add("X", CleanerText.punctuation.Count(x => x == 'X'));
            CommonLetter.Add("Y", CleanerText.punctuation.Count(x => x == 'Y'));
            CommonLetter.Add("Z", CleanerText.punctuation.Count(x => x == 'Z'));

            CommonLetter.Add("a", CleanerText.punctuation.Count(x => x == 'a'));
            CommonLetter.Add("b", CleanerText.punctuation.Count(x => x == 'b'));
            CommonLetter.Add("c", CleanerText.punctuation.Count(x => x == 'c'));
            CommonLetter.Add("d", CleanerText.punctuation.Count(x => x == 'd'));
            CommonLetter.Add("e", CleanerText.punctuation.Count(x => x == 'e'));
            CommonLetter.Add("f", CleanerText.punctuation.Count(x => x == 'f'));
            CommonLetter.Add("g", CleanerText.punctuation.Count(x => x == 'g'));
            CommonLetter.Add("h", CleanerText.punctuation.Count(x => x == 'h'));
            CommonLetter.Add("i", CleanerText.punctuation.Count(x => x == 'i'));
            CommonLetter.Add("j", CleanerText.punctuation.Count(x => x == 'j'));
            CommonLetter.Add("k", CleanerText.punctuation.Count(x => x == 'k'));
            CommonLetter.Add("l", CleanerText.punctuation.Count(x => x == 'l'));
            CommonLetter.Add("m", CleanerText.punctuation.Count(x => x == 'm'));
            CommonLetter.Add("n", CleanerText.punctuation.Count(x => x == 'n'));
            CommonLetter.Add("o", CleanerText.punctuation.Count(x => x == 'o'));
            CommonLetter.Add("p", CleanerText.punctuation.Count(x => x == 'p'));
            CommonLetter.Add("q", CleanerText.punctuation.Count(x => x == 'q'));
            CommonLetter.Add("r", CleanerText.punctuation.Count(x => x == 'r'));
            CommonLetter.Add("s", CleanerText.punctuation.Count(x => x == 's'));
            CommonLetter.Add("t", CleanerText.punctuation.Count(x => x == 't'));
            CommonLetter.Add("u", CleanerText.punctuation.Count(x => x == 'u'));
            CommonLetter.Add("v", CleanerText.punctuation.Count(x => x == 'v'));
            CommonLetter.Add("w", CleanerText.punctuation.Count(x => x == 'w'));
            CommonLetter.Add("x", CleanerText.punctuation.Count(x => x == 'x'));
            CommonLetter.Add("y", CleanerText.punctuation.Count(x => x == 'y'));
            CommonLetter.Add("z", CleanerText.punctuation.Count(x => x == 'z'));

            var val = CommonLetter.Values.Max();

            foreach (var item in CommonLetter)
            {
                if (item.Value == val)
                {
                    value = item.Value;
                    key = item.Key.ToString();
                }
                else
                {
                    continue;
                }
            }
            text.OutputSentence(key, value, "The most common letter");

        }
    }
}