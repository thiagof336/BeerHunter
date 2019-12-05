using BeerHunter.inter;
using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Windows.Forms;
using ViaCEP;

namespace BeerHunter.views
{
    public partial class Cadastro : Form
    {
        private IUtilidadeService _utilidadeService;
        BeerHunterContext beerHunterContext;
      
        public Cadastro()
        {
            InitializeComponent();
            _utilidadeService = new UtilidadesService();
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
                Endereco endereco = new Endereco();

                fornecedor.Nome = txtNomeFornecedor.Text;
                fornecedor.Senha = _utilidadeService.Criptografia(txtSenhaFornecedor.ToString());
                fornecedor.Login = txtLogin.Text;
                endereco.Bairro = txtBairro.Text;
                endereco.Localidade = txtLocalidade.Text;
                endereco.Logradouro = txtLogradouro.Text;
                endereco.Uf = txtEstado.Text;
                endereco.Cep = int.Parse(txtCEP.Text);
                endereco.Numero = (int.Parse(txtNumero.Text));

                fornecedor = beerHunterContext.Fornecedor.Add(fornecedor);
                endereco.FornecedorID = fornecedor;
                beerHunterContext.Endereco.Add(endereco);
                beerHunterContext.SaveChanges();
                MessageBox.Show("ok");
            }
            if (radioUsuario.Checked)
            {
                Usuario usuario = new Usuario();

                usuario.Nome = txtNome.Text;
                usuario.Senha = _utilidadeService.Criptografia(txtSenha.ToString());
                usuario.Nomeusuario = txtNomeUsuario.Text;
                usuario.Email = txtEmail.Text;
                
                beerHunterContext.Usuario.Add(usuario);
                beerHunterContext.SaveChanges();

                MessageBox.Show("ok");
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
      
        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txtCEP_TextChanged(object sender, EventArgs e)
        { 

        }
        private void txtCEP_Leave(object sender, EventArgs e)
        {
            var cep = ViaCEPClient.Search(txtCEP.Text);
            if (cep != null)
            {
                txtBairro.Text = cep.Neighborhood;
                txtEstado.Text = cep.StateInitials;
                txtLogradouro.Text = cep.Street;
                txtLocalidade.Text = cep.City;
                
            }
        }

        private void picBoxUsuario_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*.jpg|";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picBoxUsuario.ImageLocation = file.FileName;
                picBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void picBoxFornecedor_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*.jpg|";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picBoxFornecedor.ImageLocation = file.FileName;
                picBoxFornecedor.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
