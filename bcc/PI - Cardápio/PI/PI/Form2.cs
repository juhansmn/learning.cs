using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void mostrarGastos(int valorCarne, int valorBebida, int valorAcompanhamento, bool gorjeta) {
            int valorGorjeta = 5;
            if (gorjeta == false)
                valorGorjeta = 0;

            txtGastos.AppendText("R$" + valorCarne + "\n");
            txtGastos.AppendText("R$" + valorBebida + "\n");
            txtGastos.AppendText("R$" + valorAcompanhamento + "\n");
            txtGastos.AppendText("Gorjeta: R$" + valorGorjeta + "\n");

            txtGastos.AppendText("Valor Total:" + (valorCarne + valorBebida +valorAcompanhamento + valorGorjeta) + "\n");

            txtGastos.AppendText("--------------------------------------------------------\n");
            txtGastos.AppendText("Obrigado e volte sempre!\n");
            txtGastos.AppendText("Templo da Carne.");

        }
    }
}
