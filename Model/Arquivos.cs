using AtomFrameworkCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoArquivos.Model
{
    [Alias("arquivos")]
    class Arquivos
    {
        [Id]
        public int ID { get; set; }
        public string NomeCompleto { get; set; }
        public string Extensao { get; set; }
    }
}
