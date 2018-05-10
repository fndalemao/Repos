using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ConversaoTextoParaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumeroTexto = "30";
            int Numero1 = int.Parse(NumeroTexto);
            int Numero2 = 30;

            Console.Write("O resultado é: " + (Numero1 + Numero2));
            Console.ReadKey();

        }
    }
}
