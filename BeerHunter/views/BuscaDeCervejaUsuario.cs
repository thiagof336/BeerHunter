using BeerHunter.Model;
using BeerHunter.Service;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class BuscaDeCervejaUsuario : Form
    {
        private readonly BeerHunterContext context;
        Util _util;
        private readonly Usuario usuario;
        public BuscaDeCervejaUsuario(Util util)
        {
            InitializeComponent();
            context = new BeerHunterContext();
            this._util = util;
            usuario = context.Usuario.Find(util.id);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            string busca = textBusca.Text;
            var query = from resultado in context.Cerveja
                        join p in context.CadastraCerveja on resultado.CervejaID equals p.CervejaID.CervejaID
                        where (resultado.NomeCerveja == busca)
                        select new { nomeCerveja = resultado.NomeCerveja, preco = p.PrecoCerveja };
            DataGrid.DataSource = query.ToList();

        }

        private void btnVoltarTelaLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DataGrid.Columns["NomeCerveja"].Index)
            {
                DataGrid.EndEdit();
                Avaliacao avaliacao = new Avaliacao();
                this.Hide();
                avaliacao.ShowDialog();
                this.Show();
            }
        }
    }
}
