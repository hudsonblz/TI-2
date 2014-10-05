using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RI_2
{
    class Dicionario
    {
        public Documento[] Docs = new Documento[info.numDocumentos+1];

        public List<Termo> Vocabulario = new List<Termo>();

        // Todos os termos
        private Ordenar O = new Ordenar();
        
        public void Controle(string tipo)
        {
            if (tipo == "GranFina")
                for (int i = 1; i <= info.numDocumentos; i++)
                {
                    Docs[i] = new Documento(i, ref Vocabulario, true);
                }
            else
                for (int i = 1; i <= info.numDocumentos; i++)
                {
                    Docs[i] = new Documento(i, ref Vocabulario, false);
                }
            Termo[] AuxOrdenar = new Termo[Vocabulario.Count];
            Vocabulario.CopyTo(AuxOrdenar);
            O.Sort(ref AuxOrdenar, 0, AuxOrdenar.Length - 1);
            Vocabulario.Clear();
            Vocabulario.AddRange(AuxOrdenar);
           
            /* TRANSFORMAR NUM MENU COM NUMEROS DEPOIS */
            switch (tipo)
            {
                case "Vetorial":
                    rotinaModeloVetorial();
                    break;
                case "GranModerada":
                    rotinaGranModerada();
                    break;
                case "GranFina":
                    rotinaGranFina();
                    break;
            }
            Console.WriteLine("\n\nBase de {0} palavras", Vocabulario.Count);
        }
 
        private void rotinaGranModerada()
        {
            string arquivo = "Granularidade Moderada.txt";
            if (File.Exists(arquivo))
                File.Delete(arquivo);
            foreach (Termo T in Vocabulario)
            {
                string aux;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(arquivo, true))
                {
                    aux = T.palavra + "\t" + T.GranularidadeModerada();
                    file.WriteLine(aux);
                    //Console.Write(T.palavra+"\t");
                }
            }
        }

        private void rotinaModeloVetorial()
        {
            FreqInversa();

            for (int i = 1; i <= info.numDocumentos; i++)
            {
                Docs[i].calculaPesos(Vocabulario);
               // Docs[i].imprimePesosNaTela();
            }            
            imprimeArquivoPesos();
        }

        private void rotinaGranFina()
        {
            string arquivo = "Granularidade Fina.txt";
            if (File.Exists(arquivo))
                File.Delete(arquivo);
            foreach (Termo T in Vocabulario)
            {
                string aux;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(arquivo, true))
                {
                    aux = T.palavra + "\t" + T.GranularidadeFina();
                    file.WriteLine(aux);
                    Console.WriteLine(aux);
                }
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
                T.frequenciaInversa = Math.Log(1 + (info.numDocumentos*1.0 / Cont), 2);
            }
        }

        private void imprimeArquivoPesos()
        {
            string texto;
            string arquivo = "Obtencao de pesos.txt";
            if (File.Exists(arquivo))
                File.Delete(arquivo);
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                texto = "";
                foreach (double d in Docs[i].Pesos)
                {
                    texto += String.Format("{0:0.000} ", d);
                }
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(arquivo, true))
                {
                    file.WriteLine(texto);
                }
            }
        }

    

    }
}
