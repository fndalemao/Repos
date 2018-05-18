using System;
using WolfSystem.Equipamentos;
namespace WolfSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string eOpcao;            
            Console.WriteLine("===========Selecione uma opção abaixo=========== ");
            Console.WriteLine("");
            Console.WriteLine("1. Registrar equipamento.");
            Console.WriteLine("2. Check in de equipamento.");
            Console.WriteLine("3. Check out de equipamento.");
            Console.WriteLine("4. Manutenção de equipamento.");
            Console.WriteLine("");
            eOpcao = Console.ReadLine();
            byte opcao1 = byte.Parse(eOpcao);
            byte opcao2 = byte.Parse(eOpcao);
            byte opcao3 = byte.Parse(eOpcao);
            byte opcao4 = byte.Parse(eOpcao);
            if (opcao4 == 4) {
                Console.Clear();
                Manutencao.Equipamento();
            }

            Console.ReadKey();
        }
    }
}
