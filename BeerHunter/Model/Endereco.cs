using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerHunter.Model
{
    public class Endereco
    {
        public virtual Fornecedor FornecedorID { get; set; }
        public int EnderecoID { get; set; }
        public string Bairro { get; set; }
        public Int32 Cep { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }

    }
}
