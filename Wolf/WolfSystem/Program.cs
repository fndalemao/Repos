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
            byte sOpcao = byte.Parse(eOpcao);
            
            if (sOpcao == 1)
            {
                Console.Clear();
                Registro.RegistrarEquipamento();
            }
            if (sOpcao == 4) {
                Console.Clear();
                Manutencao.Equipamento();
            }

            Console.ReadKey();
        }
    }
}
