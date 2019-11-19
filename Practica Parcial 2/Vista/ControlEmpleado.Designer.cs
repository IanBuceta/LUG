namespace Vista
{
    partial class ControlEmpleado
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdEmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNomEmp
            // 
            this.textBoxNomEmp.Location = new System.Drawing.Point(58, 29);
            this.textBoxNomEmp.Name = "textBoxNomEmp";
            this.textBoxNomEmp.Size = new System.Drawing.Size(143, 20);
            this.textBoxNomEmp.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id";
            // 
            // textBoxIdEmp
            // 
            this.textBoxIdEmp.Location = new System.Drawing.Point(58, 3);
            this.textBoxIdEmp.Name = "textBoxIdEmp";
            this.textBoxIdEmp.Size = new System.Drawing.Size(143, 20);
            this.textBoxIdEmp.TabIndex = 16;
            // 
            // ControlEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomEmp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdEmp);
            this.Name = "ControlEmpleado";
            this.Size = new System.Drawing.Size(220, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdEmp;
    }
}
