using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    public partial class Form1 : Form
    {
        Pokedex pokedex;
        public Form1()
        {
            InitializeComponent();
            pokedex = new Pokedex();
            var source = new BindingSource();
            source.DataSource = pokedex.pokemons;
            dgvTela.DataSource = source;
        }

        private void dgvTela_Click(object sender, EventArgs e)
        {
            Pokemon p = (Pokemon)dgvTela.SelectedRows[0].DataBoundItem;
            dgvFraquezas.DataSource = null;
            dgvFraquezas.DataSource = p.fraquezas;

            listBox1.DataSource = null;
            listBox1.DataSource = p.fraquezas;
        }
    }
}
