using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_2
{
    class Ordenar
    {
        /// <summary>
        /// Método Quick Sort
        /// </summary>
        /// <param name="X">Vetor</param>
        /// <param name="p">0</param>
        /// <param name="r">vetor.lenght-1</param>
        public void Sort(ref Termo[] X, int p, int r)
        {
            int q;
            if (p < r)
            {
                q = Particao(X, p, r);
                Sort(ref X, p, q);
                Sort(ref X, q + 1, r);
            }
        }

        private static int Particao(Termo[] X, int p, int r)
        {
            Termo Pivo;
            int i, j;
            Pivo = X[(p + r) / 2];
            i = p - 1;
            j = r + 1;
            while (i < j)
            {
                do
                {
                    j--;
                } while (X[j].palavra.CompareTo(Pivo.palavra) > 0);
                do
                {
                    i++;
                } while (X[i].palavra.CompareTo(Pivo.palavra) < 0);
                if (i < j)
                {
                    Troca(X, i, j);
                }
            }
            return j;
        }

        private static void Troca(Termo[] X, int i, int j)
        {
            Termo Aux;
            Aux = X[i];
            X[i] = X[j];
            X[j] = Aux;
        }
    }
}
