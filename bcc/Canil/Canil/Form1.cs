using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canil {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //Adicionar filhote à lista.
        private void btnNascer_Click(object sender, EventArgs e) {
            Hound cao = new Hound();

            cao.nome = txtNome.Text;
            cao.dataNascimento = dtpNascimento.Value.ToShortDateString();

            if (chkPedigree.Checked)
                cao.pedigree = true;

            dgvCanil.Rows.Add(cao.nome, cao.dataNascimento, cao.pedigree.ToString());
        }

        //Remover da lista.
        private void btnRemover_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCanil.SelectedRows){
                if (!dgvCanil.CurrentRow.IsNewRow)
                    dgvCanil.Rows.RemoveAt(item.Index);
                else
                    MessageBox.Show("ERRO: A posição está vazia.");
            }
        }

        //Limpar lista (FAZER).
        private void btnLimpar_Click(object sender, EventArgs e) {
        }

        //Editar informações da lista. O texto do botão nascer deve mudar para "alterar" (FAZER). Se clicar duas vezes, também deve editar.
        private void btnEditar_Click(object sender, EventArgs e) {
            if (dgvCanil.CurrentRow.IsNewRow) {
                MessageBox.Show("ERRO: A posição está vazia.");
                return;
            }

            DataGridViewRow row = new DataGridViewRow();

            row = dgvCanil.Rows[dgvCanil.SelectedRows[0].Index];

            row.Cells[0].Value = txtNome.Text;
            row.Cells[1].Value = dtpNascimento.Value.ToShortDateString();

            if (chkPedigree.Checked)
                row.Cells[2].Value = "True";

            else
                row.Cells[2].Value = "False";
        
        }
    }
}
