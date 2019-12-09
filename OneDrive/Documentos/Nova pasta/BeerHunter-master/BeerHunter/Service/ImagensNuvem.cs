using System.ComponentModel.DataAnnotations;

namespace BeerHunter.Service
{

    public class ImagensNuvem
    {
        [Key]
        public int ImagensNuvemID { get; set; }
        public string EnderecoImagem { get; set; }
        public string IdApi { get; set; }

    }
}
