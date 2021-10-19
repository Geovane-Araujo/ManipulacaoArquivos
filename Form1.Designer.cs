
namespace ManipulacaoArquivos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_entrada = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_saida = new System.Windows.Forms.TextBox();
            this.che_excel = new System.Windows.Forms.CheckBox();
            this.che_word = new System.Windows.Forms.CheckBox();
            this.che_imagem = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Trabalhar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho da Pasta de Entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caminho da Pasta de Saída";
            // 
            // txt_entrada
            // 
            this.txt_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_entrada.Location = new System.Drawing.Point(12, 26);
            this.txt_entrada.Name = "txt_entrada";
            this.txt_entrada.Size = new System.Drawing.Size(488, 23);
            this.txt_entrada.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(506, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(506, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_saida
            // 
            this.txt_saida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_saida.Location = new System.Drawing.Point(12, 83);
            this.txt_saida.Name = "txt_saida";
            this.txt_saida.Size = new System.Drawing.Size(488, 23);
            this.txt_saida.TabIndex = 5;
            // 
            // che_excel
            // 
            this.che_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.che_excel.AutoSize = true;
            this.che_excel.Location = new System.Drawing.Point(13, 129);
            this.che_excel.Name = "che_excel";
            this.che_excel.Size = new System.Drawing.Size(103, 19);
            this.che_excel.TabIndex = 7;
            this.che_excel.Text = "Excel para PDF";
            this.che_excel.UseVisualStyleBackColor = true;
            // 
            // che_word
            // 
            this.che_word.AutoSize = true;
            this.che_word.Location = new System.Drawing.Point(191, 129);
            this.che_word.Name = "che_word";
            this.che_word.Size = new System.Drawing.Size(105, 19);
            this.che_word.TabIndex = 8;
            this.che_word.Text = "Word para PDF";
            this.che_word.UseVisualStyleBackColor = true;
            // 
            // che_imagem
            // 
            this.che_imagem.AutoSize = true;
            this.che_imagem.Location = new System.Drawing.Point(378, 129);
            this.che_imagem.Name = "che_imagem";
            this.che_imagem.Size = new System.Drawing.Size(153, 19);
            this.che_imagem.TabIndex = 9;
            this.che_imagem.Text = "Redimensionar Imagens";
            this.che_imagem.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(264, 22);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 229);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.che_imagem);
            this.Controls.Add(this.che_word);
            this.Controls.Add(this.che_excel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_saida);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_entrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulador de Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_entrada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_saida;
        private System.Windows.Forms.CheckBox che_excel;
        private System.Windows.Forms.CheckBox che_word;
        private System.Windows.Forms.CheckBox che_imagem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

