using ManipulacaoArquivos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulacaoArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_entrada.Text.Equals("") || txt_entrada.Text.Equals(""))
                MessageBox.Show("Selecione os caminhos de Entrada e Saida dos Arquivos");
            else
            {
                String[] arquivos = Directory.GetFiles(@""+txt_entrada.Text);
 
                if (che_excel.Checked)
                {
                    ConverterExcelToPdf excel = new(txt_entrada.Text, txt_entrada.Text, arquivos);
                    excel.Converter();
                }
                else if (che_word.Checked)
                {
                    ConverterWordToPdf word = new(txt_entrada.Text, txt_entrada.Text, arquivos);
                }
                else if (che_imagem.Checked)
                {
                    TratamentoImagens word = new(txt_entrada.Text, txt_entrada.Text);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog() == DialogResult.OK)
            {
                txt_entrada.Text = folder.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                txt_saida.Text = folder.SelectedPath;
            }
        }
    }
}
