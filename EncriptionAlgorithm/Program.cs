using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncryptionClass;




namespace EncriptionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to be encrypted:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter first key:");
            string publicKey = Console.ReadLine();
            Console.WriteLine("Enter second key:");
            string privateKey = Console.ReadLine();
            var encryption = new Encryption();
            var decryption = new Decryption(encryption);
            text = encryption.encrypt(text,publicKey,privateKey);
            Console.WriteLine($"Your encrypted text is:{text}");
            Console.WriteLine("Do you want to decrypt it again to see if it works properly?Type in the console \"Yes\" or \"No\".");
            string answer = Console.ReadLine().ToLower();
            CheckInput();
            while (answer != "yes"  && answer != "no")
            {
                
                Console.WriteLine("Invalid entry, please type \"yes\" or \"no\" only!");
                answer = Console.ReadLine().ToLower();
                CheckInput();
            }
            void CheckInput()
            {
                if (answer == "yes")
                {
                    text = decryption.decrypt(text, publicKey, privateKey);
                    Console.WriteLine($"Your text was ----> {text}");
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Thank you for using this awesome algorithm!");
                }
            }
        }     
    }
}

