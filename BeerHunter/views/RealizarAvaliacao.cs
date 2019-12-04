using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class RealizarAvaliacao : Form
    {
        BeerHunterContext beerHunterContext;
        Avaliacao avaliacao;
        Usuario usuario;
        CadastraCerveja cadastraCerveja;
        

        public RealizarAvaliacao(string nomeCerveja)
        {
            InitializeComponent();
            beerHunterContext = new BeerHunterContext();
            lblNomeUsuario.Text = Session.Instance.Nome.ToString();
            lblNomeCerveja.Text = nomeCerveja;
            usuario = beerHunterContext.Usuario.Find(Session.Instance.id);
            cadastraCerveja = beerHunterContext.CadastraCerveja.Find(Session.Instance.cadastraCerveja.CadastraCervejaID);


        }
        private void RealizarAvaliacao_Load(object sender, EventArgs e)
        {
            avaliacao = new Avaliacao();
        }

        private void btnVoltarAvaliacao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            avaliacao.UsuarioID = usuario;
            avaliacao.CadastraCervejaID = cadastraCerveja;
            avaliacao.Preco_N = double.Parse(txtNotaPreco.Text);
            avaliacao.Local_N = double.Parse(txtNotaLocal.Text);
            avaliacao.Temperatura_N = double.Parse(txtNotaTemperatura.Text);
           
        }

    }
}
