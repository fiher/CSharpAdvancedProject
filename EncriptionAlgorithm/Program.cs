using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncriptionClass;




namespace EncriptionAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var encription = new Encription();
             text = encription.cipher0(text);
            Console.WriteLine(text);
        }
    }
}
