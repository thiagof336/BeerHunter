using BeerHunter.inter;
using BeerHunter.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            where (resultado.NomeCerveja == busca)
                            select new { nomeCerveja = resultado.NomeCerveja, preco = p.PrecoCerveja };

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






    }
}
