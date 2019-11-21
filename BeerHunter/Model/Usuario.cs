using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerHunter.Model
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Nomeusuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


    }




}
