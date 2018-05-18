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
            bool s;
            bool n;
            Console.WriteLine("Digite o número de série do equipamento");
            eNSerie = Console.ReadLine();
            int sNSerie = int.Parse(eNSerie);
            Console.WriteLine("O equipamento foi reparado? (s/n)");
            eReparo = Console.ReadLine();
            s = true;
            n = false;
            
            Console.ReadKey();
        }
    }
}
