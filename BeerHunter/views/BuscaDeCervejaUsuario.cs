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
        
        public BuscaDeCervejaUsuario()
        {
            InitializeComponent();
            context = new BeerHunterContext();
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
            
            if (e.ColumnIndex == DataGrid.Columns["NomeCerveja"].Index)
            {
                string nomeCerveja = DataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string preco = DataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string lupulo = DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string teorAlcolico = DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

                DataGrid.EndEdit();
                using (Avaliacao avaliacao = new Avaliacao(nomeCerveja, preco, teorAlcolico, lupulo))
                {
                    this.Hide();
                    avaliacao.ShowDialog();
                }
                this.Show();
            }
        }

        private void SeletorBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seletor = SeletorBusca.SelectedItem.ToString();
            

        }
    }
}
