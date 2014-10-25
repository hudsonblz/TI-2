namespace TI_2
{
    partial class Splash
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
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Operacao = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.ForeColor = System.Drawing.Color.Blue;
            this.label_Titulo.Location = new System.Drawing.Point(120, 34);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(254, 45);
            this.label_Titulo.TabIndex = 2;
            this.label_Titulo.Text = "The LusiSearch";
            // 
            // label_Operacao
            // 
            this.label_Operacao.AutoSize = true;
            this.label_Operacao.Location = new System.Drawing.Point(55, 98);
            this.label_Operacao.Name = "label_Operacao";
            this.label_Operacao.Size = new System.Drawing.Size(96, 13);
            this.label_Operacao.TabIndex = 3;
            this.label_Operacao.Text = "Abrindo buscador..";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(58, 142);
            this.progressBar1.Maximum = 1108;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 30);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 211);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_Operacao);
            this.Controls.Add(this.label_Titulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Operacao;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}