using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteForms{
    public partial class Form : System.Windows.Forms.Form{
        int valor = 0;

        public Form(){
            InitializeComponent();
        }

        private void btnMaisUm_Click(object sender, EventArgs e){
            valor += 1;

            txtResultado.Text = ((valor).ToString());
        }

        private void btnFatorial_Click(object sender, EventArgs e){
            valor = Convert.ToInt32(txtValor.Text);

            int fatorial = valor;

            for (int i = 1; i < valor; i++) {
                fatorial *= i;
            }

            txtResultado.Text = ((fatorial).ToString());
        }
    }
}
