using BeerHunter.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerHunter.inter
{
    public interface IUtilidadeService
    {
        Fornecedor FornecedorExiste(String usuario, String senha);
        Usuario UsuarioExiste(String usuario, String senha);
        IEnumerable BuscaCervejaBanco(string busca);
        string Criptografia(string senha);
        string Descriptografar(string valor);











    }
}
