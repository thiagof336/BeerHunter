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
    public partial class CadastroCerveja : Form
    {
        BeerHunterContext beerHunterContext;
        private readonly Util util;
        private readonly Fornecedor fornecedor;
        public CadastroCerveja(Util util)
        {
            InitializeComponent();
            beerHunterContext = new BeerHunterContext();
            this.util = util;
            fornecedor = beerHunterContext.Fornecedor.Find(util.id);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            Cerveja cerveja = new Cerveja();
            CadastraCerveja precoCerveja = new CadastraCerveja();

            cerveja.NomeCerveja = txtNome.Text;
            cerveja.Tipo = txtTipo.Text;
            cerveja.Fabricante = txtFabricante.Text;
            cerveja.TeorAlcoolico = double.Parse(txtTeoralcolico.Text);
            cerveja.Lupulo = txtLupulo.Text;
            precoCerveja.PrecoCerveja = double.Parse(txtPreco.Text);
            
            beerHunterContext.Cerveja.Add(cerveja);
            beerHunterContext.CadastraCerveja.Add(precoCerveja);
            precoCerveja.CervejaID = cerveja;
            precoCerveja.FornecedorID = fornecedor;
            beerHunterContext.CadastraCerveja.Add(precoCerveja);

            beerHunterContext.SaveChanges();


        }
        private void btnVoltarMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "*.jpg|";
            if(file.ShowDialog() == DialogResult.OK)
            {
                picboxLogoCerveja.ImageLocation = file.FileName;
                picboxLogoCerveja.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
