using BeerHunter.Service;
using System.ComponentModel.DataAnnotations;

namespace BeerHunter.Model
{
    public class Cerveja
    {
        [Key]
        public int CervejaID { get; set; }
        public virtual ImagensNuvem ImagensID { get; set; }
        public string NomeCerveja { get; set; }
        public string Tipo { get; set; }
        public double TeorAlcoolico { get; set; }
        public string Lupulo { get; set; }
        public string Fabricante { get; set; }
    }
}
