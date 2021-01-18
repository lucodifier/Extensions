using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicionando zeros a esquerda");
            var texto = "20";
            Console.WriteLine(texto.AddZeroToLeft(5));
        }

    }
}