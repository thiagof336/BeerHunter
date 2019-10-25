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
        private Cadastro cadastro;
        private BeerHunterContext dBcontext; 
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_cadastro_Click(object sender, EventArgs e)
        {
            cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            dBcontext = new BeerHunterContext();
            string usuario = txtNomeUsuario.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("usuario e senha de preenchimento obrigatorio");
                return;
            }
            else
            {
                var login = dBcontext.Usuario.Select(p => p.Nomeusuario == usuario && p.Senha == senha);
                if (login != null)
                {
                    MessageBox.Show("usuario ou senha incorreto");
                    return;
                }

                MessageBox.Show("OK");
            }

         
        }
    }
}
