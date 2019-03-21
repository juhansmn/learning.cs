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
                anao = new Personagem(txtNome.Text, 30, 15);
                lblVida.Text = anao.vida.ToString();
                lblMana.Text = anao.mana.ToString();
            }
            else
            {
                elfo = new Personagem(txtNome.Text, 15, 30);
                lblVida.Text = elfo.vida.ToString();
                lblMana.Text = elfo.mana.ToString();
            }
        }

        private void btnLutar_Click(object sender, EventArgs e)
        {
            if (rdoAnão.Checked) {
                MessageBox.Show(anao.Lutar());
                lblVida.Text = anao.vida.ToString();
                lblMana.Text = anao.mana.ToString();
            }
            else {
                MessageBox.Show(elfo.Lutar());
                lblVida.Text = elfo.vida.ToString();
                lblMana.Text = elfo.mana.ToString();
            }
        }

    }
}
