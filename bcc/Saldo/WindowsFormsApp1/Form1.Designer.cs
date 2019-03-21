namespace WindowsFormsApp1
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
            this.rbnMulher = new System.Windows.Forms.RadioButton();
            this.rbnHomem = new System.Windows.Forms.RadioButton();
            this.btnDebitar = new System.Windows.Forms.Button();
            this.btnCreditar = new System.Windows.Forms.Button();
            this.btnVerSaldo = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoFamiliar = new System.Windows.Forms.Label();
            this.btnVerSaldoFamiliar = new System.Windows.Forms.Button();
            this.txtHistórico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbnMulher
            // 
            this.rbnMulher.AutoSize = true;
            this.rbnMulher.Location = new System.Drawing.Point(271, 39);
            this.rbnMulher.Name = "rbnMulher";
            this.rbnMulher.Size = new System.Drawing.Size(57, 17);
            this.rbnMulher.TabIndex = 0;
            this.rbnMulher.TabStop = true;
            this.rbnMulher.Text = "Mulher";
            this.rbnMulher.UseVisualStyleBackColor = true;
            // 
            // rbnHomem
            // 
            this.rbnHomem.AutoSize = true;
            this.rbnHomem.Location = new System.Drawing.Point(140, 39);
            this.rbnHomem.Name = "rbnHomem";
            this.rbnHomem.Size = new System.Drawing.Size(61, 17);
            this.rbnHomem.TabIndex = 1;
            this.rbnHomem.TabStop = true;
            this.rbnHomem.Text = "Homem";
            this.rbnHomem.UseVisualStyleBackColor = true;
            // 
            // btnDebitar
            // 
            this.btnDebitar.Location = new System.Drawing.Point(67, 97);
            this.btnDebitar.Name = "btnDebitar";
            this.btnDebitar.Size = new System.Drawing.Size(75, 23);
            this.btnDebitar.TabIndex = 2;
            this.btnDebitar.Text = "Debitar";
            this.btnDebitar.UseVisualStyleBackColor = true;
            this.btnDebitar.Click += new System.EventHandler(this.btnDebitar_Click);
            // 
            // btnCreditar
            // 
            this.btnCreditar.Location = new System.Drawing.Point(67, 144);
            this.btnCreditar.Name = "btnCreditar";
            this.btnCreditar.Size = new System.Drawing.Size(75, 23);
            this.btnCreditar.TabIndex = 3;
            this.btnCreditar.Text = "Creditar";
            this.btnCreditar.UseVisualStyleBackColor = true;
            this.btnCreditar.Click += new System.EventHandler(this.btnCreditar_Click);
            // 
            // btnVerSaldo
            // 
            this.btnVerSaldo.Location = new System.Drawing.Point(140, 191);
            this.btnVerSaldo.Name = "btnVerSaldo";
            this.btnVerSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnVerSaldo.TabIndex = 4;
            this.btnVerSaldo.Text = "Ver Saldo";
            this.btnVerSaldo.UseVisualStyleBackColor = true;
            this.btnVerSaldo.Click += new System.EventHandler(this.btnVerSaldo_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(271, 118);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.Text = "0,00";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(268, 197);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(45, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "R$ 0,00";
            // 
            // lblSaldoFamiliar
            // 
            this.lblSaldoFamiliar.AutoSize = true;
            this.lblSaldoFamiliar.Location = new System.Drawing.Point(268, 246);
            this.lblSaldoFamiliar.Name = "lblSaldoFamiliar";
            this.lblSaldoFamiliar.Size = new System.Drawing.Size(45, 13);
            this.lblSaldoFamiliar.TabIndex = 7;
            this.lblSaldoFamiliar.Text = "R$ 0,00";
            // 
            // btnVerSaldoFamiliar
            // 
            this.btnVerSaldoFamiliar.Location = new System.Drawing.Point(140, 241);
            this.btnVerSaldoFamiliar.Name = "btnVerSaldoFamiliar";
            this.btnVerSaldoFamiliar.Size = new System.Drawing.Size(112, 23);
            this.btnVerSaldoFamiliar.TabIndex = 8;
            this.btnVerSaldoFamiliar.Text = "Ver Saldo Familiar";
            this.btnVerSaldoFamiliar.UseVisualStyleBackColor = true;
            this.btnVerSaldoFamiliar.Click += new System.EventHandler(this.btnVerSaldoFamiliar_Click);
            // 
            // txtHistórico
            // 
            this.txtHistórico.Location = new System.Drawing.Point(495, 39);
            this.txtHistórico.Multiline = true;
            this.txtHistórico.Name = "txtHistórico";
            this.txtHistórico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistórico.Size = new System.Drawing.Size(178, 225);
            this.txtHistórico.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 343);
            this.Controls.Add(this.txtHistórico);
            this.Controls.Add(this.btnVerSaldoFamiliar);
            this.Controls.Add(this.lblSaldoFamiliar);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnVerSaldo);
            this.Controls.Add(this.btnCreditar);
            this.Controls.Add(this.btnDebitar);
            this.Controls.Add(this.rbnHomem);
            this.Controls.Add(this.rbnMulher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnMulher;
        private System.Windows.Forms.RadioButton rbnHomem;
        private System.Windows.Forms.Button btnDebitar;
        private System.Windows.Forms.Button btnCreditar;
        private System.Windows.Forms.Button btnVerSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoFamiliar;
        private System.Windows.Forms.Button btnVerSaldoFamiliar;
        private System.Windows.Forms.TextBox txtHistórico;
    }
}

