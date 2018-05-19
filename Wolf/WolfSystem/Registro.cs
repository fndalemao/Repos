using System;
using WolfSystem.Equipamentos;
using System.Collections.Generic;
using System.Text;

namespace WolfSystem
{
    class Registro
    {
        static public void RegistrarEquipamento()
        {
            string eNSerie;
            string eFabricante;
            string eModelo;
            string eTipoEquip;
            string eSalvar;
            PainelLED regPainelLED = new PainelLED();

            Console.WriteLine("Selecione o tipo de equipamento: ");
            Console.WriteLine("");
            Console.WriteLine("1. Painel de LED");
            Console.WriteLine("2. Ribalta");
            Console.WriteLine("3. ParLED");
            eTipoEquip = Console.ReadLine();
            byte sTipoEquip = byte.Parse(eTipoEquip);
            if (sTipoEquip == 1)
            {
                Console.WriteLine("Digite o número de série do equipamento: ");
                eNSerie = Console.ReadLine();
                regPainelLED.nSerie = eNSerie;
                Console.WriteLine("Selecione o fabricante: ");
                Console.WriteLine("");
                Console.WriteLine("1. ABSEN LED");
                Console.WriteLine("2. NEW LED");
                eFabricante = Console.ReadLine();
                byte sFabricante = byte.Parse(eFabricante);
                if (sFabricante == 1)
                {
                    Console.WriteLine("Selecione o modelo: ");
                    Console.WriteLine("");
                    Console.WriteLine("1. 3 mm velho");
                    Console.WriteLine("2. 3 mm novo");
                    Console.WriteLine("3. 4 mm");
                    eModelo = Console.ReadLine();
                    regPainelLED.fabricante = "ABSEN LED";
                }
                if (sFabricante == 2)
                {
                    Console.WriteLine("Selecione o modelo: ");
                    Console.WriteLine("");
                    Console.WriteLine("1. 10 mm");
                    Console.WriteLine("2. 18 mm");
                    eModelo = Console.ReadLine();
                    regPainelLED.fabricante = "NEW LED";

                }
            }
            void Salvar()
            {
                Console.WriteLine("Deseja salvar?");
                Console.WriteLine("");
                Console.WriteLine("1. Sim");
                Console.WriteLine("2. Não");
                eSalvar = Console.ReadLine();
                byte sSalvar = byte.Parse(eSalvar);
                if (sSalvar == 1)
                {
                    Console.WriteLine("EQUIPAMENTO REGISTRADO!");
                }
                else
                {
                    string eCancel;
                    Console.WriteLine("Tem certeza que deseja cancelar?");
                    Console.WriteLine("");
                    Console.WriteLine("1. Sim");
                    Console.WriteLine("2. Não");
                    eCancel = Console.ReadLine();
                    byte sCancel = byte.Parse(eCancel);
                    if (sCancel == 1)
                    {
                        Console.WriteLine("INFORMAÇÕES DESCARTADAS!");
                    }
                    else
                    {
                        Salvar();
                    }
                }
            }
            Salvar();
            Console.ReadKey();
        }
    }
}
