using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RI_2
{
    partial class info
    {
        static public int numDocumentos = 0;
        static public void contaDocumentos()
        {
            int i = 1;
            while (File.Exists(i + ".txt"))
            {
                i++;
            }
            numDocumentos = i-1;
        }
    }
}
