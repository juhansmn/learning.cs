namespace ElfosAnoes
{
    partial class formCenarioDungeons
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
            this.rdoElfo = new System.Windows.Forms.RadioButton();
            this.rdoAnao = new System.Windows.Forms.RadioButton();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnLutar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtVida = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.btnDuelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCurar = new System.Windows.Forms.Button();
            this.btnCurarAliado = new System.Windows.Forms.Button();
            this.btnMeditar = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnGrp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXp = new System.Windows.Forms.TextBox();
            this.txtManaGasta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoElfo
            // 
            this.rdoElfo.AutoSize = true;
            this.rdoElfo.BackColor = System.Drawing.Color.Transparent;
            this.rdoElfo.Checked = true;
            this.rdoElfo.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoElfo.Location = new System.Drawing.Point(45, 44);
            this.rdoElfo.Name = "rdoElfo";
            this.rdoElfo.Size = new System.Drawing.Size(68, 37);
            this.rdoElfo.TabIndex = 0;
            this.rdoElfo.TabStop = true;
            this.rdoElfo.Text = "Elfo";
            this.rdoElfo.UseVisualStyleBackColor = false;
            this.rdoElfo.CheckedChanged += new System.EventHandler(this.rdoElfo_CheckedChanged);
            // 
            // rdoAnao
            // 
            this.rdoAnao.AutoSize = true;
            this.rdoAnao.BackColor = System.Drawing.Color.Transparent;
            this.rdoAnao.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAnao.Location = new System.Drawing.Point(45, 87);
            this.rdoAnao.Name = "rdoAnao";
            this.rdoAnao.Size = new System.Drawing.Size(77, 37);
            this.rdoAnao.TabIndex = 1;
            this.rdoAnao.Text = "Anão";
            this.rdoAnao.UseVisualStyleBackColor = false;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCriar.Location = new System.Drawing.Point(72, 323);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(180, 34);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnLutar
            // 
            this.btnLutar.BackColor = System.Drawing.Color.Transparent;
            this.btnLutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLutar.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLutar.Location = new System.Drawing.Point(296, 42);
            this.btnLutar.Name = "btnLutar";
            this.btnLutar.Size = new System.Drawing.Size(236, 38);
            this.btnLutar.TabIndex = 3;
            this.btnLutar.Text = "Lutar com monstros";
            this.btnLutar.UseVisualStyleBackColor = false;
            this.btnLutar.Click += new System.EventHandler(this.btnLutar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 181);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtVida
            // 
            this.txtVida.Location = new System.Drawing.Point(128, 216);
            this.txtVida.Name = "txtVida";
            this.txtVida.Size = new System.Drawing.Size(100, 20);
            this.txtVida.TabIndex = 5;
            // 
            // txtMana
            // 
            this.txtMana.Location = new System.Drawing.Point(128, 254);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(100, 20);
            this.txtMana.TabIndex = 6;
            // 
            // btnDuelo
            // 
            this.btnDuelo.BackColor = System.Drawing.Color.Transparent;
            this.btnDuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuelo.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuelo.Location = new System.Drawing.Point(296, 86);
            this.btnDuelo.Name = "btnDuelo";
            this.btnDuelo.Size = new System.Drawing.Size(236, 38);
            this.btnDuelo.TabIndex = 7;
            this.btnDuelo.Text = "Lutar contra seu amigo";
            this.btnDuelo.UseVisualStyleBackColor = false;
            this.btnDuelo.Click += new System.EventHandler(this.btnDuelo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vida";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mana";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCurar
            // 
            this.btnCurar.BackColor = System.Drawing.Color.Transparent;
            this.btnCurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurar.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurar.Location = new System.Drawing.Point(296, 178);
            this.btnCurar.Name = "btnCurar";
            this.btnCurar.Size = new System.Drawing.Size(236, 38);
            this.btnCurar.TabIndex = 11;
            this.btnCurar.Text = "Curar";
            this.btnCurar.UseVisualStyleBackColor = false;
            this.btnCurar.Click += new System.EventHandler(this.btnCurar_Click);
            // 
            // btnCurarAliado
            // 
            this.btnCurarAliado.BackColor = System.Drawing.Color.Transparent;
            this.btnCurarAliado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurarAliado.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurarAliado.Location = new System.Drawing.Point(296, 227);
            this.btnCurarAliado.Name = "btnCurarAliado";
            this.btnCurarAliado.Size = new System.Drawing.Size(236, 38);
            this.btnCurarAliado.TabIndex = 12;
            this.btnCurarAliado.Text = "Curar aliado";
            this.btnCurarAliado.UseVisualStyleBackColor = false;
            this.btnCurarAliado.Click += new System.EventHandler(this.btnCurarAliado_Click);
            // 
            // btnMeditar
            // 
            this.btnMeditar.BackColor = System.Drawing.Color.Transparent;
            this.btnMeditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeditar.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeditar.Location = new System.Drawing.Point(296, 317);
            this.btnMeditar.Name = "btnMeditar";
            this.btnMeditar.Size = new System.Drawing.Size(236, 38);
            this.btnMeditar.TabIndex = 13;
            this.btnMeditar.Text = "Meditar";
            this.btnMeditar.UseVisualStyleBackColor = false;
            this.btnMeditar.Click += new System.EventHandler(this.btnMeditar_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(774, 271);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(77, 41);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "Ajuda";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnGrp
            // 
            this.btnGrp.BackColor = System.Drawing.Color.Transparent;
            this.btnGrp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrp.Font = new System.Drawing.Font("French Script MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrp.Location = new System.Drawing.Point(587, 271);
            this.btnGrp.Name = "btnGrp";
            this.btnGrp.Size = new System.Drawing.Size(159, 41);
            this.btnGrp.TabIndex = 18;
            this.btnGrp.Text = "Vida do Grupo";
            this.btnGrp.UseVisualStyleBackColor = false;
            this.btnGrp.Click += new System.EventHandler(this.btnGrp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "XP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtXp
            // 
            this.txtXp.Enabled = false;
            this.txtXp.Location = new System.Drawing.Point(128, 292);
            this.txtXp.Name = "txtXp";
            this.txtXp.Size = new System.Drawing.Size(100, 20);
            this.txtXp.TabIndex = 19;
            // 
            // txtManaGasta
            // 
            this.txtManaGasta.Location = new System.Drawing.Point(375, 149);
            this.txtManaGasta.Name = "txtManaGasta";
            this.txtManaGasta.Size = new System.Drawing.Size(39, 20);
            this.txtManaGasta.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("French Script MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mana";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(128, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblLog
            // 
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLog.Location = new System.Drawing.Point(584, 44);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(267, 213);
            this.lblLog.TabIndex = 23;
            this.lblLog.Text = "Início da Aventura";
            // 
            // formCenarioDungeons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 377);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManaGasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXp);
            this.Controls.Add(this.btnGrp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnMeditar);
            this.Controls.Add(this.btnCurarAliado);
            this.Controls.Add(this.btnCurar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDuelo);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtVida);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnLutar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.rdoAnao);
            this.Controls.Add(this.rdoElfo);
            this.MinimumSize = new System.Drawing.Size(830, 368);
            this.Name = "formCenarioDungeons";
            this.Text = "Elfos & Anões";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoElfo;
        private System.Windows.Forms.RadioButton rdoAnao;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnLutar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtVida;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.Button btnDuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCurar;
        private System.Windows.Forms.Button btnCurarAliado;
        private System.Windows.Forms.Button btnMeditar;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGrp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXp;
        private System.Windows.Forms.TextBox txtManaGasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLog;
    }
}

