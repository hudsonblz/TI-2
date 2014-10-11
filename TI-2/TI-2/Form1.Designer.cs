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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.panel_Texto = new System.Windows.Forms.Panel();
            this.label_TextoDoc = new System.Windows.Forms.Label();
            this.panel_Links.SuspendLayout();
            this.panel_Texto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Links
            // 
            this.panel_Links.AutoScroll = true;
            this.panel_Links.Controls.Add(this.linkLabel1);
            this.panel_Links.Location = new System.Drawing.Point(0, 78);
            this.panel_Links.Name = "panel_Links";
            this.panel_Links.Size = new System.Drawing.Size(315, 448);
            this.panel_Links.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(227, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Location = new System.Drawing.Point(9, 11);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(101, 13);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Do your search Bro!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(506, 37);
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
            this.panel_Texto.Location = new System.Drawing.Point(343, 79);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 526);
            this.Controls.Add(this.panel_Texto);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.panel_Links);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Links.ResumeLayout(false);
            this.panel_Links.PerformLayout();
            this.panel_Texto.ResumeLayout(false);
            this.panel_Texto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Links;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Panel panel_Texto;
        private System.Windows.Forms.Label label_TextoDoc;
    }
}

