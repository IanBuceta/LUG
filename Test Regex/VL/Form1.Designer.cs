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
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.textBoxMatches = new System.Windows.Forms.TextBox();
            this.textBoxIngresar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(13, 13);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(519, 20);
            this.textBoxFiltro.TabIndex = 0;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // textBoxMatches
            // 
            this.textBoxMatches.Location = new System.Drawing.Point(277, 39);
            this.textBoxMatches.Multiline = true;
            this.textBoxMatches.Name = "textBoxMatches";
            this.textBoxMatches.Size = new System.Drawing.Size(255, 265);
            this.textBoxMatches.TabIndex = 1;
            // 
            // textBoxIngresar
            // 
            this.textBoxIngresar.Location = new System.Drawing.Point(13, 39);
            this.textBoxIngresar.Multiline = true;
            this.textBoxIngresar.Name = "textBoxIngresar";
            this.textBoxIngresar.Size = new System.Drawing.Size(255, 265);
            this.textBoxIngresar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 316);
            this.Controls.Add(this.textBoxIngresar);
            this.Controls.Add(this.textBoxMatches);
            this.Controls.Add(this.textBoxFiltro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.TextBox textBoxMatches;
        private System.Windows.Forms.TextBox textBoxIngresar;
    }
}

