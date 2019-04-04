using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI {
    public partial class Form1 : Form {
        int valorCarne, valorBebida, valorAcompanhamento;
        bool gorjeta;

        public Form1(){
            InitializeComponent();
        }

        private void chkGorjeta_CheckedChanged(object sender, EventArgs e) {
            if (chkGorjeta.Checked == true)
                gorjeta = true;
            else
                gorjeta = false;
        }

        private void lstBebidas_SelectedIndexChanged(object sender, EventArgs e) {
            switch (lstBebidas.SelectedItem) {
                case "Vinho":
                    valorBebida = 20;
                    break;
                case "Suco Natural":
                    valorBebida = 5;
                    break;
                case "Refrigerante":
                    valorBebida = 10;
                    break;
                default:
                    valorBebida = 0;
                    break;

            }
        }

        private void btnPedido_Click(object sender, EventArgs e) {
            //string x = lstItens.SelectedItem.ToString();
            if (lstCarnes.SelectedItem != null && (rdoArrozFeijao.Checked || rdoFritas.Checked || rdoSalada.Checked))
                MessageBox.Show("Pedido feito!");

            if (rdoArrozFeijao.Checked)
                valorAcompanhamento = 20;
            else if (rdoFritas.Checked)
                valorAcompanhamento = 15;
            else if (rdoSalada.Checked)
                valorAcompanhamento = 10;
            else
                valorAcompanhamento = 0;

                Form2 Form2 = new Form2();
            Form2.Show();

            Form2.mostrarGastos(valorCarne, valorBebida, valorAcompanhamento, gorjeta);
            
        }

        private void lstCarnes_SelectedIndexChanged(object sender, EventArgs e) {
            switch (lstCarnes.SelectedItem){
                case "Alcatra":
                    picLanche.ImageLocation = "D:/!Ostok/senac/POO/learning.cs/bcc/PI - Cardápio/PI/PI/res/alcatra.jpg";
                    valorCarne = 15;
                    break;
                case "Cupim":
                    picLanche.ImageLocation = "D:/!Ostok/senac/POO/learning.cs/bcc/PI - Cardápio/PI/PI/res/cupim.jpg";
                    valorCarne = 10;
                    break;
                case "Picanha":
                    picLanche.ImageLocation = "D:/!Ostok/senac/POO/learning.cs/bcc/PI - Cardápio/PI/PI/res/picanha.jpeg";
                    valorCarne = 20;
                    break;
                default:
                    valorCarne = 0;
                    break;
            }

            picLanche.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
