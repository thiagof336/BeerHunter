using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerHunter.Model
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorID { get; set; }
        public string Nome { get; set; }
        public string login { get; set; }
        public string senha { get; set;  } 

        
    }
}
