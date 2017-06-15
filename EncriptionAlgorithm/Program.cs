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
            string text = Console.ReadLine();
            var encryption = new Encryption();
            var decryption = new Decryption();
            text = encryption.cipher0(text);
            Console.WriteLine(text);
            text = decryption.decypher0(text);
            Console.WriteLine("original text was -> "+text);
        }
    }
}
