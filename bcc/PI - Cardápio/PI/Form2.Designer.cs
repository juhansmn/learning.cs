namespace PI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGastos
            // 
            this.txtGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastos.Location = new System.Drawing.Point(13, 13);
            this.txtGastos.Multiline = true;
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.ReadOnly = true;
            this.txtGastos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGastos.Size = new System.Drawing.Size(327, 425);
            this.txtGastos.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.txtGastos);
            this.Name = "Form2";
            this.Text = "SegundoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGastos;
    }
}