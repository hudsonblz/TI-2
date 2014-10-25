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
    public partial class Splash : Form
    {
        
        /*Comentario copiado do tutorial*/
        // delegate usado para invocar o update da barra de progresso
        // na classe que le os docs, a cada doc lido temos um evendo que  reporta o progresso.
        // quando está tudo lido tem um evento que anuncia o fim. 

        public Splash()
        {
            InitializeComponent();
            this.progressBar1.Maximum = info.numDocumentos;
            del = this.UpdateProgressInternal;
        }
        private delegate void ProgressDelegate(int progress);

        private ProgressDelegate del;

        private void UpdateProgressInternal(int progress)
        {
            if (this.Handle == null)
            {
                return;
            }
            this.progressBar1.Value = progress;
        }

        public void UpdateProgress(int progress)
        {
            try
            { this.Invoke(del, progress); }
            catch { };
        }
    }
}
