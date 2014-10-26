using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    public class No
    {
        public char Simbolos { get; set; }
        public int Frequencia { get; set; }
        public No Direito { get; set; }
        public No Esquerdo { get; set; }

        public List<bool> Transforma(char simbolo, List<bool> data)
        {
            // folha
            if (Direito == null && Esquerdo == null)
            {
                if (simbolo.Equals(this.Simbolos))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> esquerdo = null;
                List<bool> direito = null;

                if (Esquerdo != null)
                {
                    List<bool> caminho_esquerdo = new List<bool>();
                    caminho_esquerdo.AddRange(data);
                    caminho_esquerdo.Add(false);

                    esquerdo = Esquerdo.Transforma(simbolo, caminho_esquerdo);
                }

                if (Direito != null)
                {
                    List<bool> caminho_direito = new List<bool>();
                    caminho_direito.AddRange(data);
                    caminho_direito.Add(true);
                    direito = Direito.Transforma(simbolo, caminho_direito);
                }

                if (esquerdo != null)
                {
                    return esquerdo;
                }
                else
                {
                    return direito;
                }
            }
        }
    }
}
