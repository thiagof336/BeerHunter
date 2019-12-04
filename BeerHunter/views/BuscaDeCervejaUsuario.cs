using BeerHunter.inter;
using BeerHunter.Service;
using System;
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
                int CodCerveja = int.Parse(DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nomeCerveja = DataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                string preco = DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                string lupulo = DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                string teorAlcolico = DataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                Session.Instance.cadastraCerveja = context.CadastraCerveja.Find(CodCerveja);     
                //MessageBox.Show(IdCerveja.ToString());

                DataGrid.EndEdit();
                using (telaAvaliacao telaAvaliacao = new telaAvaliacao(nomeCerveja, preco, teorAlcolico, lupulo))
                {
                    this.Hide();
                    telaAvaliacao.ShowDialog();
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
