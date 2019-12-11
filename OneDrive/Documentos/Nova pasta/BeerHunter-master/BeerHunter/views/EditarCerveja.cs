using BeerHunter.inter;
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
    public partial class EditarCerveja : MetroFramework.Forms.MetroForm
    {
        private BeerHunterContext _context;
        private IUtilidadeService _utilidadeService;
        private Cerveja _cerveja;
        private CadastraCerveja _CadastraCerveja;
        private Boolean editouImage = false;
        
        public EditarCerveja(Cerveja cerveja)
        {
            InitializeComponent();
            _context = new BeerHunterContext();
            _utilidadeService = new UtilidadesService();
            _cerveja = cerveja;

            _CadastraCerveja = _context.CadastraCerveja.Where(p => p.CervejaID.CervejaID == cerveja.CervejaID).FirstOrDefault();
            var imagem = _context.ImagensNuvems.Find(cerveja.ImagensID.ImagensNuvemID) ;
            txt_Nome.Text = cerveja.NomeCerveja;
            txt_Fabricante.Text = cerveja.Fabricante;
            txt_Preco.Text = _CadastraCerveja.PrecoCerveja.ToString();
            txt_Lupulo.Text = cerveja.Lupulo;
            txt_Teoralcolico.Text = cerveja.TeorAlcoolico.ToString();
            txt_Tipo.Text = cerveja.Tipo;
            if(imagem != null)
            {
                picboxLogoCerveja.ImageLocation = imagem.EnderecoImagem;
                picboxLogoCerveja.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            _cerveja.NomeCerveja = txt_Nome.Text.Trim();
            _cerveja.Tipo = txt_Tipo.Text.Trim();
            _cerveja.Fabricante = txt_Fabricante.Text.Trim();
            _cerveja.TeorAlcoolico = double.Parse(txt_Teoralcolico.Text);
            _cerveja.Lupulo = txt_Lupulo.Text.Trim();

            if (editouImage)
            {
                _cerveja.ImagensID = _utilidadeService.uploadImagem(picboxLogoCerveja.ImageLocation);
            }

            _CadastraCerveja.PrecoCerveja = double.Parse(txt_Preco.Text);

            _utilidadeService.updateCerveja(_cerveja);
            _utilidadeService.updatePrecoCerveja(_CadastraCerveja);
            
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
            editouImage = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                picboxLogoCerveja.ImageLocation = file.FileName;
                picboxLogoCerveja.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
