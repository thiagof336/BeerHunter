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
        public IEnumerable BuscaCervejaBanco(string b)
        {
            string busca = b;
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
