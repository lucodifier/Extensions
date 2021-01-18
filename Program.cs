using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adicionando zeros a esquerda");
            var texto = "20";
            Console.WriteLine(AddZeroToLeft(texto, 5));
        }

        public static string AddZeroToLeft(string input, int lenght)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input = input.PadLeft(lenght, '0');
            }
            return input;
        }
    }
}