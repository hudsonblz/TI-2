using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TI_2
{
    class peso_docs
    {
        public int num_doc;
        public double relevancia;
        public List<double> peso = new List<double>();

        public peso_docs(int num_doc, double relevancia) 
        {
            this.num_doc = num_doc;
            this.relevancia = relevancia;
        }
    }
}
