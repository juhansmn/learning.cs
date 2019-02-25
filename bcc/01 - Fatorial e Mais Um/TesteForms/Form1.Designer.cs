namespace TesteForms
{
    partial class Form
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
            this.btnMaisUm = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaisUm
            // 
            this.btnMaisUm.AutoSize = true;
            this.btnMaisUm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaisUm.Location = new System.Drawing.Point(145, 128);
            this.btnMaisUm.Name = "btnMaisUm";
            this.btnMaisUm.Size = new System.Drawing.Size(100, 39);
            this.btnMaisUm.TabIndex = 1;
            this.btnMaisUm.Text = "MAIS UM";
            this.btnMaisUm.UseVisualStyleBackColor = false;
            this.btnMaisUm.Click += new System.EventHandler(this.btnMaisUm_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtResultado.Location = new System.Drawing.Point(189, 102);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(13, 13);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.Text = "0";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(139, 366);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(112, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.Text = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFatorial
            // 
            this.btnFatorial.Location = new System.Drawing.Point(159, 398);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(73, 20);
            this.btnFatorial.TabIndex = 4;
            this.btnFatorial.Text = "Fatorial";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 589);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnMaisUm);
            this.MaximumSize = new System.Drawing.Size(410, 628);
            this.MinimumSize = new System.Drawing.Size(410, 628);
            this.Name = "Form";
            this.Text = "Mais Um e Fatorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaisUm;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnFatorial;
    }
}

