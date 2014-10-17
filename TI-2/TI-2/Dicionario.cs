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
            info.contaDocumentos();
            Docs = new Documento[info.numDocumentos + 1];
        }
      
        /// <summary>
        /// Lê os arquivos txt dos documentos e cria um objeto Documento paracada arquivo que fica guardados em Docs.
        /// Alimenta uma progress bar com o andamento da leitura.
        /// Calcula o tempo gasto na leitura para estatísticas.
        /// </summary>
        /// <param name="progressBar"></param>
        public void lerDocs(System.Windows.Forms.ProgressBar progressBar)
        {
            DateTime CalcTempo = DateTime.Now;  //Usado para calcular tempo de leitura para estatísticas

            progressBar.Maximum = info.numDocumentos+1; // Usados no controle da progressBar
            progressBar.Visible = true; 
            
            // para cada arquivo txt ele cria um novo objeto Documento
            // a criação do Documento envolve o processo de leitura, analise, e etc...
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                Docs[i] = new Documento(i, ref Vocabulario);    //Cria Documento 
                progressBar.PerformStep();      //Atualiza progressBar
            }            
            Ordenar();      //Ordena o vocabulario com QuickSort

            info.palavrasVocab = Vocabulario.Count;     //Estatística do número de palavras distintas no vocabulário

            progressBar.PerformStep();      //Termina uso da progressBar 
            progressBar.Visible = false;    // e esconde ela
            
            TimeSpan tempoGasto = DateTime.Now - CalcTempo;         //Calcula tempo gasto na leitura e afins            
            info.tempoLerArquivos = (int)tempoGasto.TotalSeconds;   // e envia o valor para estatísticas
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