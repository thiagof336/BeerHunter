using BeerHunter.Model;
using System;
using System.Collections;

namespace BeerHunter.inter
{
    public interface IUtilidadeService
    {
        Fornecedor FornecedorExiste(String usuario, String senha);
        Usuario UsuarioExiste(String usuario, String senha);
        IEnumerable BuscaCervejaBanco(string busca);
        IEnumerable HistoricoAvaliacaoCerveja(int idCerveja);
        IEnumerable HistoricoBusca(int id);
        string Criptografia(string senha);
        string Descriptografar(string valor);
        











    }
}
