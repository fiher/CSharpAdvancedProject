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
            var decryption = new Decryption(encryption);
            text = encryption.encrypt(text,"WIWIJI@J*@U*@JI@OJ(@J(@JH","#J#H#H(@#(J@@JKMIJSI0fkfj9f");
            Console.WriteLine(text);
            text = decryption.decrypt(text, "WIWIJI@J*@U*@JI@OJ(@J(@JH", "#J#H#H(@#(J@@JKMIJSI0fkfj9f");
            Console.WriteLine($"original text was {text}");
        }
    }
}
