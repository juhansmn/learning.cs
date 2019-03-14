namespace ElfosAnões
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNascer = new System.Windows.Forms.Button();
            this.btnLutar = new System.Windows.Forms.Button();
            this.rdoAnão = new System.Windows.Forms.RadioButton();
            this.rdoElfo = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNascer
            // 
            this.btnNascer.Location = new System.Drawing.Point(41, 219);
            this.btnNascer.Name = "btnNascer";
            this.btnNascer.Size = new System.Drawing.Size(75, 23);
            this.btnNascer.TabIndex = 0;
            this.btnNascer.Text = "Nascer";
            this.btnNascer.UseVisualStyleBackColor = true;
            this.btnNascer.Click += new System.EventHandler(this.btnNascer_Click);
            // 
            // btnLutar
            // 
            this.btnLutar.Location = new System.Drawing.Point(230, 74);
            this.btnLutar.Name = "btnLutar";
            this.btnLutar.Size = new System.Drawing.Size(100, 65);
            this.btnLutar.TabIndex = 1;
            this.btnLutar.Text = "Lutar";
            this.btnLutar.UseVisualStyleBackColor = true;
            this.btnLutar.Click += new System.EventHandler(this.btnLutar_Click);
            // 
            // rdoAnão
            // 
            this.rdoAnão.AutoSize = true;
            this.rdoAnão.Location = new System.Drawing.Point(44, 12);
            this.rdoAnão.Name = "rdoAnão";
            this.rdoAnão.Size = new System.Drawing.Size(50, 17);
            this.rdoAnão.TabIndex = 2;
            this.rdoAnão.TabStop = true;
            this.rdoAnão.Text = "Anão";
            this.rdoAnão.UseVisualStyleBackColor = true;
            // 
            // rdoElfo
            // 
            this.rdoElfo.AutoSize = true;
            this.rdoElfo.Location = new System.Drawing.Point(230, 12);
            this.rdoElfo.Name = "rdoElfo";
            this.rdoElfo.Size = new System.Drawing.Size(43, 17);
            this.rdoElfo.TabIndex = 3;
            this.rdoElfo.TabStop = true;
            this.rdoElfo.Text = "Elfo";
            this.rdoElfo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(41, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(41, 122);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(28, 13);
            this.lblVida.TabIndex = 8;
            this.lblVida.Text = "Vida";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.Location = new System.Drawing.Point(41, 145);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(34, 13);
            this.lblMana.TabIndex = 9;
            this.lblMana.Text = "Mana";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 388);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.rdoElfo);
            this.Controls.Add(this.rdoAnão);
            this.Controls.Add(this.btnLutar);
            this.Controls.Add(this.btnNascer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNascer;
        private System.Windows.Forms.Button btnLutar;
        private System.Windows.Forms.RadioButton rdoAnão;
        private System.Windows.Forms.RadioButton rdoElfo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblMana;
    }
}

