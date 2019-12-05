using BeerHunter.inter;
using BeerHunter.Service;
using BeerHunter.views;
using System;
using System.Windows.Forms;

namespace BeerHunter
{
    public partial class Login : Form
    {
        private static Form current;
        private Cadastro cadastro;
        private BeerHunterContext dBcontext;
        private IUtilidadeService _utilidadeService;
        public static Form Current { get => current; set => current = value; }

        public Login()
        {
            InitializeComponent();
            current = this;
            dBcontext = new BeerHunterContext();
            _utilidadeService = new UtilidadesService();
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
                string usuario = txtNomeUsuario.Text;
                string senha = _utilidadeService.Criptografia(txtSenha.ToString());
            if (radioUsuario.Checked)
            {
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
                {
                    MessageBox.Show("usuario e senha de preenchimento obrigatorio");
                    return;
                }
                else
                {
                    var login = _utilidadeService.UsuarioExiste(usuario, senha);
                    if (login != null)
                    {
                        Session.Instance.id = login.UsuarioID;
                        Session.Instance.tipo = "Cliente";
                        Session.Instance.dtLogin = DateTime.Now;
                        Session.Instance.Nome = login.Nome;
                        BuscaDeCervejaUsuario janela = new BuscaDeCervejaUsuario();
                        this.Hide();
                        janela.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("usuario ou senha incorreto");
                        return;
                    }
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
                    var login = _utilidadeService.FornecedorExiste(usuario, senha);
                    if (login == null)
                    {
                        MessageBox.Show("Usuario e senha incorreto");
                        return;
                    }
                    else
                    {
                        Session.Instance.id = login.FornecedorID;
                        Session.Instance.tipo = "Fornecedor";
                        Session.Instance.dtLogin = DateTime.Now;
                        Session.Instance.Nome = login.Nome;
                        CadastroCerveja janelaCadastro = new CadastroCerveja();
                        this.Hide();
                        janelaCadastro.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}
