using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class Cadastro : Form
    {
        BeerHunterContext beerHunterContext;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Usuario_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtNomeUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtCEP.Enabled = false;
            txtEstado.Enabled = false;
            txtBairro.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtLogin.Enabled = false;
            txtSenhaFornecedor.Enabled = false;
            txtLogradouro.Enabled = false;
            txtEstado.Enabled = false;
            txtNumero.Enabled = false;
            txtLocalidade.Enabled = false;
        }

        private void RadioFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtNomeUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtCEP.Enabled = true;
            txtEstado.Enabled = true;
            txtBairro.Enabled = true;
            txtNomeFornecedor.Enabled = true;
            txtLogin.Enabled = true;
            txtSenhaFornecedor.Enabled = true;
            txtLogradouro.Enabled = true;
            txtEstado.Enabled = true;
            txtNumero.Enabled = true;
            txtLocalidade.Enabled = true;   
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            beerHunterContext = new BeerHunterContext();
            if (radioFornecedor.Checked)
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.Nome = txtNomeFornecedor.Text;
                fornecedor.senha = txtSenhaFornecedor.Text;
                fornecedor.login = txtLogin.Text; 

                beerHunterContext.Fornecedor.Add(fornecedor);
                beerHunterContext.SaveChanges();
                MessageBox.Show("ok");
            }
            if (radioUsuario.Checked)
            {
                Usuario usuario = new Usuario()
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Nomeusuario = txtNomeUsuario.Text,
                    Senha = txtSenha.Text
                };

                beerHunterContext.Usuario.Add(usuario);
                beerHunterContext.SaveChanges();

                MessageBox.Show("ok");
            }


        }
    }
}
