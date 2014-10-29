using System;
using System.Windows.Forms;
using System.Threading;

namespace TI_2
{
    public partial class Principal : Form
    {
        private int linkLeft = 15;
        private int linkTop = 10;
        private int labelLeft = 50;
        private int labelTop = 35;

        // =========================================================================== CODIGO PARA A SPLASH SCREEN E INICIALIZAÇÃO
        private Splash splashScr;
        private bool done = false;
        public Principal()
        {
            InitializeComponent();
            info.rotular();
            info.contaDocumentos();
            this.Load += new EventHandler(HandleFormLoad);
            this.splashScr = new Splash();            
        }
        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();
            Thread thread = new Thread(new ThreadStart(this.Showsplash));
            thread.Start();
            Leitura worker = new Leitura();
            worker.ProgressChanged += (o, ex) =>
            {
                this.splashScr.UpdateProgress(ex.Progress);
            };
            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };
            worker.DoHardWork();
        }
        private void Showsplash()
        {
            splashScr.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            splashScr.Close();
            this.splashScr.Dispose();
        }
        // =========================================================================== CODIGO PARA A SPLASH SCREEN E INICIALIZAÇÃO

        private void gerarLinks()
        {
            progressBar1.Maximum = info.Vocab.Docs.Length;
            progressBar1.Visible = true;

            Consulta cons = new Consulta(textBox1.Text.ToString(), info.Vocab);
            foreach (int i in cons.lista_de_links())
            {
                NewLink(info.Vocab.Docs[i - 1].numArquivo);
                progressBar1.PerformStep();
            }

            //for (int i = 1; i < info.Vocab.Docs.Length; i++)
            //{                
            //   NewLink(info.Vocab.Docs[i].numArquivo);
            //   progressBar1.PerformStep();
            //}
            progressBar1.Visible = false;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            DateTime CalcTempo = DateTime.Now;  //Usado para calcular tempo de leitura para estatísticas
            panel_Links.Controls.Clear();
            gerarLinks();
            TimeSpan tempoGasto = DateTime.Now - CalcTempo;         //Calcula tempo gasto na leitura e afins            
            info.tempoLerArquivos = tempoGasto;   // e envia o valor para estatísticas
        }     

        private string getTextoDoc(int numDoc)
        {
            if (numDoc < info.Vocab.Docs.Length)
                return info.Vocab.Docs[numDoc].LerArquivoInteiro();
            else
                return "Documento nao encontrado"+Environment.NewLine;
        }       

        private void linkClicado(object caminhoLink, LinkLabelLinkClickedEventArgs e)
        {
            panel_Texto.Visible = true;
            panel_Links.Visible = false;
            label_rotuloDoc.Text = info.rotulos[int.Parse(e.Link.LinkData.ToString())];
            label_TextoDoc.Text = getTextoDoc(int.Parse(e.Link.LinkData.ToString()));
        }

        private void NewLink(int caminhoLink)
        {
            /* Configurações do link */
            LinkLabel link = new LinkLabel();
            link.Top = linkTop;
            linkTop += 55;
            link.Left = linkLeft;
            link.Width = 200;
            link.Text = info.rotulos[caminhoLink];
           
            /* Configurações do texto que aparece abaixo do link*/
            Label texto = new Label();
            texto.Text = info.Vocab.Docs[caminhoLink].lerUmaLinha(1); // Primeira linha do arquivo
            texto.Top = labelTop;
            labelTop += 55;
            texto.Left = labelLeft;
            texto.Width = 300;

            /* Destino do link */
            link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClicado);
            LinkLabel.Link goTo = new LinkLabel.Link();
            goTo.LinkData = caminhoLink;
            link.Links.Add(goTo);

            /* Adiciona no painel*/
            panel_Links.Controls.Add(link);
            panel_Links.Controls.Add(texto);
        }

        

        private void formarVocabularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    info.Vocab.lerDocs(progressBar1);
            button_Search.Enabled = true;
        }

        private void estatisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatisticas Estatic = new Estatisticas();
            Estatic.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Texto.Visible = false;
            panel_Links.Visible = true;
        }
    }
}