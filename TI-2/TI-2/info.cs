using System.IO;

namespace TI_2
{
    partial class info
    {
        //Usados para mostrar estatísticas
        static public int numDocumentos = 0;    
        static public int totalPalavras = 0;    
        static public int palavrasVocab = 0;
        static public int tempoLerArquivos = 0;
       
        static public string[] rotulos = new string[1103];  //Usado para mostrar o nome dos documentos 

        /// <summary>
        /// Conta os documentos que serão tratados, numerados em sequencia
        /// </summary>
        static public void contaDocumentos()
        {   /*conta os documentos que estarão numerados em sequencia começando pelo 1, não pelo 0*/
            int i = 1;     
            while (File.Exists(i + ".txt"))
            {
                i++;
            }
            numDocumentos = i - 1;
        }

        /// <summary>
        /// Coloca os rótulos de canto e estrofe nos documentos, 
        /// </summary>
        static public void rotular()
        {
            /* Esses rótulos serão exibidos nos links e titulo do documento clicado */
            for (int i = 1; i <= 106; i++)
            {
                rotulos[i] = "Canto I - Estrofe " + i;
            }
            for (int i = 1; i <= 113; i++)
            {
                rotulos[i + 106] = "Canto II - Estrofe " + i;
            }
            for (int i = 1; i <= 143; i++)
            {
                rotulos[i + 106 + 113] = "Canto III - Estrofe " + i;
            }
            for (int i = 1; i <= 104; i++)
            {
                rotulos[i + 106 + 113 + 143] = "Canto IV - Estrofe " + i;
            }
            for (int i = 1; i <= 100; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104] = "Canto V - Estrofe " + i;
            }
            for (int i = 1; i <= 99; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100] = "Canto VI - Estrofe " + i;
            }
            for (int i = 1; i <= 87; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99] = "Canto VII - Estrofe " + i;
            }
            for (int i = 1; i <= 99; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99 + 87] = "Canto VIII - Estrofe " + i;
            }
            for (int i = 1; i <= 95; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99 + 87 + 99] = "Canto IX - Estrofe " + i;
            }
            for (int i = 1; i <= 156; i++)
            {
                rotulos[i + 106 + 113 + 143 + 104 + 100 + 99 + 87 + 99 + 95] = "Canto X - Estrofe " + i;                
            }
        }


    }
}