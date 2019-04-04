namespace PI
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
            this.lstBebidas = new System.Windows.Forms.ListBox();
            this.lstCarnes = new System.Windows.Forms.ComboBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.rdoFritas = new System.Windows.Forms.RadioButton();
            this.chkGorjeta = new System.Windows.Forms.CheckBox();
            this.rdoSalada = new System.Windows.Forms.RadioButton();
            this.rdoArrozFeijao = new System.Windows.Forms.RadioButton();
            this.picLanche = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLanche)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBebidas
            // 
            this.lstBebidas.FormattingEnabled = true;
            this.lstBebidas.Items.AddRange(new object[] {
            "Refrigerante",
            "Suco Natural",
            "Vinho"});
            this.lstBebidas.Location = new System.Drawing.Point(29, 51);
            this.lstBebidas.Name = "lstBebidas";
            this.lstBebidas.Size = new System.Drawing.Size(120, 95);
            this.lstBebidas.TabIndex = 0;
            this.lstBebidas.SelectedIndexChanged += new System.EventHandler(this.lstBebidas_SelectedIndexChanged);
            // 
            // lstCarnes
            // 
            this.lstCarnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCarnes.FormattingEnabled = true;
            this.lstCarnes.Items.AddRange(new object[] {
            "Picanha",
            "Cupim",
            "Alcatra"});
            this.lstCarnes.Location = new System.Drawing.Point(29, 24);
            this.lstCarnes.Name = "lstCarnes";
            this.lstCarnes.Size = new System.Drawing.Size(121, 21);
            this.lstCarnes.TabIndex = 2;
            this.lstCarnes.SelectedIndexChanged += new System.EventHandler(this.lstCarnes_SelectedIndexChanged);
            // 
            // btnPedido
            // 
            this.btnPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPedido.Location = new System.Drawing.Point(317, 245);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(88, 23);
            this.btnPedido.TabIndex = 4;
            this.btnPedido.Text = "Fazer Pedido.";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // rdoFritas
            // 
            this.rdoFritas.AutoSize = true;
            this.rdoFritas.Location = new System.Drawing.Point(29, 184);
            this.rdoFritas.Name = "rdoFritas";
            this.rdoFritas.Size = new System.Drawing.Size(79, 17);
            this.rdoFritas.TabIndex = 5;
            this.rdoFritas.TabStop = true;
            this.rdoFritas.Text = "Batata Frita";
            this.rdoFritas.UseVisualStyleBackColor = true;
            // 
            // chkGorjeta
            // 
            this.chkGorjeta.AutoSize = true;
            this.chkGorjeta.Location = new System.Drawing.Point(28, 251);
            this.chkGorjeta.Name = "chkGorjeta";
            this.chkGorjeta.Size = new System.Drawing.Size(118, 17);
            this.chkGorjeta.TabIndex = 6;
            this.chkGorjeta.Text = "Gorjeta? (Adicional)";
            this.chkGorjeta.UseVisualStyleBackColor = true;
            this.chkGorjeta.CheckedChanged += new System.EventHandler(this.chkGorjeta_CheckedChanged);
            // 
            // rdoSalada
            // 
            this.rdoSalada.AutoSize = true;
            this.rdoSalada.Location = new System.Drawing.Point(114, 184);
            this.rdoSalada.Name = "rdoSalada";
            this.rdoSalada.Size = new System.Drawing.Size(58, 17);
            this.rdoSalada.TabIndex = 7;
            this.rdoSalada.TabStop = true;
            this.rdoSalada.Text = "Salada";
            this.rdoSalada.UseVisualStyleBackColor = true;
            // 
            // rdoArrozFeijao
            // 
            this.rdoArrozFeijao.AutoSize = true;
            this.rdoArrozFeijao.Location = new System.Drawing.Point(178, 184);
            this.rdoArrozFeijao.Name = "rdoArrozFeijao";
            this.rdoArrozFeijao.Size = new System.Drawing.Size(89, 17);
            this.rdoArrozFeijao.TabIndex = 8;
            this.rdoArrozFeijao.TabStop = true;
            this.rdoArrozFeijao.Text = "Arroz e Feijão";
            this.rdoArrozFeijao.UseVisualStyleBackColor = true;
            // 
            // picLanche
            // 
            this.picLanche.Location = new System.Drawing.Point(235, 24);
            this.picLanche.Name = "picLanche";
            this.picLanche.Size = new System.Drawing.Size(170, 122);
            this.picLanche.TabIndex = 9;
            this.picLanche.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 292);
            this.Controls.Add(this.picLanche);
            this.Controls.Add(this.rdoArrozFeijao);
            this.Controls.Add(this.rdoSalada);
            this.Controls.Add(this.chkGorjeta);
            this.Controls.Add(this.rdoFritas);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.lstCarnes);
            this.Controls.Add(this.lstBebidas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLanche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBebidas;
        private System.Windows.Forms.ComboBox lstCarnes;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.RadioButton rdoFritas;
        private System.Windows.Forms.CheckBox chkGorjeta;
        private System.Windows.Forms.RadioButton rdoSalada;
        private System.Windows.Forms.RadioButton rdoArrozFeijao;
        private System.Windows.Forms.PictureBox picLanche;
    }
}

