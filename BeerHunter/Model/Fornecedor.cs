using System.ComponentModel.DataAnnotations;

namespace BeerHunter.Model
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}
