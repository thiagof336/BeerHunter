using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerHunter.Model
{
    public class CadastraCerveja
    {
        [Key]
        public int CadastraCervejaID { get; set; }
        public virtual Cerveja CervejaID { get; set; }
        public virtual Fornecedor FornecedorID { get; set; }
        public double PrecoCerveja { get; set; }
    }
}
