using System;
using System.Collections.Generic;
using System.IO;

namespace RI_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Menu Controla = new Menu();
            int opc = 0;
            do
            {
                opc = Controla.MenuInicial();
                if (opc == 1)
                {
                    info.contaDocumentos();
                    Console.WriteLine("\n Encontrados "+info.numDocumentos+" documentos");
                    Console.ReadKey();
                }
                else
                {
                    if (podeLer())
                        break;
                    else
                        opc = 1;
                }
            } while (opc == 1);           
            
            Dicionario D = new Dicionario();            
            D.Controle();    
        }

        static bool podeLer()
        {
            info.contaDocumentos();
            if (info.numDocumentos == 0)
            {
                Console.WriteLine("\n\n Não foi detectado nenhum documento");
                Console.ReadKey();
                return false;
            }
            return true;
        }


    }

}