using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BeerHunter.inter
{
    public interface IUtilidadeService
    {
        Fornecedor FornecedorExiste(String usuario, String senha);
        Usuario UsuarioExiste(String usuario, String senha);
        IEnumerable<Resultado> BuscaCervejaBanco(string busca,string coluna);
        IEnumerable<MediaAvaliacoes> Medias(int cerveja_id);
        IEnumerable HistoricoAvaliacaoCerveja(int idCerveja);
        IEnumerable HistoricoBusca(int id);
        string Criptografia(string senha);
        string Descriptografar(string valor);
        ImagensNuvem uploadImagem(string url);
        public bool ValidarEmail(String email);
        public Boolean ValidarNomeDeUsuario(string nomeUsuario);
        public Boolean ValidaLoginFornecedor(string loginUsuario);

    }
}
