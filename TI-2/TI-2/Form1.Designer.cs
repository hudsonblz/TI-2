namespace TI_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Links = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel_Texto = new System.Windows.Forms.Panel();
            this.label_TextoDoc = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formarVocabularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Texto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Links
            // 
            this.panel_Links.AutoScroll = true;
            this.panel_Links.Location = new System.Drawing.Point(0, 102);
            this.panel_Links.Name = "panel_Links";
            this.panel_Links.Size = new System.Drawing.Size(315, 448);
            this.panel_Links.TabIndex = 0;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(12, 49);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(101, 13);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Do your search Bro!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(506, 73);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Go Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel_Texto
            // 
            this.panel_Texto.Controls.Add(this.label_TextoDoc);
            this.panel_Texto.Location = new System.Drawing.Point(343, 102);
            this.panel_Texto.Name = "panel_Texto";
            this.panel_Texto.Size = new System.Drawing.Size(245, 232);
            this.panel_Texto.TabIndex = 4;
            // 
            // label_TextoDoc
            // 
            this.label_TextoDoc.AutoSize = true;
            this.label_TextoDoc.Location = new System.Drawing.Point(17, 21);
            this.label_TextoDoc.Name = "label_TextoDoc";
            this.label_TextoDoc.Size = new System.Drawing.Size(182, 13);
            this.label_TextoDoc.TabIndex = 0;
            this.label_TextoDoc.Text = "Conteudo do doc cujo link foi clicado";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(170, 313);
            this.progressBar1.Maximum = 1108;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 30);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formarVocabularioToolStripMenuItem,
            this.estatisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formarVocabularioToolStripMenuItem
            // 
            this.formarVocabularioToolStripMenuItem.Name = "formarVocabularioToolStripMenuItem";
            this.formarVocabularioToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.formarVocabularioToolStripMenuItem.Text = "Formar Vocabulario";
            this.formarVocabularioToolStripMenuItem.Click += new System.EventHandler(this.formarVocabularioToolStripMenuItem_Click);
            // 
            // estatisticasToolStripMenuItem
            // 
            this.estatisticasToolStripMenuItem.Name = "estatisticasToolStripMenuItem";
            this.estatisticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatisticasToolStripMenuItem.Text = "Estatisticas";
            this.estatisticasToolStripMenuItem.Click += new System.EventHandler(this.estatisticasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 550);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel_Texto);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.panel_Links);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TI 2 2014";
            this.panel_Texto.ResumeLayout(false);
            this.panel_Texto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Links;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Panel panel_Texto;
        private System.Windows.Forms.Label label_TextoDoc;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formarVocabularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
    }
}

