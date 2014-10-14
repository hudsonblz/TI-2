using System;
using System.Windows.Forms;

namespace TI_2
{
    public partial class Form1 : Form
    {
        private int linkLeft = 15;
        private int linkTop = 10;
        private Dicionario Vocab = new Dicionario();

        public Form1()
        {
            InitializeComponent();
        }

        private void gerarLinks()
        {
            for (int i = 1; i < Vocab.Docs.Length; i++)
            {
               NewLink(Vocab.Docs[i].numArquivo);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            gerarLinks();
        }     

        private string getTextoDoc(int numDoc)
        {
            if (numDoc < Vocab.Docs.Length)
                return Vocab.Docs[numDoc].LerArquivoInteiro();
            else
                return "Documento nao encontrado";
        }

        private void linkClicado(object caminhoLink, LinkLabelLinkClickedEventArgs e)
        {
            panel_Texto.Visible = true;
            label_TextoDoc.Text = getTextoDoc(int.Parse(e.Link.LinkData.ToString()));
        }

        private void NewLink(int caminhoLink)
        {
            LinkLabel link = new LinkLabel();
            link.Top = linkTop;
            linkTop += 45;
            link.Left = linkLeft;
            link.Text = "Documento "+caminhoLink;
            link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClicado);
            LinkLabel.Link goTo = new LinkLabel.Link();
            goTo.LinkData = caminhoLink;
            link.Links.Add(goTo);
            panel_Links.Controls.Add(link);
        }           

        private void formarVocabularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vocab.lerDocs(progressBar1);
        }

        private void estatisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estatisticas Estatic = new Estatisticas();
            Estatic.ShowDialog();
        }

    }
}