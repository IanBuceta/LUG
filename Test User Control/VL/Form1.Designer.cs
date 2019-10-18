namespace VL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericBox1 = new VL.NumericBox();
            this.SuspendLayout();
            // 
            // numericBox1
            // 
            this.numericBox1.BackColor = System.Drawing.Color.Tomato;
            this.numericBox1.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.numericBox1.Location = new System.Drawing.Point(12, 12);
            this.numericBox1.Name = "numericBox1";
            this.numericBox1.NumNegativo = System.Drawing.Color.Red;
            this.numericBox1.NumPositivo = System.Drawing.Color.Black;
            this.numericBox1.Size = new System.Drawing.Size(150, 150);
            this.numericBox1.TabIndex = 0;
            this.numericBox1.Texto = "";
            this.numericBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericBox1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NumericBox numericBox1;
    }
}

