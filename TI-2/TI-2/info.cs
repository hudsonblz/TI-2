using System.IO;

namespace TI_2
{
    partial class info
    {
        static public int numDocumentos = 0;
        static public int totalPalavras = 0;
        static public int palavrasVocab = 0;
        static public int tempoLerArquivos = 0;
        static public string[] rotulos = new string[1103];

        static public void contaDocumentos()
        {
            int i = 1;
            while (File.Exists(i + ".txt"))
            {
                i++;
            }
            numDocumentos = i - 1;
        }

        static public void rotular()
        {
            for (int i = 1; i <= 106; i++)
            {
                rotulos[i] = "Canto I - Estancia " + i;
            }
            for (int i = 1; i <= 113; i++)
            {
                rotulos[i + 106] = "Canto II - Estancia " + i;
            }
            for (int i = 1; i <= 143; i++)
            {
                rotulos[i + 106+ 113] = "Canto III - Estancia " + i;
            }
            for (int i = 1; i <= 104; i++)
            {
                rotulos[i + 106 + 113 + 143] = "Canto IV - Estancia " + i;
            }
            for (int i = 1; i <= 100; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104] = "Canto V - Estancia " + i;
            }
            for (int i = 1; i <= 99; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100] = "Canto VI - Estancia " + i;
            }
            for (int i = 1; i <= 87; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99] = "Canto VII - Estancia " + i;
            }
            for (int i = 1; i <= 99; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99 + 87] = "Canto VIII - Estancia " + i;
            }
            for (int i = 1; i <= 95; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99 + 87 + 99] = "Canto IX - Estancia " + i;
            }
            for (int i = 1; i <= 156; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99 + 87 + 99 + 95] = "Canto X - Estancia " + i;                
            }
        }


    }
}