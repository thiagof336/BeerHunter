using BeerHunter.inter;
using BeerHunter.Model;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using Dapper;
using System.Collections.Generic;
using Npgsql;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Text.RegularExpressions;

namespace BeerHunter.Service
{
    public class UtilidadesService : IUtilidadeService
       {
        private readonly BeerHunterContext _context;
        private static string conn;
        private static Account account = new Account(
                              "beerhunter",
                              "375634236959668",
                              "VGmQKBrynXhuSdKTv40Cee56_M0");

        public UtilidadesService()
        {
            _context = new BeerHunterContext();
            conn = _context.Database.Connection.ConnectionString;
        }
        public IEnumerable<MediaAvaliacoes> Medias(int cerveja_id)
        {
            try
            {
                IEnumerable<MediaAvaliacoes> avaliacoes = null;
                using (var con = new NpgsqlConnection(conn))
                {
                    string sql = "select \"Preco_N\", \"Local_N\", \"Temperatura_N\" from dbo.\"Avaliacaos\" " +
                        "join dbo.\"CadastraCervejas\" on \"CadastraCervejaID_CadastraCervejaID\" = \"CadastraCervejaID\" " +
                        "join dbo.\"Cervejas\" on \"CervejaID_CervejaID\" = \"CervejaID\" "+
                        "where \"CervejaID\" = "+cerveja_id;
                    avaliacoes = con.Query<MediaAvaliacoes>(sql);
                }
                return avaliacoes;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public Boolean  ValidarNomeDeUsuario(string nomeUsuario)
        {
            try
            {
                int validaNome = 0;
                
                using(var con = new NpgsqlConnection(conn))
                {
                    string sql = "SELECT \"Nomeusuario\" "
                                + "FROM dbo.\"Usuarios\""
                                + "where \"Nomeusuario\" = '" + nomeUsuario + "'";
                    validaNome = con.Query(sql).Count();
                }
                if(validaNome != 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
                
            }        
        }
        public Boolean ValidaLoginFornecedor(string loginUsuario)
        {
            try
            {
                int validaNome = 0;

                using (var con = new NpgsqlConnection(conn))
                {
                    string sql = "SELECT \"Nome\" "
                                + "FROM dbo.\"Fornecedors\""
                                + "where \"Nome\" = '" + loginUsuario + "'";
                    validaNome = con.Query(sql).Count();
                }
                if (validaNome != 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;

            }

        }
        public IEnumerable<Resultado> BuscaCervejaBanco(string busca,string coluna)
        {
            try
            {
                IEnumerable<Resultado> retorno = null;
                using (var con = new NpgsqlConnection(conn))
                {
                    string sql = "SELECT c.\"CervejaID\", c.\"NomeCerveja\", cc.\"PrecoCerveja\", c.\"Lupulo\", c.\"TeorAlcoolico\",f.\"Nome\" "
                            + "FROM dbo.\"Cervejas\" c "
                            + "join dbo.\"CadastraCervejas\" cc on c.\"CervejaID\" = cc.\"CervejaID_CervejaID\" "
                            + "join dbo.\"Enderecoes\" ed on ed.\"FornecedorID_FornecedorID\" = cc.\"FornecedorID_FornecedorID\" "
                            + "join dbo.\"Fornecedors\" f on f.\"FornecedorID\" = cc.\"FornecedorID_FornecedorID\" "
                            + "where "+ coluna +" = '"+busca+"'";

                    retorno = con.Query<Resultado>(sql);
                }
                
                return retorno;              
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
        
        public bool ValidarEmail(String email)
        {
            bool emailValido = false;

            string emailRegex = string.Format("{0}{1}",
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))",
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            try
            {
                emailValido = Regex.IsMatch(
                    email,
                    emailRegex);
            }
            catch (RegexMatchTimeoutException)
            {
                emailValido = false;
            }

            return emailValido;
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
        public ImagensNuvem uploadImagem(string url)
        {
            try
            {
                Cloudinary cloudinary = new Cloudinary(account);

                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(url)
                };
                var uploadResult = cloudinary.Upload(uploadParams);

                ImagensNuvem imagensNuvem = new ImagensNuvem();

                imagensNuvem.EnderecoImagem = uploadResult.Uri.AbsoluteUri;
                imagensNuvem.IdApi = uploadResult.PublicId;

                imagensNuvem = _context.ImagensNuvems.Add(imagensNuvem);

                return imagensNuvem;
            }catch(Exception)
            {                
                return null;
            }
            
        }








    }
}
