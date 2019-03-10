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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstItens = new System.Windows.Forms.ComboBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.rdoFritas = new System.Windows.Forms.RadioButton();
            this.chkGorjeta = new System.Windows.Forms.CheckBox();
            this.rdoSalada = new System.Windows.Forms.RadioButton();
            this.rdoArrozFeijao = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Refrigerante",
            "Suco Natural",
            "Vinho"});
            this.listBox1.Location = new System.Drawing.Point(29, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // lstItens
            // 
            this.lstItens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Items.AddRange(new object[] {
            "Picanha",
            "Cupim",
            "Alcatra",
            "Maminha",
            "Coxão Duro"});
            this.lstItens.Location = new System.Drawing.Point(28, 24);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(121, 21);
            this.lstItens.TabIndex = 2;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(235, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 122);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdoArrozFeijao);
            this.Controls.Add(this.rdoSalada);
            this.Controls.Add(this.chkGorjeta);
            this.Controls.Add(this.rdoFritas);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox lstItens;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.RadioButton rdoFritas;
        private System.Windows.Forms.CheckBox chkGorjeta;
        private System.Windows.Forms.RadioButton rdoSalada;
        private System.Windows.Forms.RadioButton rdoArrozFeijao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

