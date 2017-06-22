using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionClass
{
    public class Encryption
    {
        private string sequence = "013452014131514143141541001031034012301034104011031045040104043210103013013405043040500341131141515405";
        private string secretKey = "!@!NMIE@J(9u8jOJIEomdoni";
        
        public string encrypt(string text, string publicKey, string privateKey)
        {
           
            foreach (var cypherNumber in this.sequence)
            {
                string cypherName = $"cypher{cypherNumber}";

                switch (cypherName)
                {
                    case "cypher0":
                        text = this.cypher0(text);
                        break;
                    case "cypher1":
                        text = this.cypher1(text);
                        break;
                    case "cypher2":
                        text = this.cypher2(text, publicKey, privateKey, this.secretKey);
                        break;
                    case "cypher3":
                        text = this.cypher3(text);
                        break;
                    case "cypher4":
                        text = this.cypher4(text, publicKey, privateKey, this.secretKey);
                        break;
                    case "cypher5":
                        text = this.cypher5(text);
                        break;
                    default:
                        throw new Exception("No such cypher found");
                }
            }
            
            return text;
        }

        private string cypher0(string text)
        {
            int textLength = text.Length;
            int splitInto = 0;
            List<string> textAsList = new List<string>();
            SplitInto();
            List<string> textBlocks = new List<string>();
            string leftBlockOfText = "";
            int startIndex = 0;

            text = ReverseText(text);
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
        private string cypher1(string text)
        {
            CypherText();
            text = ReverseText(text);
            CypherText();
            return text;
            void CypherText()
            {
                for (int k = 0; k < text.Length; k++)
                {
                    string myNewText = "";
                    if (k > 0)
                    {
                        for (int y = 0; y < k; y++)
                        {
                            myNewText += text[y];
                        }

                    }
                    myNewText += text[k];
                    int myLetterASCII = (int)text[k];
                    for (int i = k + 1; i < text.Length; i++)
                    {
                        int currentLetterASCII = (int)text[i];
                        int newASCII = myLetterASCII + currentLetterASCII;
                        myNewText += (char)newASCII;
                    }
                    text = myNewText;
                }
            }
        }
        private string cypher2(string text, string publicKey, string privateKey, string secretKey)
        {
            int textLegnth = text.Length;
            int insertIndex = (int) Math.Floor(textLegnth / 3.0);
            text = ReverseText(text);
            List<char> textAsList = text.ToList();
            int publicKeyLength = publicKey.Length;
            int privateKeyLength = privateKey.Length;
            int secretKeyLength = secretKey.Length;
            for (int i = 0; i < publicKeyLength; i++)
            {
                textAsList.Insert(insertIndex, publicKey[i]);
            }
            insertIndex++;
            for (int i = 0; i < privateKeyLength; i++)
            {
                textAsList.Insert(insertIndex+ publicKeyLength, privateKey[i]);
            }
            insertIndex++;
            for (int i = 0; i < secretKeyLength; i++)
            {
                textAsList.Insert(insertIndex + publicKeyLength + privateKeyLength, secretKey[i]);
            }
            text = string.Join("", textAsList);
            text = ReverseText(text);
            return text;
        }
        private string cypher3(string text)
        {

            int  textLength = text.Length;
            List<char> cypheredText = new List<char>();
            bool isOdd = false;
            double counter = textLength / 2;
            if(textLength%2 != 0)
            {
                counter = Math.Floor(counter);
                isOdd = true;
            }

            for (int i = 0; i < counter; i++) {
                cypheredText.Add(text[textLength - 1 - i]);
                cypheredText.Add(text[i]);
            }
            
            if (isOdd){
                cypheredText.Add(text[(int)counter]);
            }
            text = string.Join("", cypheredText);
            return text;
        }
        private string cypher4(string text, string publicKey, string privateKey,string secretKey)
        {
            StringBuilder muttableText = new StringBuilder(text);
            int textLength = text.Length;
            int publicKeyLength = publicKey.Length;
            int publicKeyIndex = 0;
            int privateKeyLength = privateKey.Length;
            int privateKeyIndex = 0;
            int secretKeyLength = secretKey.Length;
            int secretKeyIndex = 0;
            for (int i = 0; i < textLength; i++)
            {
                if(publicKeyIndex == publicKeyLength - 1) { publicKeyIndex = 0; }
                if(privateKeyIndex == privateKeyLength - 1) { privateKeyIndex = 0; }
                if(secretKeyIndex == secretKeyLength - 1) { secretKeyIndex = 0; }
                int letterASCII = (int)(text[i]);
                int newASCII = (int)(publicKey[publicKeyIndex]) + (int)(privateKey[privateKeyIndex]) + (int)(secretKey[secretKeyIndex]);
                muttableText[i] = (char)(letterASCII + newASCII);
            }
            return muttableText.ToString();
        }
        private string cypher5(string text)
        {
            StringBuilder muttableText = new StringBuilder(text);
            int textLength = text.Length;
            for (int i = 0; i < textLength; i++)
            {
                int asciiChange = i + 1;
                int letterASCII = (int)text[i];
                letterASCII += asciiChange;
                muttableText[i] = (char)letterASCII;
            }
            return muttableText.ToString();
        }
        private string ReverseText(string text)
        {
            char[] letters = text.ToCharArray();
            Array.Reverse(letters);
            text = string.Join("", letters);
            return text;
        }
    }
}