using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {"João da Silva", "José da Costa", "Maria da Costa", "Fernando Gomes" };

            Console.WriteLine("Nome de N3: " + nomes[2]);
            nomes[2] = "Miguel da Costa";
            Console.WriteLine("Nome de N3: " + nomes[2]);
            Console.ReadKey();
        }
    }
}
