using BeerHunter.inter;
using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Diagnostics;
using System.Web.UI.MobileControls;
using System.Windows.Forms;
using ViaCEP;
using System.Linq;

namespace BeerHunter.views
{
    public partial class Cadastro : MetroFramework.Forms.MetroForm
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
            txt_Nome.Enabled = true;
            txt_Email.Enabled = true;
            txt_NomeUsuario.Enabled = true;
            txt_Senha.Enabled = true;
            txt_CEP.Enabled = false;
            txt_Estado.Enabled = false;
            txt_Bairro.Enabled = false;
            txt_NomeFornecedor.Enabled = false;
            txt_Login.Enabled = false;
            txt_SenhaFornecedor.Enabled = false;
            txt_Logradouro.Enabled = false;
            txt_Estado.Enabled = false;
            txt_Numero.Enabled = false;
            txt_Localidade.Enabled = false;
        }

        private void RadioFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nome.Enabled = false;
            txt_Email.Enabled = false;
            txt_NomeUsuario.Enabled = false;
            txt_Senha.Enabled = false;
            txt_CEP.Enabled = true;
            txt_Estado.Enabled = true;
            txt_Bairro.Enabled = true;
            txt_NomeFornecedor.Enabled = true;
            txt_Login.Enabled = true;
            txt_SenhaFornecedor.Enabled = true;
            txt_Logradouro.Enabled = true;
            txt_Estado.Enabled = true;
            txt_Numero.Enabled = true;
            txt_Localidade.Enabled = true;   
        }

        public void btnMetroSalvar_Click(object sender, EventArgs e)
        {
            beerHunterContext = new BeerHunterContext();

            if (radioFornecedor.Checked)
            {
                try
                {
                    Fornecedor fornecedor = new Fornecedor();
                    Endereco endereco = new Endereco();
                    if (!string.IsNullOrEmpty(txt_NomeFornecedor.Text) || !string.IsNullOrEmpty(txt_SenhaFornecedor.Text)  || !string.IsNullOrEmpty(txt_CEP.Text) || !string.IsNullOrEmpty(txt_Login.Text))
                    {
                        MessageBox.Show("Preencha os campos vazios!!!");
                        
                    }
                    else
                    {
                        fornecedor.Nome = txt_NomeFornecedor.Text;
                        fornecedor.Senha = _utilidadeService.Criptografia(txt_SenhaFornecedor.Text);
                        fornecedor.Login = txt_Login.Text;
                        endereco.Bairro = txt_Bairro.Text;
                        endereco.Localidade = txt_Localidade.Text;
                        endereco.Logradouro = txt_Logradouro.Text;
                        endereco.Uf = txt_Estado.Text;
                        endereco.Cep = int.Parse(txt_CEP.Text);
                        endereco.Numero = (int.Parse(txt_Numero.Text));

                        fornecedor.ImagensID = _utilidadeService.uploadImagem(picBoxFornecedor.ImageLocation);

                        fornecedor = beerHunterContext.Fornecedor.Add(fornecedor);
                        endereco.FornecedorID = fornecedor;
                        beerHunterContext.Endereco.Add(endereco);
                        beerHunterContext.SaveChanges();
                        MessageBox.Show("ok");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (radioUsuario.Checked)
            {
                
                try
                {
                    Usuario usuario = new Usuario();

                    if (!string.IsNullOrEmpty(txt_Nome.Text) || !string.IsNullOrEmpty(txt_NomeUsuario.Text) || !string.IsNullOrEmpty(txt_Senha.Text)  || !string.IsNullOrEmpty(txt_Email.Text) )
                    {
                        MessageBox.Show("Preencha os campos Vazios");
                    }
                    else
                    {
                        usuario.Nome = txt_Nome.Text;
                        usuario.Senha = _utilidadeService.Criptografia(txt_Senha.Text);
                        usuario.Nomeusuario = txt_NomeUsuario.Text;
                        usuario.Email = txt_Email.Text;

                        usuario.ImagensID = _utilidadeService.uploadImagem(picBoxUsuario.ImageLocation);

                        beerHunterContext.Usuario.Add(usuario);
                        beerHunterContext.SaveChanges();

                        
                        MessageBox.Show("ok");
                    }
                }
                catch (Exception)
                {

                }                
            }
        }
        private void btnMetroVoltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
      
        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txt_CEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txt_CEP_Leave(object sender, EventArgs e)
        {
            try
            {
                var cep = ViaCEPClient.Search(txt_CEP.Text);
                if (cep != null)
                {
                    txt_Bairro.Text = cep.Neighborhood;
                    txt_Estado.Text = cep.StateInitials;
                    txt_Logradouro.Text = cep.Street;
                    txt_Localidade.Text = cep.City;
                }
            }
            catch (Exception)
            {    
                
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

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            if (_utilidadeService.ValidarEmail(txt_Email.Text) == false)
            {
                MessageBox.Show("Email Invalido!!");
            }
        }

        private void txt_NomeUsuario_Leave(object sender, EventArgs e)
        { 
            var validaUsuario = _utilidadeService.ValidarNomeDeUsuario(txt_NomeUsuario.Text);
            if (validaUsuario)
            {
                MessageBox.Show("Nome de Usuario Existente!!");
            }
        }

        private void txt_Login_Leave(object sender, EventArgs e)
        {
            var validaLoginFornecedor = _utilidadeService.ValidaLoginFornecedor(txt_Login.Text);
            if (validaLoginFornecedor)
            {
                MessageBox.Show("login existente!!");
            }
        }
    }
}
