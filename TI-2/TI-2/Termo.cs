using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_2
{
    class Termo
    {
        /*"Matriz de frequencia" desse termo, quantas vezes ele aparece em cada documento
         * os documentos vão de 1 a 6, então 7 posições (a zero fica inutilizada)*/
        public int[] frequenciaEmDoc = new int[info.numDocumentos + 1];
        public double frequenciaInversa = 0;    // frequencia inversa do termo (total de documento/documentos em que ele aparece)
        public string palavra;  // a string do termo propriamente dita

        public Termo(string Palavra, int arquivo, int posicao)
        {
            /* Para criar um termo basta dizer a palavra e o arquivo onde ela foi inicialmente encontrada e em qual posicao do arquivo ela esta*/
            palavra = Palavra;
            frequenciaEmDoc[arquivo] = 1;           
        }

        /// <summary>
        /// Usa a formula dada e calcula a frequencia inversa do termo
        /// </summary>
        private void FreqInversa()
        {
            int Cont;
            Cont = 0;
            for (int i = 1; i <= info.numDocumentos; i++)
            {   // Conta em quantos documentos o termo aparece
                if (frequenciaEmDoc[i] != 0)
                    Cont++;
            }
            frequenciaInversa = Math.Log(1 + (info.numDocumentos * 1.0 / Cont), 2);
            // A frequencia inversa é dada por essa formula log2(1 + total de doc/doc em que o termo aparece)
        }
    }
}
