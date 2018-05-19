using System;
using System.Collections.Generic;
using System.Text;

namespace WolfSystem
{
    class Manutencao
    {
        static public void Equipamento()
        {
            string eNSerie;            
            string eReparo;
            Console.WriteLine("Digite o número de série do equipamento");
            eNSerie = Console.ReadLine();
            int sNSerie = int.Parse(eNSerie);
            Console.WriteLine("O equipamento foi reparado?");
            Console.WriteLine("");
            Console.WriteLine("1. Sim");
            Console.WriteLine("2. Não");
            eReparo = Console.ReadLine();
            byte sReparo = byte.Parse(eReparo);
            if (sReparo == 1)
            {
                Console.WriteLine("EQUIPAMENTO ENCAMINHADO PARA ESTOQUE!");
            }
            else
            {
                Console.WriteLine("EQUIPAMENTO ENCAMINHADO PARA SUCATA!");
            }
            Console.ReadKey();
        }
    }
}
