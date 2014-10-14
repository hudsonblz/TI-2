using System.Collections.Generic;
using System.IO;

namespace TI_2
{
    internal class Documento
    {
        public int numPalavras;     // Numero de palavras não repetidas do documento
        public double[] Pesos;      // Matriz dos pesos para o Modelo Vetorial
        private string Arquivo;     // Nome do arquivo de texto de origem do documento
        private List<Termo> documento = new List<Termo>();      // Lista de termos do documento
        public int numArquivo;     // Representa a posição do arquivo a matriz de frequencia dos termos
        private Ordenar O = new Ordenar();  // Usado para ordenar a lista 'documento'

        /// <summary>
        /// Cria novo objeto tipo Documento, equivalente lógico a um arquivo txt.
        /// O documento é lido, ordenado e adicionado ao vocabulário.
        /// </summary>
        /// <param name="_numArquivo">Nome do arquivo txt, representado por um número</param>
        /// <param name="Voc">referencia à lista 'vocabulario' da qual esse documento vai pertencer</param>
        public Documento(int _numArquivo, ref List<Termo> Voc)
        {
            /* No construtor basta dizer o nome (numero) do arquivo txt
             * O documento é lido, ordenado e adicionado ao vocabulário */
            numArquivo = _numArquivo;
            Arquivo = numArquivo + ".txt";
            LerArquivo();

            if (Voc.Count > 0)
                addVocabulario(ref Voc); //Adiciona a lista de termos no documento ao vocabulario geral eliminando duplicidades
            else
                Voc.AddRange(documento);    // Se o vocabulario estiver vazio simplesmente adiciona toda a lista de uma vez
        }

        /// <summary>
        /// Calcula o vetor de pesos para Modelo Vetorial
        /// </summary>
        /// <param name="Voc">Vocabulario geral</param>
        public void calculaPesos(List<Termo> Voc)
        {
            /* Essa parte calcula o peso direto */
            Pesos = new double[Voc.Count];  //Determina q o vetor de pesos tera o tamanho da lista do vocabulario
            int i = 0;
            foreach (Termo T in Voc)
            {
                /* Para cada termo do vocabulario a posição referente a ele no vetor de pesos desse documento é calculada */
                Pesos[i] = T.frequenciaEmDoc[numArquivo] * 1.0 / Voc.Count;
                i++;
            }

            PesoFinal(Voc);
        }

        /// <summary>
        /// Lê arquivo txt e adiciona as palavras na lista de documento sem duplicidade
        /// </summary>
        ///
        public void LerArquivo()
        {
            string texto = File.ReadAllText(Arquivo);   // Lê o documento inteiro e salva o conteudo no string texto
            texto = transformacaoLexica(texto);
            string[] termos = texto.Split(' '); // Divide o texto num vetor de strings com base nos espaços
            info.totalPalavras += termos.Length;
            // Esse vetor "termos" contem todas as palavras do arquivo (duplicadas)
            addTermosNoDocumento(termos);     // Rotina para adicionar os termos lidos na lista do documento
            Ord(); //Faz o ordenamento da lista
        }

        public string LerArquivoInteiro()
        {
            string texto = File.ReadAllText(Arquivo);   // Lê o documento inteiro e salva o conteudo no string texto
            return texto;
        }

        private static string transformacaoLexica(string texto)
        {
            texto = texto.Replace("\r\n", " ");

            /** Troca os caracteres acentuados por não acentuados **/
            string[] caracteresEspeciais = { "«", "»", "—", "’", ".", ",", ":", " - ", "(", ")", "ª", "°", "!", "&", "*", "_", ";", "=", "?", "<", ">", "[", "]", "\"", "'" };
            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                texto = texto.Replace(caracteresEspeciais[i], "");
            }

            string[] outrosCaracteresEspeciais = { "^\\s+", "/", "\t", "\\s+$", "\\s+" };
            for (int i = 0; i < outrosCaracteresEspeciais.Length; i++)
            {
                texto = texto.Replace(outrosCaracteresEspeciais[i], " ");
            }

            string[] stopwords = File.ReadAllText("stopwords.txt").Split(' ');
            for (int i = 0; i < stopwords.Length; i++)
            {
                texto = texto.Replace(" " + stopwords[i] + " ", " ");
            }
            texto = texto.ToLower();    // Transforma todo o texto em maiusculas
            return texto;
        }

        /// <summary>
        /// Adiciona as palavras lidas no arquivo para a lista de termos do documento
        /// </summary>
        /// <param name="termos">Vetor de palavras lidas no arquivo</param>
        /// <param name="granFina">Se a adição deve preparar para a execucao da rotina de granularidade fina</param>
        private void addTermosNoDocumento(string[] termos)
        {
            bool existe = false;    // Variavel de controle para não colocar termos duplicados na lista
            // e aumentar a frequencia do termo no documento caso já exista

            for (int j = 0; j < termos.Length; j++)// Para cada palavra do arquivo
            {   /* Para cada palavra do arquivo o algoritimo percorre toda a lista 'documento' vendo se ela ja existe
                   Caso exista, o numero de frequencia daquele termo naquele documento é aumentado em 1
                   e a posicao da palavra no vetor é inserida na matriz de posiçoes do termo
                   e a variavel repete e setada como true, para que aquele termo não seja inserido*/
                if (termos[j] != "")
                {
                    if (documento.Count > 0)
                    {
                        for (int i = 0; i < documento.Count; i++)
                        {
                            {  /*No caso de a palavra ja existir*/
                                if (documento[i].palavra == termos[j]) // Eu não usei documento.contains() pq teria que comparar com um objeto tipo Termo, e eu quero comparar com um string
                                {
                                    documento[i].frequenciaEmDoc[numArquivo]++; //aqui eu aumento a frequencia daquele termo naquele documento na matriz do termo
                                    existe = true;  // e digo que aquela palavra ja existe no vetor para não ser adicionada mais a frente
                                }
                            }
                        }
                    }
                    else    // Se o documento estiver vazio simplesmente adicione o termo
                    {
                        documento.Add(new Termo(termos[j], numArquivo, j + 1));
                        numPalavras++;
                        existe = true;
                    }
                    if (!existe)   // Se aquela palava não existir na lista do documento simplesmente adicione o termo
                    {
                        documento.Add(new Termo(termos[j], numArquivo, j + 1));
                        numPalavras++;
                    }
                    existe = false; // Reseta o existe para o proximo loop
                }
            }
        }

        /// <summary>
        /// Adiciona os termos encontrados no documento na lista 'Vocabulario' geral
        /// </summary>
        /// <param name="Voc">Vocabulario Geral</param>
        private void addVocabulario(ref List<Termo> Voc)
        {
            // Segue a mesma lógica do add termos no vocabulário
            bool existe = false;
            foreach (Termo termo in documento)
            {
                for (int i = 0; i < Voc.Count; i++)
                {
                    if (Voc[i].palavra == termo.palavra)
                    {
                        //Aqui, caso a palavra exista no vocabulario, a frequencia naquele documento é igualada à frequencia observada na leitura do documento
                        Voc[i].frequenciaEmDoc[numArquivo] = termo.frequenciaEmDoc[numArquivo];
                        existe = true;
                    }
                }

                if (!existe)
                {
                    Voc.Add(termo);
                    numPalavras++;
                }
                existe = false;
            }
        }

        /// <summary>
        /// Ordena usando o Quick Sort
        /// </summary>
        private void Ord()
        {
            Termo[] Ordenar = new Termo[documento.Count];
            documento.CopyTo(Ordenar);
            O.Sort(ref Ordenar, 0, Ordenar.Length - 1);
            documento.Clear();
            documento.AddRange(Ordenar);
        }

        /// <summary>
        /// Calcula Peso final dos termos com a formula Smart
        /// </summary>
        /// <param name="Voc">Vocabulário geral</param>
        private void PesoFinal(List<Termo> Voc)
        {
            /* Calcula o peso final contando a frequencia direta e inversa */
            int i = 0;
            foreach (Termo T in Voc) // Calcula o peso final para cada termo no vocabulario
            {
                if (Pesos[i] != 0)
                {
                    Pesos[i] = (1 + Pesos[i]) * T.frequenciaInversa;
                }
                i++;
            }
        }
    }
}