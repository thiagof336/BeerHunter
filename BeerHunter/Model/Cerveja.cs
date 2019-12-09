using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerHunter.Model
{
    public class Cerveja
    {
        [Key]
        public int CervejaID { get; set; }
        public string NomeCerveja { get; set; }
        public string Tipo { get; set; }
        public double TeorAlcoolico { get; set; }
        public string Lupulo { get; set; }
        public string Fabricante { get; set; }
    }
}
