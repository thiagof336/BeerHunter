using BeerHunter.Service;
using BeerHunter.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerHunter
{
    public partial class Login : Form
    {
        private static Form current;
        private Cadastro cadastro;
        private BeerHunterContext dBcontext;

        public static Form Current { get => current; set => current = value; }

        public Login()
        {
            InitializeComponent();
            current = this;
            dBcontext = new BeerHunterContext();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Btn_cadastro_Click(object sender, EventArgs e)
        {
            cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
               
                string usuario = txtNomeUsuario.Text;
                string senha = txtSenha.Text;
                Util util = new Util();
                if (radioUsuario.Checked)
                {
                    if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                    {
                        MessageBox.Show("usuario e senha de preenchimento obrigatorio");
                        return;
                    }
                    else
                    {
                        var login = dBcontext.Usuario.Where(p => p.Nomeusuario == usuario && p.Senha == senha).FirstOrDefault();
                        if (login == null)
                        {
                            MessageBox.Show("usuario ou senha incorreto");
                            return;
                        }
                        util.id = login.UsuarioID;
                        util.tipo = "Cliente";
                        util.dtLogin = DateTime.Now;
                        BuscaDeCervejaUsuario janela = new BuscaDeCervejaUsuario(util);
                        this.Hide();
                        janela.ShowDialog();
                        this.Show();
                    }
                }
                else if (radioFornecedor.Checked)
                {
                    if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                    {
                        MessageBox.Show("usuario e senha de preenchimento obrigatorio");
                        return;
                    }
                    else
                    {
                        var login = dBcontext.Fornecedor.Where(p => p.Login == usuario && p.Senha == senha).FirstOrDefault();
                        if (login == null)
                        {
                            MessageBox.Show("Usuario e senha incorreto");
                            return;
                        }
                        else
                        {
                            util.id = login.FornecedorID;
                            util.tipo = "Fornecedor";
                            util.dtLogin = DateTime.Now;
                            CadastroCerveja janelaCadastro = new CadastroCerveja(util);
                            this.Hide();
                            janelaCadastro.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro na solicitação");
            }
            
        }
    }
}
