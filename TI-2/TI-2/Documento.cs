using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TI_2
{
    internal class Documento
    {
        public int numPalavras;     // Numero de palavras não repetidas do documento
        public double[] Pesos;      // Matriz dos pesos para o Modelo Vetorial
        private string Arquivo;     // Nome do arquivo de texto de origem do documento
        private List<Termo> documento = new List<Termo>();      // Lista de termos do documento
        public int numArquivo;     // Representa a posição do arquivo a matriz de frequencia dos termos
        public int total_palavras;

        /// <summary>
        /// Cria novo objeto do tipo Documento, equivalente lógico a um arquivo txt.
        /// O documento é lido, ordenado e os termos são adicionados ao vocabulário.
        /// </summary>
        /// <param name="_numArquivo">Nome do arquivo txt, representado por um número</param>
        /// <param name="infoVocab">referencia à lista 'vocabulario' à qual esse documento vai pertencer</param>
        public Documento(int _numArquivo)
        {
            /* No construtor basta dizer o nome (numero) do arquivo txt
             * O documento é lido, ordenado e adicionado ao vocabulário */
            numArquivo = _numArquivo;
            Arquivo = numArquivo + ".txt";
            LerArquivo();   //Leitura, trasf. léxica, elimina palavras repetidas e ordena

            if (info.Vocab.Vocabulario.Count > 0)
                addVocabulario(); //Adiciona a lista de termos no documento ao vocabulario geral eliminando duplicidades
            else
                info.Vocab.Vocabulario.AddRange(documento);    // Se o vocabulario estiver vazio simplesmente adiciona toda a lista de uma vez
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
        /// Lê arquivo txt e adiciona as palavras na lista de documento, tratadas e sem duplicidade
        /// </summary>
        ///
        public void LerArquivo()
        {
            string texto = File.ReadAllText(Arquivo);   // Lê o documento inteiro e salva o conteudo no string texto
            texto = transformacaoLexica(texto);
            string[] termos = texto.Split(' '); // Divide o texto num vetor de strings com base nos espaços
            total_palavras = termos.Length;
            info.totalPalavras += termos.Length;
            // Esse vetor "termos" contem todas as palavras do arquivo (duplicadas)
            addTermosNoDocumento(termos);     // Rotina para adicionar os termos lidos na lista do documento
            Ordenar(); //Faz o ordenamento da lista
        }

        /// <summary>
        /// Lê o documento inteiro e salva o conteudo no string texto            
        /// </summary>
        /// <returns>Texto original do documento</returns>
        public string LerArquivoInteiro()
        {
            string texto = File.ReadAllText(Arquivo);   // Lê o documento inteiro e salva o conteudo no string texto
            return texto;
        }

        /// <summary>
        /// Le a linha indicada do documento
        /// </summary>
        /// <param name="linha">Linha a ser lida (1 based)</param>
        /// <returns>O conteudo daquela linha</returns>
        public string lerUmaLinha(int linha)
        {
            string linhaDoDoc = "Linha não encontrada";
            var leitor = new FileStream(Arquivo, FileMode.Open, FileAccess.Read);
            var file = new StreamReader(leitor, true);
            int i = 1;
            while ((linhaDoDoc = file.ReadLine()) != null)
            {
                if (linha==i)
                    return file.ReadLine();
                i++;
            }
            return linhaDoDoc;
        }

        /// <summary>
        /// Remoção de caracteres especiais, pontuação e stopwords
        /// </summary>
        /// <param name="texto">Texto não tratado lido do txt</param>
        /// <returns>Texto tratado</returns>
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

        /// <summary>
        /// Adiciona as palavras lidas no arquivo para a lista de termos do documento
        /// </summary>
        /// <param name="termos">Vetor de palavras lidas no arquivo</param>
        private void addTermosNoDocumento(string[] termos)
        {
            /* Variavel de controle para não colocar termos duplicados na lista 
             * e aumentar a frequencia do termo no documento caso já exista */
            bool existe = false;

            /* Para cada palavra do arquivo o algoritimo percorre toda a lista 'documento' vendo se ela ja existe
             * Caso exista, o numero de frequencia daquele termo naquele documento é aumentado em 1
             * e a variavel existe é setada como true, para que aquele termo não seja inserido*/
            for (int j = 0; j < termos.Length; j++)// Para cada palavra do arquivo
            {   
                if (termos[j] != "")    //Se o termo for mesmo um termo, senão deixa pra lá
                {
                    if (documento.Count > 0)    //Se a lista 'documento' tiver algum termo, senão adiciona direto
                    {
                        for (int i = 0; i < documento.Count; i++)   //Percorre a lista
                        {
                            /*No caso de a palavra ja existir*/
                            if (documento[i].palavra == termos[j]) // Eu não usei documento.Contains() pq teria que comparar com um objeto tipo Termo, e eu quero comparar com um string
                            {
                                documento[i].frequenciaEmDoc[numArquivo]++; //aqui eu aumento a frequencia daquele termo naquele documento na matriz do termo
                                existe = true;  // e digo que aquela palavra ja existe no vetor para não ser adicionada mais a frente
                            }

                        }
                    }
                    else    // Se o documento estiver vazio simplesmente adicione o termo
                    {
                        documento.Add(new Termo(termos[j], numArquivo));
                        numPalavras++;
                        existe = true;
                    }
                    if (!existe)   // Se aquela palava não existir na lista do documento simplesmente adicione o termo
                    {
                        documento.Add(new Termo(termos[j], numArquivo));
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
        private void addVocabulario()
        {
            // Segue a mesma lógica do add termos no vocabulário
            bool existe = false;
            foreach (Termo termo in documento)
            {
                for (int i = 0; i < info.Vocab.Vocabulario.Count; i++)
                {
                    if (info.Vocab.Vocabulario[i].palavra == termo.palavra)
                    {
                        /* Caso a palavra exista no vocabulario 
                         * a frequencia naquele documento é igualada à frequencia observada na leitura do documento */
                        info.Vocab.Vocabulario[i].frequenciaEmDoc[numArquivo] = termo.frequenciaEmDoc[numArquivo];
                        existe = true;
                    }
                }

                if (!existe)
                {
                    info.Vocab.Vocabulario.Add(termo);
                    numPalavras++;
                }
                existe = false;
            }
        }

        /// <summary>
        /// Ordena usando o Quick Sort
        /// </summary>
        private void Ordenar()
        {
            Ordenar O = new Ordenar();
            O.Sort(ref documento, 0, documento.Count - 1);  // Usado para ordenar a lista 'documento'
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
                if (Pesos[i] != 0)  //Se não for 0, o vetor 'Pesos' conterá o valor da frequencia direta do termo
                {
                    Pesos[i] = (1 + Pesos[i]) * T.frequenciaInversa;
                }
                i++;    //Acha que eu devia ter usado um for? Mas eu gosto do foreach! :P
            }
        }
    }
}