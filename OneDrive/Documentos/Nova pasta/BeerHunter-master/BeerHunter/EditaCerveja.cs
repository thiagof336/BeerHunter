using BeerHunter.inter;
using BeerHunter.Model;
using BeerHunter.Service;
using BeerHunter.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerHunter
{
    public partial class EditaCerveja : MetroFramework.Forms.MetroForm
    {
        private IUtilidadeService _utilidadeService;
        private readonly BeerHunterContext _context;
        public EditaCerveja()
        {
            InitializeComponent();
            _utilidadeService = new UtilidadesService();
            _context = new BeerHunterContext();
        }

        private void EditaCerveja_Load(object sender, EventArgs e)
        {
            Fornecedor forncedor = _context.Fornecedor.Find(Session.Instance.id);
            dataGrid.DataSource = _utilidadeService.buscaCervejaFornecedor(forncedor);
            if (dataGrid.DataSource != null)
            {
               /* dataGrid.Columns[0].HeaderText = "Codigo Cerveja";
                dataGrid.Columns[1].HeaderText = "Nome Cerveja";
                dataGrid.Columns[2].HeaderText = "Preço";
                dataGrid.Columns[3].HeaderText = "Lupulo";               */          
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGrid.CurrentRow.Index)
            {
                int CodCerveja = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                Session.Instance.cadastraCerveja = _context.CadastraCerveja.Find(CodCerveja);

                var cerveja = _context.Cerveja.Find(CodCerveja);

                dataGrid.EndEdit();
                using (EditarCerveja editar = new EditarCerveja(cerveja))
                {
                    this.Hide();
                    editar.ShowDialog();
                }
                this.Show();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

