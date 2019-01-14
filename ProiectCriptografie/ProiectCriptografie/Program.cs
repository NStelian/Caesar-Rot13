using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectCriptografie
{
    class Program
    {
        static void Main(string[] args)
        {
            string textClar = "Cainele face miau";
            Console.WriteLine("Text initial: Cainele face miau");

            Console.WriteLine("Caesar: "+Caesar.Criptare(textClar)+ " " + Caesar.Decriptare(Caesar.Criptare(textClar)));

            Console.WriteLine("Rot13: "+Rot13.Criptare(textClar) + " " + Rot13.Criptare(Rot13.Criptare(textClar)));

            Console.WriteLine("Caesar de n: "+CaesarN.Criptare(textClar) + " " + CaesarN.Decriptare(CaesarN.Criptare(textClar))+"\n ( n = "+ CaesarN.key+")");

            Console.ReadKey();
        }
    }
}
