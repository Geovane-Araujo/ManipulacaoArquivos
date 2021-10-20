using AtomFrameworkCs;
using ManipulacaoArquivos.Model;
using ManipulacaoArquivos.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos.Controller
{
    class ConverterExcelToPdf
    {
        string entrada = "";
        string saida = "";
        string[] arquivos;

        public ConverterExcelToPdf()
        {

        }
        public ConverterExcelToPdf(String entrada, String saida, String[] arquivos)
        {
            this.entrada = entrada;
            this.saida = saida;
            this.arquivos = arquivos;
        }

        public void Converter()
        {
            Conexao conxao = new();
            SqlConnection con = conxao.NewInstance("importArquivo");
            Arquivos arqui = new();
            foreach(String arquivo in arquivos)
            {
                String aux = arquivo.Replace(entrada + "\\", "");
                String[] propriedadeArquivo = aux.Split(".");
                arqui.Extensao = propriedadeArquivo[1];
                arqui.NomeCompleto = propriedadeArquivo[0];

                
                // Atom.InsertedOne(arqui, con);
                Console.WriteLine(arquivo);
            }
            con.Close();
        }
    }
}
