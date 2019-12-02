using BeerHunter.Service;
using System;
using System.Windows.Forms;

namespace BeerHunter.views
{
    public partial class RealizarAvaliacao : Form
    {
        public RealizarAvaliacao()
        {
            InitializeComponent();
            lblNomeUsuario.Text = Session.Instance.id.ToString();


        }

        private void btnVoltarAvaliacao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
