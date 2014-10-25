namespace TI_2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel_Links = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel_Texto = new System.Windows.Forms.Panel();
            this.label_TextoDoc = new System.Windows.Forms.RichTextBox();
            this.label_rotuloDoc = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formarVocabularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Texto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Links
            // 
            this.panel_Links.AutoScroll = true;
            this.panel_Links.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Links.Location = new System.Drawing.Point(0, 112);
            this.panel_Links.Name = "panel_Links";
            this.panel_Links.Size = new System.Drawing.Size(457, 574);
            this.panel_Links.TabIndex = 0;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.ForeColor = System.Drawing.Color.Blue;
            this.label_Titulo.Location = new System.Drawing.Point(334, 28);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(254, 45);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "The LusiSearch";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(742, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(763, 73);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(106, 30);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Pesquisar";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // panel_Texto
            // 
            this.panel_Texto.Controls.Add(this.label_TextoDoc);
            this.panel_Texto.Controls.Add(this.label_rotuloDoc);
            this.panel_Texto.Location = new System.Drawing.Point(491, 112);
            this.panel_Texto.Name = "panel_Texto";
            this.panel_Texto.Size = new System.Drawing.Size(378, 316);
            this.panel_Texto.TabIndex = 4;
            this.panel_Texto.Visible = false;
            // 
            // label_TextoDoc
            // 
            this.label_TextoDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_TextoDoc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TextoDoc.Location = new System.Drawing.Point(18, 47);
            this.label_TextoDoc.Name = "label_TextoDoc";
            this.label_TextoDoc.Size = new System.Drawing.Size(338, 237);
            this.label_TextoDoc.TabIndex = 2;
            this.label_TextoDoc.Text = "";
            // 
            // label_rotuloDoc
            // 
            this.label_rotuloDoc.AutoSize = true;
            this.label_rotuloDoc.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rotuloDoc.ForeColor = System.Drawing.Color.Blue;
            this.label_rotuloDoc.Location = new System.Drawing.Point(26, 19);
            this.label_rotuloDoc.Name = "label_rotuloDoc";
            this.label_rotuloDoc.Size = new System.Drawing.Size(64, 26);
            this.label_rotuloDoc.TabIndex = 1;
            this.label_rotuloDoc.Text = "Título";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(321, 280);
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
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(463, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ver lista";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel_Texto);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.panel_Links);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "The LusiSearch";
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formarVocabularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
        private System.Windows.Forms.Label label_rotuloDoc;
        private System.Windows.Forms.RichTextBox label_TextoDoc;
        private System.Windows.Forms.Button button1;
    }
}

