using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TI_2
{
    public partial class Estatisticas : Form
    {
        public Estatisticas()
        {
            InitializeComponent();
        }

        private void Estatisticas_Load(object sender, EventArgs e)
        {
            label_numDoc.Text = info.numDocumentos.ToString();
            label_tatalPalavras.Text = info.totalPalavras.ToString();
            label_totalVocab.Text = info.palavrasVocab.ToString();
            label_tempoLeitura.Text = info.tempoLerArquivos.Milliseconds.ToString()+" ms";
            label_consulta.Text = info.tempoConsultar.Milliseconds.ToString() + " ms"; 
        }

        
    }
}
