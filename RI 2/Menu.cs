using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RI_2
{
    class Menu
    {
        public void Cabecalho ()
        {
            Console.Clear();
            Console.WriteLine("\t EXERCICIO DO CAMILO\n");
        }

        public int MenuInicial ()
        {
            Cabecalho();
            int opc=0;
            Console.WriteLine(" Operacoes iniciais: ");
            Console.WriteLine(" 1 Checar numero de documentos ");
            Console.WriteLine(" 2 Ler documentos e formar vocabulario ");
            Console.Write(" \n Opcao: ");
            try
            {
                opc = int.Parse(Console.ReadLine());
                if (opc >= 1 && opc <= 2)
                    return opc;
                else
                {
                    Console.Write(" Opcao invalida  ");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.Write(" Opcao invalida  ");
                Console.ReadKey();
            }
            return MenuInicial();
        }

        public int MenuOperacoes()
        {
            Cabecalho();
            int opc = 0;
            Console.WriteLine(" Operacoes iniciais: ");
            Console.WriteLine(" 1 Obter pesos no para modelo vetorial ");
            Console.WriteLine(" 2 Obter indice de granularidade moderada ");
            Console.WriteLine(" 3 Obter indice de granularidade fina ");
            Console.WriteLine(" 4 Obter transposicao da matriz de frequencia");
            Console.WriteLine(" 5 Calcular ganho da utilização de blocos de memória em vez de linked lists");
            Console.Write(" \n Opcao: ");
            try
            {
                opc = int.Parse(Console.ReadLine());
                if (opc >= 1 && opc <= 5)
                    return opc;
                else
                {
                    Console.Write(" Opcao invalida  ");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.Write(" Opcao invalida  ");
                Console.ReadKey();
            }
            return MenuOperacoes();
        }
    }


}
