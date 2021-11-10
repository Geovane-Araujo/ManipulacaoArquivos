using ManipulacaoArquivos.Controller;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
               
 
                if (che_excel.Checked)
                {
                    String[] arquivos = Directory.GetFiles(@"" + txt_entrada.Text);
                    ConverterExcelToPdf excel = new(txt_entrada.Text, txt_saida.Text, arquivos);
                    excel.Converter();
                }
                else if (che_word.Checked)
                {

                    while (true)
                    {
                        Thread t = new Thread(Estresse);
                        t.Start();
                    }
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

        public void Estresse()
        {
            var client = new RestClient("http://127.0.0.1:8080");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 9c19l9kaplrcnpzowyph3wdtg804y2");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
