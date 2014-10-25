using System;
using System.Collections.Generic;

namespace TI_2
{
    internal class Dicionario
    {
       
        public Documento[] Docs;       //Armazena os documentos e suas propriedades
        public List<Termo> Vocabulario = new List<Termo>();        // Todos os termos distintos

        /// <summary>
        /// Responsável por gerir a lista de documentos, os termos do vocabulário e o modelo vetorial
        /// </summary>
        public Dicionario()
        {       
        }
      
        /// <summary>
        /// Calcula frequencia inversa dos termos entre os documentos.
        /// </summary>
        private void FreqInversa()
        {
            int Cont;   //Conta em quantos docs o termo aparece

            /*Para cada termo do vocabulário, 
             * percorrer o vetor de frequencia daquele termo 
             * e contar em quantos ele aparece (valor != 0)
             * depois de contar, calcula a frequencia inver sa usando aquela fórmula ali*/
            foreach (Termo T in Vocabulario)
            {
                Cont = 0;
                for (int i = 1; i <= info.numDocumentos; i++)
                {
                    if (T.frequenciaEmDoc[i] != 0)
                        Cont++;
                }
                //Fórmula da frequencia inversa
                T.frequenciaInversa = Math.Log(1 + (info.numDocumentos * 1.0 / Cont), 2);   
            }
        }

        /// <summary>
        /// Ordena o vocabulário por ordem alfabética de termos usando o método quick sort (personalizado)
        /// </summary>
        public void Ordenar()
        {
            Ordenar O = new Ordenar(); 
            O.Sort(ref Vocabulario, 0, Vocabulario.Count - 1); 
        }

        /// <summary>
        /// Calcula peso dos termos em cada documento de acordo com o modelo vetorial
        /// </summary>
        private void rotinaModeloVetorial()
        {
            FreqInversa();      //Calcula frequencia inversa geral dos termos
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                // Calcula o peso final para cada documento
                Docs[i].calculaPesos(Vocabulario);
            }
        }
    }
}


