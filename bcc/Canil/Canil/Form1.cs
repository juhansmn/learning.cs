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
        List<Cachorro> caes;
        bool alterar;

        public Form1() {
            InitializeComponent();
            caes = new List<Cachorro>();
            atualizarDataGridView();
        }

        //Atualiza o DataSource do DataGridView.
        private void atualizarDataGridView() {
            var source = new BindingSource();
            source.DataSource = caes;
            dgvCanil.DataSource = source;
        }

        //Adiciona cão ao DataGridView.
        private void btnAdicionar_Click(object sender, EventArgs e) {
            if (alterar == false) {
                Cachorro cao = new Cachorro();

                cao.nome = txtNome.Text;
                cao.dataNascimento = dtpNascimento.Value.ToShortDateString();

                if (chkPedigree.Checked)
                    cao.pedigree = true;

                else
                    cao.pedigree = false;

                caes.Add(cao);
            }
            //Estado de alteração de dados. 
            else {
                int i = Convert.ToInt32(dgvCanil.SelectedRows[0].Index);

                caes[i].nome = txtNome.Text;
                caes[i].dataNascimento = dtpNascimento.Value.ToShortDateString();

                if (chkPedigree.Checked)
                    caes[i].pedigree = true;

                else
                    caes[i].pedigree = false;

                alterar = false;
            }

            btnAdicionar.Text = "Adicionar";
            atualizarDataGridView();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            //Se não apertar o botão Editar, ele limpa a DataGridView.
            if (alterar != true)
                dgvCanil.Rows.Clear();
            //Após apertar o botão Editar, ele desfaz o estado de edição.
            else {
                alterar = false;

                btnAdicionar.Text = "Adicionar";
            }
        }

        //Edita informações digitadas. O botão Nascer "troca de estado" para o botão Alterar.
        private void btnEditar_Click(object sender, EventArgs e) {
            alterar = true;

            btnAdicionar.Text = "Alterar";
        }

        //Remove informações do DataGridView.
        private void btnRemover_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCanil.SelectedRows) {
                dgvCanil.Rows.RemoveAt(item.Index);
            }
        }


    }
}
