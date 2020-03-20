using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite o seu nome:");
            string nome = Console.ReadLine();
             Console.WriteLine (nome.ToUpper());
        }
    }
}
