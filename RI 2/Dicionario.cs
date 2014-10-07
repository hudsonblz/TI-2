using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RI_2
{
    class Dicionario
    {
        Menu Controla = new Menu();
        public Documento[] Docs = new Documento[info.numDocumentos + 1];
        public List<Termo> Vocabulario = new List<Termo>();

        // Todos os termos
        private Ordenar O = new Ordenar();

        public void Controle()
        {
            int opc = Controla.MenuOperacoes();
            DateTime Aux = DateTime.Now;
            for (int i = 1; i <= info.numDocumentos; i++)
            {
                Docs[i] = new Documento(i, ref Vocabulario);
            }
            TimeSpan Tempo = DateTime.Now - Aux;
            Console.WriteLine("Leitura: "+Tempo.TotalSeconds.ToString());
            Aux = DateTime.Now;
            Ordenar();
            Tempo = DateTime.Now - Aux;
            Console.WriteLine("Ordenacao" + Tempo.TotalSeconds.ToString());
            Aux = DateTime.Now;
            switch (opc)
            {
                case 1:
                    rotinaModeloVetorial();
                    break;
                case 2:
                    rotinaGranModerada();
                    break;
                case 3:
                    rotinaGranFina();
                    break;
                case 4:
                    rotinaTransposta();
                    break;
                case 5:
                    rotinaConsumoLinkedList();
                    break;
            }
            Tempo = DateTime.Now - Aux;
            Console.WriteLine("Operacao" + Tempo.TotalSeconds.ToString());
            Aux = DateTime.Now;

            Console.WriteLine("\n\nBase de {0} palavras", Vocabulario.Count);

            Console.ReadKey();
        }

        private void Ordenar()
        {
            Termo[] AuxOrdenar = new Termo[Vocabulario.Count];
            Vocabulario.CopyTo(AuxOrdenar);
            O.Sort(ref AuxOrdenar, 0, AuxOrdenar.Length - 1);
            Vocabulario.Clear();
            Vocabulario.AddRange(AuxOrdenar);
        }

        private void rotinaConsumoLinkedList()
        {
            int somaMelhorCaso = 0;
            int somaPiorCaso = 0;
            string arquivo = "Ganho de memoria.txt";
            string texto = "";
            foreach (Termo T in Vocabulario)
            {
                string[] dados = T.dadosLinkedList().Split(';');
                somaMelhorCaso += int.Parse(dados[0]);
                somaPiorCaso += int.Parse(dados[1]);
                texto += T.palavra + "\t" + dados[2].Replace(',','.') + "\r\n";
            }
            double consumo = (1 - somaMelhorCaso * 1.0 / somaPiorCaso) * 100;
            texto += "GANHO TOTAL" + "\t" + String.Format("{0:0.00} ", consumo);
            escreveTxt(texto, arquivo);
        }

        private void rotinaGranModerada()
        {
            string arquivo = "Granularidade Moderada.txt";
            string texto = "";

            foreach (Termo T in Vocabulario)
            {
                texto += T.palavra + "\t" + T.GranularidadeModerada() + "\r\n";
            }
            escreveTxt(texto, arquivo);
        }

        private void rotinaModeloVetorial()
        {
            string texto = "";

            FreqInversa();

            for (int i = 1; i <= info.numDocumentos; i++)
            {
                Docs[i].calculaPesos(Vocabulario);
                texto += Docs[i].stringPesosSmart() + "\r\n";                
            }            
            escreveTxt(texto, "Pesos.txt");
        }

        private void rotinaGranFina()
        {
            string aux = "";
            foreach (Termo T in Vocabulario)
            {                
                    aux += T.palavra + "\t" + T.GranularidadeFina()+"\r\n";
            }
            escreveTxt(aux, "Granularidade Fina.txt");
        }

        private void rotinaTransposta()
        {
            string texto = "";
            foreach (Termo T in Vocabulario)
            {
                texto += T.palavra + "\t";
                for (int i = 1; i < T.frequenciaEmDoc.Length; i++)
                {
                    texto += T.frequenciaEmDoc[i] + " ";
                }
                texto += "\r\n";
            }
            escreveTxt(texto, "Transposta.txt");
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

        private void escreveTxt(string texto, string arquivo)
        {
            if (File.Exists(arquivo))
                File.Delete(arquivo);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(arquivo, true))
            {
                file.WriteLine(texto);
            }
        }

    }
}
