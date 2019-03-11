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
        Conta homem;
        Conta mulher;

        public Form1()
        {
            InitializeComponent();
            homem = new Conta();
            mulher = new Conta();

        }

        private void btnDebitar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            if (rbnHomem.Checked) {
                homem.Debitar(valor);
                txtHistórico.AppendText("Homem recebeu R$ " + valor.ToString() + "\n");
            }
            else{
                mulher.Debitar(valor);
                txtHistórico.AppendText("Mulher recebeu R$ " + valor.ToString() + "\n");
            }
        }

        private void btnCreditar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (rbnHomem.Checked){
                homem.Creditar(valor);
                txtHistórico.AppendText("Homem gastou R$ " + valor.ToString() + "\n");
            }
            else {
                mulher.Creditar(valor);
                txtHistórico.AppendText("Mulher gastou R$ " + valor.ToString() + "\n");
            }
        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            if (rbnHomem.Checked)
                lblSaldo.Text = "R$ " + homem.VerSaldo().ToString();
            else
                lblSaldo.Text = "R$ " + mulher.VerSaldo().ToString();
        }

        private void btnVerSaldoFamiliar_Click(object sender, EventArgs e)
        {
            lblSaldoFamiliar.Text = "R$ " + (homem.VerSaldo() + mulher.VerSaldo()).ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
