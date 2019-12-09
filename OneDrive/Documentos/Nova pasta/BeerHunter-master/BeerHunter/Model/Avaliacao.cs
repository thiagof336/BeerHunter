using BeerHunter.Service;
using System.ComponentModel.DataAnnotations;

namespace BeerHunter.Model
{
    public class Avaliacao
    {
        [Key]
        public int AvaliacaoID { get; set; }
        public virtual Usuario UsuarioID { get; set; }
        public virtual CadastraCerveja CadastraCervejaID { get; set; }
        public virtual ImagensNuvem ImagensID { get; set; }
        public double Preco_N { get; set; }
        public double Local_N { get; set; }
        public double Temperatura_N { get; set; }
        public string Comentario { get; set; }

    }
}
