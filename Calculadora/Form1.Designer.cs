namespace NumerosInteiros
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstNumeros  = new System.Windows.Forms.ListBox();
            this.btnFor      = new System.Windows.Forms.Button();
            this.btnWhile    = new System.Windows.Forms.Button();
            this.btnDoWhile  = new System.Windows.Forms.Button();
            this.btnLimpar   = new System.Windows.Forms.Button();
            this.lblTitulo   = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location  = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(200, 20);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "Cem Primeiros Números Inteiros";

            // lstNumeros
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight        = 18;
            this.lstNumeros.Location          = new System.Drawing.Point(12, 42);
            this.lstNumeros.Name              = "lstNumeros";
            this.lstNumeros.Size              = new System.Drawing.Size(200, 310);
            this.lstNumeros.TabIndex          = 1;

            // btnFor
            this.btnFor.Location  = new System.Drawing.Point(230, 42);
            this.btnFor.Name      = "btnFor";
            this.btnFor.Size      = new System.Drawing.Size(130, 40);
            this.btnFor.TabIndex  = 2;
            this.btnFor.Text      = "Laço For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click    += new System.EventHandler(this.btnFor_Click);

            // btnWhile
            this.btnWhile.Location  = new System.Drawing.Point(230, 98);
            this.btnWhile.Name      = "btnWhile";
            this.btnWhile.Size      = new System.Drawing.Size(130, 40);
            this.btnWhile.TabIndex  = 3;
            this.btnWhile.Text      = "Laço While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click    += new System.EventHandler(this.btnWhile_Click);

            // btnDoWhile
            this.btnDoWhile.Location  = new System.Drawing.Point(230, 154);
            this.btnDoWhile.Name      = "btnDoWhile";
            this.btnDoWhile.Size      = new System.Drawing.Size(130, 40);
            this.btnDoWhile.TabIndex  = 4;
            this.btnDoWhile.Text      = "Laço Do-While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click    += new System.EventHandler(this.btnDoWhile_Click);

            // btnLimpar
            this.btnLimpar.Location  = new System.Drawing.Point(230, 210);
            this.btnLimpar.Name      = "btnLimpar";
            this.btnLimpar.Size      = new System.Drawing.Size(130, 40);
            this.btnLimpar.TabIndex  = 5;
            this.btnLimpar.Text      = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click    += new System.EventHandler(this.btnLimpar_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(384, 371);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnLimpar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "Form1";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Números Inteiros";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button  btnFor;
        private System.Windows.Forms.Button  btnWhile;
        private System.Windows.Forms.Button  btnDoWhile;
        private System.Windows.Forms.Button  btnLimpar;
        private System.Windows.Forms.Label   lblTitulo;
    }
}
