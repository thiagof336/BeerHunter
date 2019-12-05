using BeerHunter.inter;
using BeerHunter.Model;
using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace BeerHunter.Service
{
    public class UtilidadesService : IUtilidadeService
       {
        private readonly BeerHunterContext _context;

        public UtilidadesService()
        {
            _context = new BeerHunterContext();
        }
        public IEnumerable BuscaCervejaBanco(string busca)
        {
            try
            {
                var query = from resultado in _context.Cerveja
                            join p in _context.CadastraCerveja on resultado.CervejaID equals p.CervejaID.CervejaID
                            join e in _context.Endereco on p.FornecedorID equals e.FornecedorID
                            join f in _context.Fornecedor on e.FornecedorID.FornecedorID equals f.FornecedorID
                            where resultado.NomeCerveja == busca
                            select new
                            {
                                codigoCerveja = resultado.CervejaID,
                                nomeCerveja = resultado.NomeCerveja,
                                preco = p.PrecoCerveja,
                                lupulo = resultado.Lupulo,
                                teorAlcolico = resultado.TeorAlcoolico,
                                nome = f.Nome
                            };

                return query.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable HistoricoBusca(int id)
        {
            var hostirco = from u in _context.Usuario
                           join a in _context.Avaliacaos on u.UsuarioID equals a.UsuarioID.UsuarioID
                           join c in _context.CadastraCerveja on a.CadastraCervejaID.CadastraCervejaID equals c.CadastraCervejaID
                           join b in _context.Cerveja on c.CervejaID.CervejaID equals b.CervejaID
                           join f in _context.Fornecedor on c.FornecedorID.FornecedorID equals f.FornecedorID
                           where u.UsuarioID == id
                           select new
                           {
                               NomeUsuario = u.Nome,
                               Comentario = a.Comentario,
                               NomeCerveja = b.NomeCerveja,
                               NomeFornecedor = f.Nome
                           };
            return hostirco.ToList();
        }
        public IEnumerable HistoricoAvaliacaoCerveja(int idCerveja)
        {
            var historicoCerveja = from c in _context.Cerveja
                                   join cad in _context.CadastraCerveja on c.CervejaID equals cad.CervejaID.CervejaID
                                   join a in _context.Avaliacaos on cad.CadastraCervejaID equals a.CadastraCervejaID.CadastraCervejaID
                                   join u in _context.Usuario on a.UsuarioID.UsuarioID equals u.UsuarioID
                                   join f in _context.Fornecedor on cad.FornecedorID.FornecedorID equals f.FornecedorID
                                   where c.CervejaID == idCerveja
                                   select new
                                   {
                                       NomeFornecedor = f.Nome,
                                       tipo = c.Tipo,
                                       preco = cad.PrecoCerveja,
                                       NomeUsuario = u.Nome,
                                       comentario = a.Comentario
                                   };
            return historicoCerveja.ToList();


            
        }
        public Fornecedor FornecedorExiste(String usuario,String senha)
        {
            var login = _context.Fornecedor.Where(p => p.Login == usuario && p.Senha == senha).FirstOrDefault();
            if (login == null)
            {
                return null;
            }
            return login;
        }
        public Usuario UsuarioExiste(String usuario, String senha)
        {
            var login = _context.Usuario.Where(p => p.Nomeusuario == usuario && p.Senha == senha).FirstOrDefault();
            if (login == null)
            {
                return null;
            }
            return login;
        }
        public string Criptografia(string senha)
        {
            string ChaveCripto;
            byte[] cript = Encoding.ASCII.GetBytes(senha);
            ChaveCripto = Convert.ToBase64String(cript);

            return ChaveCripto;
        }
        public string Descriptografar(string valor)
        {
            string chaveCripto;
            Byte[] cript = Convert.FromBase64String(valor);
            chaveCripto = System.Text.ASCIIEncoding.ASCII.GetString(cript);

            return chaveCripto;
        }







    }
}
