using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Huffman
{
    public class Arvore_huffman   // montado a arvore de huffman
    {
        private List<No> nos = new List<No>();
        public No Raiz { get; set; }
        public Dictionary<char, int> Frequencias = new Dictionary<char, int>();

        public void Construir(string origem)
        {
            for (int i = 0; i < origem.Length; i++)
            {
                if (!Frequencias.ContainsKey(origem[i]))
                {
                    Frequencias.Add(origem[i], 0);
                }

                Frequencias[origem[i]]++;
            }

            foreach (KeyValuePair<char, int> simbolo in Frequencias)
            {
                nos.Add(new No() { Simbolos = simbolo.Key, Frequencia = simbolo.Value });
            }

            while (nos.Count > 1)
            {
                List<No> ordenando_nos = nos.OrderBy(node => node.Frequencia).ToList<No>();

                if (ordenando_nos.Count >= 2)
                {
                    // pega os 2 primeiros itens
                    List<No> Pegar = ordenando_nos.Take(2).ToList<No>();

                    // cria um no parente combinando a frequencia
                    No parente = new No()
                    {
                        Simbolos = '*',
                        Frequencia = Pegar[0].Frequencia + Pegar[1].Frequencia,
                        Esquerdo = Pegar[0],
                        Direito = Pegar[1]
                    };

                    nos.Remove(Pegar[0]);
                    nos.Remove(Pegar[1]);
                    nos.Add(parente);
                }

                this.Raiz = nos.FirstOrDefault();

            }

        }

        public BitArray codificar(string origem) // codificando o texto
        {
            List<bool> codificando_origem = new List<bool>();

            for (int i = 0; i < origem.Length; i++)
            {
                List<bool> codifica_simbolo = this.Raiz.Transforma(origem[i], new List<bool>());
                codificando_origem.AddRange(codifica_simbolo);
            }

            BitArray bits = new BitArray(codificando_origem.ToArray());

            return bits;
        }

        public string Decodificar(BitArray bits)   // decodificando o texto
        {
            No corrente = this.Raiz;
            string decodificando = "";

            foreach (bool bit in bits)
            {
                if (bit)
                {
                    if (corrente.Direito != null)
                    {
                        corrente = corrente.Direito;
                    }
                }
                else
                {
                    if (corrente.Esquerdo != null)
                    {
                        corrente = corrente.Esquerdo;
                    }
                }

                if (folha(corrente))
                {
                    decodificando += corrente.Simbolos;
                    corrente = this.Raiz;
                }
            }

            return decodificando;
        }

        public bool folha(No no)
        {
            return (no.Esquerdo == null && no.Direito == null);
        }

    }
}
