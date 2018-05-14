using System;

namespace S2E1_EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, eIdade;                        

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            eIdade = Console.ReadLine();
            Console.WriteLine("==================================");
            byte sIdade = byte.Parse(eIdade);
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Você nasceu em: " + (DateTime.Now.Year - sIdade));
            Console.ReadKey();
        }
    }
}
