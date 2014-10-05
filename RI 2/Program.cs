using System;
using System.Collections.Generic;
using System.IO;

namespace RI_2
{
    class Program
    {
        public List<string> dicionario = new List<string>();

        private static void Main(string[] args)
        {
            DateTime Antes = DateTime.Now;
            Console.WriteLine("Começou!");
            info.contaDocumentos();
            Dicionario D = new Dicionario();
            //D.Controle("Vetorial");       //5
            //D.Controle("GranModerada");   //5
            D.Controle("GranFina");
            TimeSpan Time = DateTime.Now - Antes;
            Console.WriteLine("\nTempo gasto = "+Time.Seconds.ToString());
            Console.ReadKey();
        }
    }
     
}