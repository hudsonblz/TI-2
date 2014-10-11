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
    public partial class Form1 : Form
    {
        int linkTop = 10;
        int linkLeft = 22;
        int linkID = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          /*  ScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            panel_Links.Controls.Add(vScrollBar1);*/
        }

        private void NewLink(string caminhoLink)
        {
            LinkLabel link = new LinkLabel();
            link.Top = linkTop;
            linkTop += 50;
            link.Left = linkLeft;
            link.Text = caminhoLink;
            link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClicado);
            panel_Links.Controls.Add(link);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            linkID++;
            NewLink("Link "+linkID+" criado");
        }

        private void linkClicado(object caminhoLink, LinkLabelLinkClickedEventArgs e)
        {
            label_TextoDoc.Text = e.Link.Name.ToString();
        }     
    }
}
