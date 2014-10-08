using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_2
{
    class Dicionario
    {
        public Documento[] Docs = new Documento[info.numDocumentos + 1];
        public List<Termo> Vocabulario = new List<Termo>();        // Todos os termos
        private Ordenar O = new Ordenar();

        public void lerDocs()
        {
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                Docs[i] = new Documento(i, ref Vocabulario);
            }
            Ordenar();
        }

        private void Ordenar()
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
    }
}
