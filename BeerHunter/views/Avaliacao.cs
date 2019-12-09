using BeerHunter.inter;
using BeerHunter.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class telaAvaliacao : Form
    {
        protected string _nomeCerveja, _preco, _teorAlcolico, _lupulo;
        protected readonly IUtilidadeService _utilidadeService;
        private RealizarAvaliacao realizarAvaliacao;

        private void btnVoltarTelaCadastro_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public telaAvaliacao(string nomeCerveja, string preco, string teorAlcolico, string lupulo)
        {
            _preco = preco;
            _nomeCerveja = nomeCerveja;
            _teorAlcolico = teorAlcolico;
            _lupulo = lupulo;
            InitializeComponent();
        }
        private void Avaliacao_Load(object sender, EventArgs e)
        {
            lbNomeCerveja.Text = _nomeCerveja;
            lblPreco.Text = ("preco: "+ _preco);
            lblTeorAlcolico.Text = ("Teor Alcolico: "+_teorAlcolico);
            lblLupulo.Text = ("lupulo: " + _lupulo);
            string ImagePath = "C:/Users/Diego/source/repos/BeerHunter/imagens/estrelas.png";
            pictureBox2.Image = Image.FromFile(ImagePath);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Image.FromFile(ImagePath);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Image.FromFile(ImagePath);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            realizarAvaliacao = new RealizarAvaliacao(_nomeCerveja);
            realizarAvaliacao.ShowDialog();
            this.Show();
        }
    }
}
