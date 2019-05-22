using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Animal> granja = new List<Animal>();
            Galinha g1 = new Galinha();
            Pato p1 = new Pato();
            Gato gatinho = new Gato();

            granja.Add(g1);
            granja.Add(p1);
            granja.Add(gatinho);

            foreach (Animal o in granja)
            {
                if (o is IOviparo)
                {
                    ((IOviparo)o).BotarOvo();
                }
                else
                {
                    MessageBox.Show("Gato não bota ovo.");
                }
            }
        }
    }
}
