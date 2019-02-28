using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Humano homem;
        Humano mulher;
        public Form1()
        {
            InitializeComponent();
            homem = new Humano();
            mulher = new Humano();

        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            if (rbnHomem.Checked)
                homem.Debitar(valor);
            else
                mulher.Debitar(valor);
        }

        private void btnCreditar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            if (rbnHomem.Checked)
                homem.Creditar(valor);
            else
                mulher.Creditar(valor);
        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            if (rbnHomem.Checked)
                lblSaldo.Text = homem.VerSaldo().ToString();
            else
                lblSaldo.Text = mulher.VerSaldo().ToString();
        }

        private void btnVerSaldoFamiliar_Click(object sender, EventArgs e)
        {
            lblSaldoFamiliar.Text = (homem.VerSaldo() + mulher.VerSaldo()).ToString();
        }
    }
}
