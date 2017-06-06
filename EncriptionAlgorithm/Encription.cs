using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncriptionClass
{
    public class Encription
    {
        public Encription()
        {
        }
        public string cipher0(string text)
        {
            int             textLength = text.Length;
            int             splitInto = 0;
            List<string> textAsList = new List<string>();
            SplitInto();
            List<string>    textBlocks = new List<string>();
            string          leftBlockOfText = "";
            int             startIndex = 0;
          
            char[]          letters = text.ToCharArray();
            Array.Reverse(letters);
            text = string.Join("", letters);
            for (int i = 0; i < splitInto; i++)
            {
                string textBlock = "";
                for (int k = 0; k < Math.Floor((textLength / splitInto) * 1.0); k++)
                {
                    textBlock += text[startIndex];
                    startIndex++;
                }
                textBlocks.Add(textBlock);
            }
            textBlocks.Reverse();
            foreach (var textBlock in textBlocks)
            {
                textAsList.Add(textBlock);
            }
            if (startIndex < textLength)
            {
                for (int i = startIndex; i < textLength; i++)
                {
                    leftBlockOfText += text[i];
                }
                textAsList.Add(leftBlockOfText);
            }
            return string.Join("", textAsList);
            int SplitInto()
            {
                if (textLength >= 5 && textLength < 10) { splitInto = 2; }
                else if (textLength < 15) { splitInto = 4; }
                else if (textLength < 20) { splitInto = 8; }
                else if (textLength < 30) { splitInto = 6; }
                else if (textLength < 35) { splitInto = 10; }
                else if (textLength < 45) { splitInto = 8; }
                else if (textLength < 50) { splitInto = 4; }
                else if (textLength < 60) { splitInto = 12; }
                else if (textLength < 70) { splitInto = 14; }
                else if (textLength < 80) { splitInto = 16; }
                else if (textLength < 90) { splitInto = 12; }
                else if (textLength < 100) { splitInto = 8; }
                else if (textLength < 120) { splitInto = 14; }
                else if (textLength < 150) { splitInto = 18; }
                else if (textLength < 160) { splitInto = 14; }
                else if (textLength < 180) { splitInto = 16; }
                else if (textLength < 190) { splitInto = 8; }
                else if (textLength < 200) { splitInto = 4; }
                else if (textLength < 240) { splitInto = 9; }
                else if (textLength < 280) { splitInto = 21; }
                else if (textLength < 290) { splitInto = 32; }
                else if (textLength < 300) { splitInto = 14; }
                else if (textLength < 320) { splitInto = 35; }
                else if (textLength < 340) { splitInto = 21; }
                else if (textLength < 356) { splitInto = 4; }
                else if (textLength < 456) { splitInto = 2; }
                else if (textLength < 500) { splitInto = 5; }
                else if (textLength < 550) { splitInto = 23; }
                else if (textLength >= 550) { splitInto = 40; }
                return splitInto;
            }
        }
    }
}