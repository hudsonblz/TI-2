using System.IO;

namespace TI_2
{
    partial class info
    {
        static public int numDocumentos = 0;
        static public int totalPalavras = 0;
        static public int palavrasVocab = 0;
        static public int tempoLerArquivos = 0;

        static public void contaDocumentos()
        {
            int i = 1;
            while (File.Exists(i + ".txt"))
            {
                i++;
            }
            numDocumentos = i - 1;
        }
    }
}