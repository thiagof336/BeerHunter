using BeerHunter.inter;
using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class telaAvaliacao : MetroFramework.Forms.MetroForm
    {
        protected string _nomeCerveja, _preco, _teorAlcolico, _lupulo;
        private IUtilidadeService _utilidadeService;
        private readonly BeerHunterContext context;
        private RealizarAvaliacao realizarAvaliacao;
        private Cerveja cerveja;

        private void btn_voltar_Click(object sender, EventArgs e)
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
            context = new BeerHunterContext();
            cerveja = context.Cerveja.Find(Session.Instance.cadastraCerveja.CervejaID.CervejaID);
            _utilidadeService = new UtilidadesService();
        }

        private void Avaliacao_Load(object sender, EventArgs e)
        {
            lb_NomeCerveja.Text = _nomeCerveja;
            lbl_Preco.Text = ("preco:R$ "+ _preco);
            lbl_TeorAlcolico.Text = ("Teor Alcolico: "+_teorAlcolico + "%");
            lbl_Lupulo.Text = ("lupulo: " + _lupulo);

            string ImagePath = "https://res.cloudinary.com/beerhunter/image/upload/v1575746348/estrelas_hhzvs4.jpg";

            //string ImagePath = "/imagens/estrelas.png";
            pictureBox2.ImageLocation = ImagePath;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = ImagePath;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = ImagePath;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            gridHistoricoAvaliacaoCerveja.DataSource = _utilidadeService.HistoricoAvaliacaoCerveja(Session.Instance.cadastraCerveja.CadastraCervejaID);
            var media = mediaAvaliacoes();
            lbl_Npreco.Text = Math.Round(media.Preco_N,2).ToString();
            lbl_NLocal.Text = Math.Round(media.Local_N,2).ToString();
            lbl_NTemperatura.Text = Math.Round(media.Temperatura_N,2).ToString();
            try
            {
                FotoCerveja.ImageLocation = cerveja.ImagensID.EnderecoImagem;
                FotoCerveja.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

            }
        }
        private void btn_avaliar_Click(object sender, EventArgs e)
        {
            realizarAvaliacao = new RealizarAvaliacao(_nomeCerveja);
            realizarAvaliacao.ShowDialog();
            this.Show();
        }
        private MediaAvaliacoes mediaAvaliacoes()
        {
            var listaMedia = _utilidadeService.Medias((Session.Instance.cadastraCerveja.CadastraCervejaID));

            var media = new MediaAvaliacoes();
            foreach (var item in listaMedia)
            {
                media.Local_N += item.Local_N;
                media.Preco_N += item.Preco_N;
                media.Temperatura_N += item.Temperatura_N;
            }
            media.Local_N = media.Local_N / listaMedia.Count();
            media.Preco_N = media.Preco_N / listaMedia.Count();
            media.Temperatura_N = media.Temperatura_N / listaMedia.Count();

                return media;
        }
    }
}
