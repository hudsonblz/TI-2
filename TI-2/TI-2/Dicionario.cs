using System;
using System.Collections.Generic;

namespace TI_2
{
    internal class Dicionario
    {
        public Documento[] Docs;
        public List<Termo> Vocabulario = new List<Termo>();        // Todos os termos
        private Ordenar O = new Ordenar();

        public Dicionario()
        {
            info.contaDocumentos();
            Docs = new Documento[info.numDocumentos + 1];
        }
      
        public void lerDocs(System.Windows.Forms.ProgressBar progressBar)
        {
            DateTime CalcTempo = DateTime.Now;
            progressBar.Visible = true;
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                Docs[i] = new Documento(i, ref Vocabulario);
                progressBar.PerformStep();
            }            
            Ordenar();
            info.palavrasVocab = Vocabulario.Count;
            progressBar.PerformStep();
            progressBar.Visible = false;
            TimeSpan tempoGasto = DateTime.Now - CalcTempo;
            info.tempoLerArquivos = (int)tempoGasto.TotalSeconds;
        }

        private void FreqInversa()
        {
            int Cont;
            foreach (Termo T in Vocabulario)
            {
                Cont = 0;
                for (int i = 1; i <= info.numDocumentos; i++)
                {
                    if (T.frequenciaEmDoc[i] != 0)
                        Cont++;
                }
                T.frequenciaInversa = Math.Log(1 + (info.numDocumentos * 1.0 / Cont), 2);
            }
        }

        public void Ordenar()
        {
            Termo[] AuxOrdenar = new Termo[Vocabulario.Count];
            Vocabulario.CopyTo(AuxOrdenar);
            O.Sort(ref AuxOrdenar, 0, AuxOrdenar.Length - 1);
            Vocabulario.Clear();
            Vocabulario.AddRange(AuxOrdenar);
        }

        private void rotinaModeloVetorial()
        {
            FreqInversa();
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                Docs[i].calculaPesos(Vocabulario);
            }
        }
    }
}