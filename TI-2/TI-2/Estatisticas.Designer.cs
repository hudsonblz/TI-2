namespace TI_2
{
    partial class Estatisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_numDoc = new System.Windows.Forms.Label();
            this.label_tatalPalavras = new System.Windows.Forms.Label();
            this.label_totalVocab = new System.Windows.Forms.Label();
            this.label_tempoLeitura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de documentos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total de palavras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Palavras no vocabulário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tempo gasto para:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ler arquivos:";
            // 
            // label_numDoc
            // 
            this.label_numDoc.Location = new System.Drawing.Point(154, 49);
            this.label_numDoc.Name = "label_numDoc";
            this.label_numDoc.Size = new System.Drawing.Size(46, 13);
            this.label_numDoc.TabIndex = 5;
            this.label_numDoc.Text = "Não lido";
            // 
            // label_tatalPalavras
            // 
            this.label_tatalPalavras.AutoSize = true;
            this.label_tatalPalavras.Location = new System.Drawing.Point(154, 73);
            this.label_tatalPalavras.Name = "label_tatalPalavras";
            this.label_tatalPalavras.Size = new System.Drawing.Size(46, 13);
            this.label_tatalPalavras.TabIndex = 6;
            this.label_tatalPalavras.Text = "Não lido";
            // 
            // label_totalVocab
            // 
            this.label_totalVocab.AutoSize = true;
            this.label_totalVocab.Location = new System.Drawing.Point(154, 98);
            this.label_totalVocab.Name = "label_totalVocab";
            this.label_totalVocab.Size = new System.Drawing.Size(46, 13);
            this.label_totalVocab.TabIndex = 7;
            this.label_totalVocab.Text = "Não lido";
            // 
            // label_tempoLeitura
            // 
            this.label_tempoLeitura.AutoSize = true;
            this.label_tempoLeitura.Location = new System.Drawing.Point(148, 147);
            this.label_tempoLeitura.Name = "label_tempoLeitura";
            this.label_tempoLeitura.Size = new System.Drawing.Size(46, 13);
            this.label_tempoLeitura.TabIndex = 9;
            this.label_tempoLeitura.Text = "Não lido";
            // 
            // Estatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 254);
            this.Controls.Add(this.label_tempoLeitura);
            this.Controls.Add(this.label_totalVocab);
            this.Controls.Add(this.label_tatalPalavras);
            this.Controls.Add(this.label_numDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estatisticas";
            this.Text = "Estatísticas";
            this.Load += new System.EventHandler(this.Estatisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_numDoc;
        private System.Windows.Forms.Label label_tatalPalavras;
        private System.Windows.Forms.Label label_totalVocab;
        private System.Windows.Forms.Label label_tempoLeitura;
    }
}