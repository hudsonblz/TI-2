using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_2
{
    class Consulta
    {
        public List<string> consulta = new List<string>();
        public Dicionario dicionario = new Dicionario();
        public List<double> consulta_peso = new List<double>();
        public List<string> texto_separado = new List<string>();
        public List<peso_docs> lista_links = new List<peso_docs>();

        public Consulta(string texto_consulta, Dicionario dicionario) 
        {
            this.dicionario = dicionario;
            calcula_pesos(texto_consulta,dicionario);

            
        }

        public List<int> lista_de_links() 
        {
            List<int> docs = new List<int>();

            //inicializa vetor de relevancia
            for (int num_doc = 1; num_doc < info.numDocumentos+2; num_doc++)
            {
                lista_links.Add(new peso_docs(num_doc, 0));
            }

            // para cada palavra da consulta
            foreach (string palavra_consulta in consulta) 
            {
                //e para cada termo do vocabulario
                foreach (Termo termo in dicionario.Vocabulario)
                {
                    // se o termo for igual a palavra da consulta
                    if (termo.palavra.CompareTo(palavra_consulta) == 0)
                    {
                        int num_doc = 1;
                        //adcionar peso do termo no doc
                        foreach (int frequencia in termo.frequenciaEmDoc)
                        {
                            if (frequencia > 0)
                            {
                                int total_incidencias = termo.frequenciaEmDoc.Sum();
                                double frequencia_direta = frequencia * 1.0 / dicionario.Docs[num_doc].total_palavras;
                                double frequencia_inversa = Math.Log((1 + ((info.numDocumentos) / (total_incidencias * 1.0))), 2.0);
                                lista_links[num_doc - 1].peso.Add(Math.Round(((1 + frequencia_direta) * (frequencia_inversa)), 3));

                            }
                            else
                            {
                                lista_links[num_doc - 1].peso.Add(0.0);
                            }
                            num_doc++;
                        }
                        //interrompe ao encontrar a palavra
                        break;
                    }
                }
            }
                //calcula a relevancia
            foreach (peso_docs link in lista_links)
            {
                List<double> soma = new List<double>();
                double raiz1 = 0;
                double raiz2 = 0;
                for (int indice = 0; indice < consulta.Count(); indice++)
                {
                    soma.Add(consulta_peso[indice] * link.peso[indice]);
                    raiz1 += consulta_peso[indice] * consulta_peso[indice];
                    raiz2 += link.peso[indice] * link.peso[indice];
                }
                double dividendo = soma.Sum();
                raiz1 = Math.Sqrt(raiz1);
                raiz2 = Math.Sqrt(raiz2);

                if (raiz1 * raiz2 == 0)
                {
                    link.relevancia = 0.0;
                }
                else
                {
                    link.relevancia = dividendo / (raiz1 * raiz2);
                }

            }
            
            // ordenação selection sort
            int max;
            for (int i = 0; i < lista_links.Count - 1; i++)
            {
                max = i;

                for (int j = i + 1; j < lista_links.Count; j++)
                {
                    if (lista_links[j].relevancia > lista_links[max].relevancia)
                    {
                        max = j;
                    }
                }
                //pega o doc de maior relevancia e move para a lista de retorno dos docs
                if (max != i)
                {
                    if (lista_links[max].relevancia > 0)
                    {
                        docs.Add(lista_links[max].num_doc);
                    }
                    lista_links.RemoveAt(max);
                }
            }
            //retorna a lista
            return docs;
        }

        public void calcula_pesos(string texto_consulta, Dicionario dicionario)
        {
            List<double> consulta_idf = new List<double>();
            List<double> consulta_tf = new List<double>();
            texto_consulta.Replace(",", "").Replace("  ", " ").Replace("?", "").Replace("!", "");
            try
            {
                texto_separado.AddRange(texto_consulta.Split(' '));
                consulta.AddRange(texto_separado.Distinct().ToList());

            }
            catch
            {
                consulta.Add(texto_consulta);
                texto_separado.Add(texto_consulta);
            }
            foreach (string palavra in consulta)
            {
                bool termo_encontrado = false;
                foreach (Termo palavra_vocab in dicionario.Vocabulario)
                {
                    if (palavra.ToLower().CompareTo(palavra_vocab.palavra.ToLower()) == 0)
                    {
                        int total_docs = palavra_vocab.frequenciaEmDoc.Count();
                        int total_incidencias = palavra_vocab.frequenciaEmDoc.Sum();
                        consulta_idf.Add(Math.Log(1 + (total_incidencias * 1.0 / total_docs), 2));

                        int incidencia_consulta = 0;

                        if (consulta.Count() > 1)
                        {
                            foreach (string termo_busca in texto_separado)
                            {
                                if (termo_busca.CompareTo(palavra) == 0)
                                {
                                    incidencia_consulta += 1;
                                }
                            }
                        }
                        else
                        {
                            incidencia_consulta = 1;
                        }

                        double frequencia = incidencia_consulta *1.0 / texto_separado.Count();
                        consulta_tf.Add(frequencia * 1.0);
                        termo_encontrado = true;
                        break;
                    }
                }
                if (!termo_encontrado)
                {
                    consulta.Remove(palavra);
                }
            }
            //se pesquisa tiver mais de um termo

            if (consulta_tf.Count > 1)
            {

                for (int i = 0; i < consulta_tf.Count; i++)
                {
                    if (consulta_tf.Max() > 0)
                    {
                        consulta_tf[i] = consulta_tf[i] / consulta_tf.Max();
                    }
                    else
                    {
                        consulta_tf[i] = 0.0;
                    }
                }

                for (int indice = 0; indice < texto_separado.Count(); indice++)
                {
                    consulta_peso.Add(consulta_tf[indice] * consulta_idf[indice]);
                }
            }
            else
            {
                consulta_tf[0] = consulta_tf[0] / consulta_tf.Max();
                for (int indice = 0; indice < texto_separado.Count(); indice++)
                {
                    consulta_peso.Add(consulta_tf[indice] * consulta_idf[indice]);
                }
            }
            double a = consulta_peso[0];
        }
    }
}
