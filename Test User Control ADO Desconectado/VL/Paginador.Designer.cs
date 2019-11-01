namespace VL
{
    partial class Paginador
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(277, 261);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(13, 13);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "0";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(312, 261);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(19, 13);
            this.labelEnd.TabIndex = 3;
            this.labelEnd.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(374, 247);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(3, 256);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(47, 23);
            this.buttonAñadir.TabIndex = 6;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(56, 256);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(45, 23);
            this.buttonBorrar.TabIndex = 7;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(107, 256);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(118, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Paginador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Paginador";
            this.Size = new System.Drawing.Size(380, 282);
            this.Load += new System.EventHandler(this.Paginador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}
