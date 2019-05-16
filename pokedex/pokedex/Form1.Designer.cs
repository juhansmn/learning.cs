namespace pokedex
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
            this.dgvTela = new System.Windows.Forms.DataGridView();
            this.dgvFraquezas = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraquezas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTela
            // 
            this.dgvTela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTela.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTela.Location = new System.Drawing.Point(30, 12);
            this.dgvTela.MultiSelect = false;
            this.dgvTela.Name = "dgvTela";
            this.dgvTela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTela.Size = new System.Drawing.Size(504, 426);
            this.dgvTela.TabIndex = 0;
            this.dgvTela.Click += new System.EventHandler(this.dgvTela_Click);
            // 
            // dgvFraquezas
            // 
            this.dgvFraquezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFraquezas.Location = new System.Drawing.Point(587, 12);
            this.dgvFraquezas.Name = "dgvFraquezas";
            this.dgvFraquezas.Size = new System.Drawing.Size(201, 135);
            this.dgvFraquezas.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(587, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgvFraquezas);
            this.Controls.Add(this.dgvTela);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFraquezas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTela;
        private System.Windows.Forms.DataGridView dgvFraquezas;
        private System.Windows.Forms.ListBox listBox1;
    }
}

