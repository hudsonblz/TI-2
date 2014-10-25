using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TI_2
{
    class Hardworker
    {
        
        public event EventHandler<HardWorkerEventArgs> ProgressChanged;
        public event EventHandler HardWorkDone;
        public void DoHardWork()
        {
            DateTime CalcTempo = DateTime.Now;  //Usado para calcular tempo de leitura para estatísticas

            // para cada arquivo txt ele cria um novo objeto Documento
            // a criação do Documento envolve o processo de leitura, analise, e etc...
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                info.Vocab.Docs[i] = new Documento(i);    //Cria Documento 
                this.OnProgressChanged(i);
            }            
            Ordenar();      //Ordena o vocabulario com QuickSort

            info.palavrasVocab = info.Vocab.Vocabulario.Count;     //Estatística do número de palavras distintas no vocabulário

            
            TimeSpan tempoGasto = DateTime.Now - CalcTempo;         //Calcula tempo gasto na leitura e afins            
            info.tempoLerArquivos = tempoGasto;   // e envia o valor para estatísticas
       
            this.OnHardWorkDone();
        }

        /// <summary>
        /// Ordena o vocabulário por ordem alfabética de termos usando o método quick sort (personalizado)
        /// </summary>
        public void Ordenar()
        {
            Ordenar O = new Ordenar();
            O.Sort(ref info.Vocab.Vocabulario, 0, info.Vocab.Vocabulario.Count - 1);
        }
        private static string transformacaoLexica(string texto)
        {
            /* Remove cacaracteres especiais e pontuações */
            string[] charParaRemover = { "«", "»", "—", "’", ".", ",", ":", " - ", "(", ")", "!", "*", "_", ";", "=", "?", "<", ">", "[", "]", "\"", "'" };
            for (int i = 0; i < charParaRemover.Length; i++)
            {
                texto = texto.Replace(charParaRemover[i], "");
            }

            /* Substitui caracteres de escape por espaços */
            string[] outrosCaracteresEspeciais = { "\r\n", "^\\s+", "/", "\t", "\\s+$", "\\s+" };
            for (int i = 0; i < outrosCaracteresEspeciais.Length; i++)
            {
                texto = texto.Replace(outrosCaracteresEspeciais[i], " ");
            }

            /* Remove as stopwords que estão em um arquivo txt*/
            string[] stopwords = File.ReadAllText("stopwords.txt").Split(' ');
            for (int i = 0; i < stopwords.Length; i++)
            {
                texto = texto.Replace(" " + stopwords[i] + " ", " ");
            }

            texto = texto.ToLower();    // Transforma todo o texto em minúsculas
            return texto;
        }

        private void OnProgressChanged(int progress)
        {
            var handler = this.ProgressChanged;
            if (handler != null)
            {
                handler(this, new HardWorkerEventArgs(progress));
            }
        }
        private void OnHardWorkDone()
        {
            var handler = this.HardWorkDone;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
    public class HardWorkerEventArgs : EventArgs
    {
        public HardWorkerEventArgs(int progress)
        {
            this.Progress = progress;
        }
        public int Progress
        {
            get;
            private set;
        }
    }
}
