using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RI_2
{
    class Termo
    {
        /*"Matriz de frequencia" desse termo, quantas vezes ele aparece em cada documento
         * os documentos vão de 1 a 6, então 7 posições (a zero fica inutilizada)*/
        public int[] frequenciaEmDoc = new int[info.numDocumentos+1];
        public string[] posicaoDocumento = new string[info.numDocumentos + 1]; // Armazena um string com a/s posição/ções onde o termo foi encontrado em cada documento (usado para granularidade fina)
        public double frequenciaInversa = 0;    // frequencia inversa do termo (total de documento/documentos em que ele aparece)
        public string palavra;  // a string do termo propriamente dita

        public Termo(string Palavra, int arquivo, int posicao)
        {
            /* Para criar um termo basta dizer a palavra e o arquivo onde ela foi inicialmente encontrada e em qual posicao do arquivo ela esta*/
            palavra = Palavra;
            frequenciaEmDoc[arquivo] = 1;
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                posicaoDocumento[i] = "";
            }
            novaPosicaoDoc(arquivo, posicao);
        }

        public void novaPosicaoDoc(int numDoc, int posicao)
        {
            if (posicaoDocumento[numDoc] != "")
                posicaoDocumento[numDoc] += ",";
            posicaoDocumento[numDoc] += posicao.ToString();
        }


        /// <summary>
        /// Gera um string com a granularidade moderada daquele termo (parte numerica)
        /// </summary>
        /// <returns>string tipo (6:1,2,3,4,5,6)</returns>
        public string GranularidadeModerada()
        {
            string granModerada = "";   //Recebe o string final
            int numDoc = 0;     // conta em quantos documentos o termo aparece
            for (int i = 1; i <= info.numDocumentos; i++) //percorre o vetor de frequencia
            {
                if (frequenciaEmDoc[i] != 0)    //Se for 0, significa que o termo nao existe naquele documento
                {   //Caso apareça
                    if (numDoc > 0)     // Se o termo já tiver aparecido em algum documento, coloque virgula antes do proximo
                        granModerada += ",";
                    granModerada += i;  // Adiciona o numero do documento na string da granularidade
                    numDoc++;   // Aumenta o numero de documentos que o termo aparece
                }
            }
            granModerada = "(" + numDoc + ":" + granModerada + ")";
            return granModerada;
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
            frequenciaInversa = Math.Log(1 + (info.numDocumentos*1.0 / Cont), 2);
            // A frequencia inversa é dada por essa formula log2(1 + total de doc/doc em que o termo aparece)
        }

        public string GranularidadeFina()
        {
            string granFina = "";
            int numDoc = 0;     // conta em quantos documentos o termo aparece
            for (int i = 1; i <= info.numDocumentos; i++) //percorre o vetor de frequencia
            {
                if (posicaoDocumento[i] != "")    //Se for 0, significa que o termo nao existe naquele documento
                {   //Caso apareça
                    if (numDoc > 0)     // Se o termo já tiver aparecido em algum documento, coloque virgula antes do proximo
                        granFina += ",";
                    granFina += "("+i+":"+posicaoDocumento[i]+")";  // Adiciona o numero do documento na string da granularidade
                    numDoc++;   // Aumenta o numero de documentos que o termo aparece
                }
            }
            granFina = "(" + numDoc + ":" + granFina + ")";
            return granFina;
        }
    }
}

