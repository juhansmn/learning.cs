using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElfosAnões
{
    public partial class Form1 : Form
    {
        Personagem anao;
        Personagem elfo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNascer_Click(object sender, EventArgs e)
        {
            if (rdoAnão.Checked)
            {
                anao = new Personagem(txtNome.Text);
                lblVida.Text = anao.vida.ToString();
                lblMana.Text = anao.mana.ToString();
            }
            else
            {
                elfo = new Personagem(txtNome.Text);
                lblVida.Text = elfo.vida.ToString();
                lblMana.Text = anao.mana.ToString();
            }
        }

        private void btnLutar_Click(object sender, EventArgs e)
        {
            if (rdoAnão.Checked)
                MessageBox.Show(elfo.Lutar());
            else
                MessageBox.Show(anao.Lutar());
        }

    }
}
