using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionClass
{
    class Decryption
    {
        public string decypher0(string text)
        {
            int textLength = text.Length;
            int splitInto = 0;
            SplitInto();
            List<string> textAsList = new List<string>();
            List<string> textBlocks = new List<string>();
            string leftBlockOfText = "";
            int startIndex = 0;
            for (int i = 0; i < splitInto; i++)
            {
                string textBlock = "";
                for (int y = 0; y < Math.Floor((textLength / splitInto) * 1.0); y++)
                {
                    textBlock += text[startIndex];
                    startIndex++;
                }
                textBlocks.Add(textBlock);
            }
            textBlocks.Reverse();
            foreach(var textBlock in textBlocks)
            {
                textAsList.Add(textBlock);
            }
            if (startIndex <textLength){
                for (int i = startIndex;i <textLength;i++){
            leftBlockOfText += text[i];
                }
            textAsList.Add(leftBlockOfText);
            }
            text = string.Join("", textAsList);
            text = ReverseText(text);
            return text;

            void SplitInto()
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
            }
        }
        public string decypher1(string text)
        {
            DecypherText();
            text = ReverseText(text);
            DecypherText();
            void DecypherText()
            {
                for (int k = text.Length-1; k > 0; k--)
                {
                    string myNewText = "";
                        for (int y = 0; y < k; y++)
                        {
                            myNewText += text[y];
                        }
                    int myLetterASCII = (int)text[k-1];
                    for (int i = k ; i < text.Length; i++)
                    {
                        int currentLetterASCII = (int)text[i];
                        int newASCII =currentLetterASCII - myLetterASCII;
                        myNewText += (char)newASCII;
                    }
                    text = myNewText;
                }
            }
            return text;
        }
        public string ReverseText(string text)
        {
            char[] letters = text.ToCharArray();
            Array.Reverse(letters);
            text = string.Join("", letters);
            return text;
        }
    }
}
