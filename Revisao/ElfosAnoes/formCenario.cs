using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElfosAnoes
{
    public partial class formCenarioDungeons : Form
    {
        PersonagemTeste elfo;
        PersonagemTeste anao;

        #region Construtor
        public formCenarioDungeons()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.wall;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            pictureBox1.Image = Properties.Resources.elfo;
        }
        #endregion

        #region Eventos do Formulário
        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!ValidarCriacao())
                return;

            PersonagemTeste p;
            if (txtVida.Text == "") //Testa qual dos construtores usar
                p = new PersonagemTeste(txtNome.Text);
            else
                p = new PersonagemTeste(txtNome.Text, Convert.ToInt32(txtVida.Text), Convert.ToInt32(txtMana.Text));

            if (rdoElfo.Checked) //Testa se estou criando um elfo
                elfo = p;
            else
                anao = p;

            AtualizarStatus();
            TestarCriacao();
        }
        
        private void btnLutar_Click(object sender, EventArgs e)
        {
            PersonagemTeste personagem = checarPersonagem(true);
            if (personagem != null)
                lblLog.Text = personagem.Lutar() + lblLog.Text;
                
            AtualizarStatus();
        }

        private void rdoElfo_CheckedChanged(object sender, EventArgs e)
        {
            TestarCriacao();
            AtualizarStatus();
            if (rdoElfo.Checked)
                pictureBox1.Image = Properties.Resources.elfo;
            else
                pictureBox1.Image = Properties.Resources.anao;
        }

        private void btnDuelo_Click(object sender, EventArgs e)
        {
            if(elfo != null && rdoElfo.Checked)
            {
                lblLog.Text = elfo.Lutar(anao) + lblLog.Text;
            }
            if(anao != null && rdoAnao.Checked)
            {
                lblLog.Text = anao.Lutar(elfo) + lblLog.Text;
            }
            AtualizarStatus();
        }

        private void btnCurar_Click(object sender, EventArgs e)
        {
            bool CuraDefinida=false;
            if (txtManaGasta.Text != "")
                CuraDefinida = true;

            PersonagemTeste p = checarPersonagem(true);
            if (p != null)
            { 
                if (CuraDefinida)
                    lblLog.Text = p.Curar(Convert.ToInt32(txtManaGasta.Text)) + lblLog.Text;
                else
                    lblLog.Text = p.Curar() + lblLog.Text;
            }
            AtualizarStatus();
        }

        private void btnCurarAliado_Click(object sender, EventArgs e)
        {
            if (txtMana.Text == "")
            {
                lblLog.Text = "Especifique uma quantidade de mana\r\n" + lblLog.Text;
                return;
            }
            if (elfo != null && rdoElfo.Checked)
            {
                lblLog.Text = elfo.Curar(Convert.ToInt32(txtManaGasta.Text), anao) + lblLog.Text;
            }
            if (anao != null && rdoAnao.Checked)
            {
                lblLog.Text = anao.Curar(Convert.ToInt32(txtManaGasta.Text), elfo) + lblLog.Text;
            }
            AtualizarStatus();
        }

        private void btnMeditar_Click(object sender, EventArgs e)
        {
            PersonagemTeste p = checarPersonagem(true);
            if (p != null)
                lblLog.Text = p.Meditar() + lblLog.Text; 
            AtualizarStatus();
        }
        
        private void btnHelp_Click(object sender, EventArgs e)
        {
            lblLog.Text = PersonagemTeste.Help() + lblLog.Text;
        }

        private void btnGrp_Click(object sender, EventArgs e)
        {
            lblLog.Text = "O grupo está com " + PersonagemTeste.vidaTotal + " pontos de Vida\r\n" + lblLog.Text;
        }
        #endregion

        #region Métodos Privados
        //Valida a tela antes de criar 
        private bool ValidarCriacao()
        {
            if (txtNome.Text == "") //Testa se o personagem tem nome antes de ser criado
            {
                lblLog.Text = "Personagem precisa de um nome\r\n" + lblLog.Text;
                return false;
            }
            if (txtMana.Text != "" && txtVida.Text == "" || txtVida.Text != "" && txtMana.Text == "")
            {
                lblLog.Text = "Se especificar a mana, deve especificar a vida, e vice-versa." + "\r\n" + lblLog.Text;
                return false;
            }
            

            return true;
        }

        //verifica qual personagem está selecionado e retorna o objeto correspondente
        private PersonagemTeste checarPersonagem(bool GerarLog)
        {
            if (rdoElfo.Checked)
            {
                if (elfo != null)
                    return elfo;
                else
                {
                    if (GerarLog)
                        lblLog.Text = "Crie seu elfo antes de utilizá-lo\r\n" + lblLog.Text;
                }
            }
            else
            {
                if (anao != null)
                    return anao;
                else
                {
                    if (GerarLog)
                        lblLog.Text = "Crie seu anao antes de utilizá-lo\r\n" + lblLog.Text;
                }
            }
            return null;
        }

        //Atualiza Nome, Vida e Mana de um dos personagens
        private void AtualizarStatus()
        {
            PersonagemTeste p = checarPersonagem(false);
            if (p != null)
            {
                txtNome.Text = p.nome;
                txtMana.Text = p.mana.ToString();
                txtVida.Text = p.vida.ToString();
                txtXp.Text = p.xp.ToString();
            }
            else
                LimparCampos();
        }

        //Limpa os campos, geralmente quando seleciona um personagem que ainda não foi instanciado
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtMana.Text = string.Empty;
            txtVida.Text = string.Empty;
            txtXp.Text = string.Empty;
        }

        //Bloqueia o btnCriar e as TextBoxes se o personagem selecionado já estiver criado
        private void TestarCriacao()
        {
            bool NaoExiste;

            if (rdoElfo.Checked)
                NaoExiste = elfo == null;
            else
                NaoExiste = anao == null;

            btnCriar.Enabled = NaoExiste;
            txtNome.Enabled = NaoExiste;
            txtVida.Enabled = NaoExiste;
            txtMana.Enabled = NaoExiste;
        }

        #endregion
    }
}
