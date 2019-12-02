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
        protected string _nomeCerveja, _preco, _teorAlcolico, _lupulo;
      
        protected readonly IUtilidadeService _utilidadeService;
        public Avaliacao(string nomeCerveja, string preco, string teorAlcolico, string lupulo)
        {
           
            _preco = preco;
            _nomeCerveja = nomeCerveja;
            _teorAlcolico = teorAlcolico;
            _lupulo = lupulo;
            InitializeComponent();
        }

        private void Avaliacao_Load(object sender, EventArgs e)
        {
            lbNomeCerveja.Text = _nomeCerveja;
            lblPreco.Text = ("preco: "+ _preco);
            lblTeorAlcolico.Text = ("Teor Alcolico: "+_teorAlcolico);
            lblLupulo.Text = ("lupulo: " + _lupulo);
           
            
        }
    }
}
