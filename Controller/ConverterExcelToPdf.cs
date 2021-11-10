using AtomFrameworkCs;
using ManipulacaoArquivos.Model;
using ManipulacaoArquivos.Util;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
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
                int tipo = 1;

                if (arqui.Extensao.Equals("jpg") || arqui.Extensao.Equals("jpeg") || arqui.Extensao.Equals("png"))
                    tipo = 0;

                var client = new RestClient("http://127.0.0.1:8080/resizeimage");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Authorization", "Bearer 9c19l9kaplrcnpzowyph3wdtg804y2");
                request.AddHeader("Content-Type", "application/json");
                var body = "{ \"nome\": \"" + aux + "\", \"entrada\": \""+entrada+"\", \"saida\": \""+saida+"\", \"tipo\": "+tipo+" }";
                
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Arquivo: " + propriedadeArquivo);
                }
                
            }
            con.Close();
        }

        public void Converter(String entrada, String saida)
        {
            
        }
    }
}
