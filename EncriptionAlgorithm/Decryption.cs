using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionClass
{
    class Decryption
    {
        private string sequence = "012345010310401505050104001410400130104041005040411313141314143145";
        private string secretKey = "!@!NMIE@J(9u8jOJIEo";
        private Encryption encryption;
        public  Decryption(Encryption encryption)
        {
            this.encryption = encryption;
        }
        public string decrypt(string text, string publicKey, string privateKey)
        {
            string secretKey = this.secretKey;
            publicKey = this.encryption.Cypher(publicKey, secretKey, publicKey, privateKey);
            privateKey = this.encryption.Cypher(privateKey, privateKey, publicKey, secretKey);
            secretKey = this.encryption.Cypher(secretKey, publicKey, privateKey, secretKey);
            foreach (var decypherNumber in ReverseText(this.sequence))
            {
                string decypherName = $"decypher{decypherNumber}";

                switch (decypherName)
                {
                    case "decypher0":
                        text = this.decypher0(text);
                        break;
                    case "decypher1":
                        text = this.decypher1(text);
                        break;
                    case "decypher2":
                        text = this.decypher2(text, publicKey, privateKey, secretKey);
                        break;
                    case "decypher3":
                        text = this.decypher3(text);
                        break;
                    case "decypher4":
                        text = this.decypher4(text,publicKey,privateKey, secretKey);
                        break;
                    case "decypher5":
                        text = this.decypher5(text);
                        break;
                    default:
                        throw new Exception("No such decypher found");
                }
                
            }
            return text;
        }

        private string decypher0(string text)
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
        private string decypher1(string text)
        {
            DecypherText();
            text = ReverseText(text);
            DecypherText();
            void DecypherText()
            {
                for (int k = text.Length - 1; k > 0; k--)
                {
                    string myNewText = "";
                    for (int y = 0; y < k; y++)
                    {
                        myNewText += text[y];
                    }
                    int myLetterASCII = (int)text[k - 1];
                    for (int i = k; i < text.Length; i++)
                    {
                        int currentLetterASCII = (int)text[i];
                        int newASCII = currentLetterASCII - myLetterASCII;
                        myNewText += (char)newASCII;
                    }
                    text = myNewText;
                }
            }
            return text;
        }
        private string decypher2(string text, string publicKey, string privateKey, string secretKey)
        {
            int textLength = text.Length;
            text = ReverseText(text);
            List<char> textAsList = text.ToList();
            int publicKeyLength = publicKey.Length;
            int privateKeyLength = privateKey.Length;
            int secretKeyLength = secretKey.Length;
            int actualTextLength = textLength - publicKeyLength - privateKeyLength - secretKeyLength;
            int insertIndex = (int)Math.Floor(actualTextLength / 3.0);

            for (int i = 0; i < publicKeyLength; i++)
            {
                textAsList.RemoveAt(insertIndex);
            }
            insertIndex++;
            for (int i = 0; i < privateKeyLength; i++)
            {
                textAsList.RemoveAt(insertIndex);
            }
            insertIndex++;
            for (int i = 0; i < secretKeyLength; i++)
            {
                textAsList.RemoveAt(insertIndex);
            }
            text = string.Join("", textAsList);
            text = ReverseText(text);
            return text;
        }
        private string decypher3(string text)
        {
            List<char> textAsList = text.ToList();
    
            string cypheredText = string.Join("",textAsList);
            int textLength = cypheredText.Length;
            bool isOdd = false;
            double counter = textLength / 2;
            if (textLength % 2 != 0)
            {
                counter = Math.Floor(counter);
                isOdd = true;
            }

            char[] decypherText = new char[textLength];
            decypherText[decypherText.Count() - 1] = cypheredText[0];
            decypherText[0] = cypheredText[1];

            int odd = 0;
            int shift = 0;
            if (isOdd){
                decypherText[(int)counter] = cypheredText[textLength - 1];
                odd = 1;
            }else{
                shift = 1;
            }
            int insertPosition = 1;

            for (int i = 2; i <textLength - 1 -odd;i += 2){
                int num = decypherText.Count() - 1 -odd -shift;
                decypherText[insertPosition] = cypheredText[i + 1];
                decypherText[decypherText.Count() - 1 -odd -shift] = cypheredText[i];
                shift += 1;
                insertPosition += 1;
            }
            text = string.Join("", decypherText);
            return text;

        }
        private string decypher4(string text,string publicKey, string privateKey, string secretKey)
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
                if (publicKeyIndex == publicKeyLength - 1) { publicKeyIndex = 0; }
                if (privateKeyIndex == privateKeyLength - 1) { privateKeyIndex = 0; }
                if (secretKeyIndex == secretKeyLength - 1) { secretKeyIndex = 0; }
                int letterASCII = (int)text[i];
                int newASCII = (int)(publicKey[publicKeyIndex]) + (int)(privateKey[privateKeyIndex]) + (int)(secretKey[secretKeyIndex]);
                muttableText[i] = (char)(text[i] - newASCII);
            }
            return muttableText.ToString();
        }
        private string decypher5(string text)
        {
            StringBuilder muttableText = new StringBuilder(text);
            int textLength = text.Length;
            for (int i = 0; i < textLength; i++)
            {
                int asciiChange = i + 1;
                int letterASCII = (int)text[i];
                letterASCII -= asciiChange;
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
