using BeerHunter.inter;
using BeerHunter.Service;
using BeerHunter.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class BuscaDeCervejaUsuario : Form
    {
        private IUtilidadeService _utilidadeService;
        private readonly BeerHunterContext context;
        Util _util;
        private readonly Usuario usuario;
        public BuscaDeCervejaUsuario(Util util)
        {
            InitializeComponent();
            context = new BeerHunterContext();
            this._util = util;
            usuario = context.Usuario.Find(util.id);
            _utilidadeService = new UtilidadesService();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataGrid.DataSource = _utilidadeService.BuscaCervejaBanco(textBusca.Text);
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
                string nomeCerveja = DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataGrid.EndEdit();
                Avaliacao avaliacao = new Avaliacao(nomeCerveja);
                this.Hide();
                avaliacao.ShowDialog();
                this.Show();
            }
        }
    }
}
