using BeerHunter.inter;
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
    public partial class Avaliacao : Form
    {
        protected string _nomeCerveja;
        protected readonly IUtilidadeService _utilidadeService;
        public Avaliacao(string nomeCerveja)
        {
            _nomeCerveja = nomeCerveja;
            InitializeComponent();
        }

        private void Avaliacao_Load(object sender, EventArgs e)
        {
            lbNomeCerveja.Text = _nomeCerveja;
            
        }
    }
}
