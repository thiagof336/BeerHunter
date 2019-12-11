using BeerHunter.inter;
using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class CadastroCerveja : MetroFramework.Forms.MetroForm
    {
        BeerHunterContext beerHunterContext;
        private IUtilidadeService _utilidadeService;
        Fornecedor Fornecedor;
        public CadastroCerveja()
        {
            InitializeComponent();
            beerHunterContext = new BeerHunterContext();
            _utilidadeService = new UtilidadesService();
            Fornecedor = beerHunterContext.Fornecedor.Find(Session.Instance.id);
        }
        private void btnCadastrarCerveja_Click(object sender, EventArgs e)
        {

            Cerveja cerveja = new Cerveja();
            CadastraCerveja precoCerveja = new CadastraCerveja();

            cerveja.NomeCerveja = txt_Nome.Text.Trim();
            cerveja.Tipo = txt_Tipo.Text.Trim();
            cerveja.Fabricante = txt_Fabricante.Text.Trim();
            cerveja.TeorAlcoolico = double.Parse(txt_Teoralcolico.Text);
            cerveja.Lupulo = txt_Lupulo.Text.Trim();
            precoCerveja.PrecoCerveja = double.Parse(txt_Preco.Text);
            cerveja.ImagensID = _utilidadeService.uploadImagem(picboxLogoCerveja.ImageLocation);
            beerHunterContext.Cerveja.Add(cerveja);
            beerHunterContext.CadastraCerveja.Add(precoCerveja);
            precoCerveja.CervejaID = cerveja;
            precoCerveja.FornecedorID = Fornecedor;
            beerHunterContext.CadastraCerveja.Add(precoCerveja);
            beerHunterContext.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCarregatFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*.jpg|";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picboxLogoCerveja.ImageLocation = file.FileName;
                picboxLogoCerveja.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txt_Preco_Leave(object sender, EventArgs e)
        {
            try
            {
                txt_Preco.Text = Convert.ToDouble(txt_Preco.Text).ToString("F");
            }
            catch (Exception)
            {

            }  
        }
        private void txt_Preco_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                   (e.KeyChar != ',' && e.KeyChar != '.' &&
                    e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
                {
                    e.KeyChar = (Char)0;
                }
                else
                {
                    if (e.KeyChar == '.' || e.KeyChar == ',')
                    {
                        if (!txt_Preco.Text.Contains(","))
                        {
                            e.KeyChar = ',';
                        }
                        else
                        {
                            e.KeyChar = (Char)0;
                        }
                    }
                }
            }
        }

        private void txt_Teoralcolico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txt_Teoralcolico.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            using (Form form = new EditaCerveja())
            {
                this.Hide();
                form.ShowDialog();
            }
            this.Show();
        }
    }
}   
