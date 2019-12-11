using BeerHunter.inter;
using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class RealizarAvaliacao : MetroFramework.Forms.MetroForm
    {
        BeerHunterContext beerHunterContext;
        Avaliacao avaliacao;
        Usuario usuario;
        CadastraCerveja cadastraCerveja;
        private IUtilidadeService _utilidadeService;


        public RealizarAvaliacao(string nomeCerveja)
        {
            InitializeComponent();
            beerHunterContext = new BeerHunterContext();
            lblNomeUsuario.Text = Session.Instance.Nome.ToString();
            lblNomeCerveja.Text = nomeCerveja;
            usuario = beerHunterContext.Usuario.Find(Session.Instance.id);
            cadastraCerveja = beerHunterContext.CadastraCerveja.Find(Session.Instance.cadastraCerveja.CadastraCervejaID);
            _utilidadeService = new UtilidadesService();

        }
        private void RealizarAvaliacao_Load(object sender, EventArgs e)
        {
            avaliacao = new Avaliacao();
            DataGridHistorico.DataSource = _utilidadeService.HistoricoBusca(Session.Instance.id);
            var media = mediaAvaliacoes();
            lblNotaPreco.Text = Math.Round(media.Preco_N, 2).ToString();
            lblNotaLocal.Text = Math.Round(media.Local_N, 2).ToString();
            lblNotaTemperatura.Text = Math.Round(media.Temperatura_N, 2).ToString();
            string ImagePath = "https://res.cloudinary.com/beerhunter/image/upload/v1575746348/estrelas_hhzvs4.jpg";
            pictureBox2.ImageLocation = ImagePath;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.ImageLocation = ImagePath;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = ImagePath;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
             
            try
            {
                FotoUsuario.ImageLocation = usuario.ImagensID.EnderecoImagem;
                FotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
               
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNotaPreco.Text) || string.IsNullOrEmpty(txtNotaTemperatura.Text) || string.IsNullOrEmpty(txtNotaLocal.Text))
                {
                    MessageBox.Show("Preencha os campos vazios!!");
                }
                else
                {
                    avaliacao.UsuarioID = usuario;
                    avaliacao.CadastraCervejaID = cadastraCerveja;
                    avaliacao.Preco_N = double.Parse(txtNotaPreco.Text);
                    avaliacao.Local_N = double.Parse(txtNotaLocal.Text);
                    avaliacao.Temperatura_N = double.Parse(txtNotaTemperatura.Text);
                    avaliacao.Comentario = txtComentario.Text;
                    beerHunterContext.Avaliacaos.Add(avaliacao);
                    beerHunterContext.SaveChanges();
             
                    this.Hide();
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
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
            media.Local_N = (media.Local_N / listaMedia.Count());
            media.Preco_N = media.Preco_N / listaMedia.Count();
            media.Temperatura_N = media.Temperatura_N / listaMedia.Count();

            return media;
        }

        private void txtNotaPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }
        private void txtNotaPreco_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                txtNotaPreco.Text = Convert.ToDecimal(txtNotaPreco.Text).ToString("###,###.00");
                if (Convert.ToDecimal(txtNotaPreco.Text) < 0 || Convert.ToDecimal(txtNotaPreco.Text) > 10)
                {
                    MessageBox.Show("Nota inválida");
                    txtNotaPreco.Focus();
                }
            }
            catch (Exception)
            {

                
            }
        }
        private void txtNotaLocal_Validated(object sender, EventArgs e)
        {
            try
            {
                txtNotaLocal.Text = Convert.ToDecimal(txtNotaLocal.Text).ToString("###,###.00");
                if (Convert.ToDecimal(txtNotaLocal.Text) < 0 || Convert.ToDecimal(txtNotaLocal.Text) > 10)
                {
                    MessageBox.Show("Nota inválida");
                    txtNotaLocal.Focus();
                }
            }
            catch (Exception)
            {

                
            }
        }
        private void txtNotaLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }

        }

        private void txtNotaTemperatura_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                txtNotaTemperatura.Text = Convert.ToDecimal(txtNotaTemperatura.Text).ToString("###,###.00");
                if (Convert.ToDecimal(txtNotaTemperatura.Text) < 0 || Convert.ToDecimal(txtNotaTemperatura.Text) > 10)
                {
                    MessageBox.Show("Nota inválida");
                    txtNotaTemperatura.Focus();
                }

            }
            catch (Exception)
            {

                
            }
        }
        private void txtNotaTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }
    }
}
