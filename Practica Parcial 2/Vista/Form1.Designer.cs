namespace Vista
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
            this.dataGridEmpleados = new System.Windows.Forms.DataGridView();
            this.dataGridInmuebles = new System.Windows.Forms.DataGridView();
            this.buttonModIn = new System.Windows.Forms.Button();
            this.buttonBajaIn = new System.Windows.Forms.Button();
            this.buttonAltaIn = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDirIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPubIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxValorIn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFVentaIn = new System.Windows.Forms.TextBox();
            this.buttonBajaEmp = new System.Windows.Forms.Button();
            this.buttonAltaEmp = new System.Windows.Forms.Button();
            this.buttonModEmp = new System.Windows.Forms.Button();
            this.controlEmpleado1 = new Vista.ControlEmpleado();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInmuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmpleados
            // 
            this.dataGridEmpleados.AllowUserToAddRows = false;
            this.dataGridEmpleados.AllowUserToDeleteRows = false;
            this.dataGridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmpleados.Location = new System.Drawing.Point(12, 12);
            this.dataGridEmpleados.MultiSelect = false;
            this.dataGridEmpleados.Name = "dataGridEmpleados";
            this.dataGridEmpleados.ReadOnly = true;
            this.dataGridEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpleados.Size = new System.Drawing.Size(472, 232);
            this.dataGridEmpleados.TabIndex = 0;
            this.dataGridEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmpleados_CellClick);
            // 
            // dataGridInmuebles
            // 
            this.dataGridInmuebles.AllowUserToAddRows = false;
            this.dataGridInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInmuebles.Location = new System.Drawing.Point(571, 12);
            this.dataGridInmuebles.MultiSelect = false;
            this.dataGridInmuebles.Name = "dataGridInmuebles";
            this.dataGridInmuebles.ReadOnly = true;
            this.dataGridInmuebles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridInmuebles.Size = new System.Drawing.Size(507, 232);
            this.dataGridInmuebles.TabIndex = 1;
            this.dataGridInmuebles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInmuebles_CellClick);
            // 
            // buttonModIn
            // 
            this.buttonModIn.Location = new System.Drawing.Point(998, 415);
            this.buttonModIn.Name = "buttonModIn";
            this.buttonModIn.Size = new System.Drawing.Size(75, 23);
            this.buttonModIn.TabIndex = 7;
            this.buttonModIn.Text = "Modificar";
            this.buttonModIn.UseVisualStyleBackColor = true;
            this.buttonModIn.Click += new System.EventHandler(this.buttonModIn_Click);
            // 
            // buttonBajaIn
            // 
            this.buttonBajaIn.Location = new System.Drawing.Point(917, 415);
            this.buttonBajaIn.Name = "buttonBajaIn";
            this.buttonBajaIn.Size = new System.Drawing.Size(75, 23);
            this.buttonBajaIn.TabIndex = 6;
            this.buttonBajaIn.Text = "Baja";
            this.buttonBajaIn.UseVisualStyleBackColor = true;
            this.buttonBajaIn.Click += new System.EventHandler(this.buttonBajaIn_Click);
            // 
            // buttonAltaIn
            // 
            this.buttonAltaIn.Location = new System.Drawing.Point(836, 415);
            this.buttonAltaIn.Name = "buttonAltaIn";
            this.buttonAltaIn.Size = new System.Drawing.Size(75, 23);
            this.buttonAltaIn.TabIndex = 5;
            this.buttonAltaIn.Text = "Alta";
            this.buttonAltaIn.UseVisualStyleBackColor = true;
            this.buttonAltaIn.Click += new System.EventHandler(this.buttonAltaIn_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(490, 95);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(822, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Direccion";
            // 
            // textBoxDirIn
            // 
            this.textBoxDirIn.Location = new System.Drawing.Point(890, 292);
            this.textBoxDirIn.Name = "textBoxDirIn";
            this.textBoxDirIn.Size = new System.Drawing.Size(143, 20);
            this.textBoxDirIn.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(822, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id";
            // 
            // textBoxIdIn
            // 
            this.textBoxIdIn.Location = new System.Drawing.Point(890, 266);
            this.textBoxIdIn.Name = "textBoxIdIn";
            this.textBoxIdIn.Size = new System.Drawing.Size(143, 20);
            this.textBoxIdIn.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(822, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Publicacion";
            // 
            // textBoxPubIn
            // 
            this.textBoxPubIn.Location = new System.Drawing.Point(890, 344);
            this.textBoxPubIn.Name = "textBoxPubIn";
            this.textBoxPubIn.Size = new System.Drawing.Size(143, 20);
            this.textBoxPubIn.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(822, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor";
            // 
            // textBoxValorIn
            // 
            this.textBoxValorIn.Location = new System.Drawing.Point(890, 318);
            this.textBoxValorIn.Name = "textBoxValorIn";
            this.textBoxValorIn.Size = new System.Drawing.Size(143, 20);
            this.textBoxValorIn.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(823, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "F Venta";
            // 
            // textBoxFVentaIn
            // 
            this.textBoxFVentaIn.Location = new System.Drawing.Point(890, 370);
            this.textBoxFVentaIn.Name = "textBoxFVentaIn";
            this.textBoxFVentaIn.Size = new System.Drawing.Size(143, 20);
            this.textBoxFVentaIn.TabIndex = 21;
            // 
            // buttonBajaEmp
            // 
            this.buttonBajaEmp.Location = new System.Drawing.Point(93, 415);
            this.buttonBajaEmp.Name = "buttonBajaEmp";
            this.buttonBajaEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonBajaEmp.TabIndex = 25;
            this.buttonBajaEmp.Text = "Baja";
            this.buttonBajaEmp.UseVisualStyleBackColor = true;
            this.buttonBajaEmp.Click += new System.EventHandler(this.buttonBajaEmp_Click);
            // 
            // buttonAltaEmp
            // 
            this.buttonAltaEmp.Location = new System.Drawing.Point(12, 415);
            this.buttonAltaEmp.Name = "buttonAltaEmp";
            this.buttonAltaEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonAltaEmp.TabIndex = 24;
            this.buttonAltaEmp.Text = "Alta";
            this.buttonAltaEmp.UseVisualStyleBackColor = true;
            this.buttonAltaEmp.Click += new System.EventHandler(this.buttonAltaEmp_Click);
            // 
            // buttonModEmp
            // 
            this.buttonModEmp.Location = new System.Drawing.Point(174, 415);
            this.buttonModEmp.Name = "buttonModEmp";
            this.buttonModEmp.Size = new System.Drawing.Size(75, 23);
            this.buttonModEmp.TabIndex = 26;
            this.buttonModEmp.Text = "Modificar";
            this.buttonModEmp.UseVisualStyleBackColor = true;
            this.buttonModEmp.Click += new System.EventHandler(this.buttonModEmp_Click);
            // 
            // controlEmpleado1
            // 
            this.controlEmpleado1.Location = new System.Drawing.Point(12, 344);
            this.controlEmpleado1.Name = "controlEmpleado1";
            this.controlEmpleado1.Size = new System.Drawing.Size(220, 65);
            this.controlEmpleado1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.controlEmpleado1);
            this.Controls.Add(this.buttonModEmp);
            this.Controls.Add(this.buttonBajaEmp);
            this.Controls.Add(this.buttonAltaEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFVentaIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPubIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxValorIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDirIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdIn);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonModIn);
            this.Controls.Add(this.buttonBajaIn);
            this.Controls.Add(this.buttonAltaIn);
            this.Controls.Add(this.dataGridInmuebles);
            this.Controls.Add(this.dataGridEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInmuebles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmpleados;
        private System.Windows.Forms.DataGridView dataGridInmuebles;
        private System.Windows.Forms.Button buttonModIn;
        private System.Windows.Forms.Button buttonBajaIn;
        private System.Windows.Forms.Button buttonAltaIn;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDirIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPubIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxValorIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFVentaIn;
        private System.Windows.Forms.Button buttonBajaEmp;
        private System.Windows.Forms.Button buttonAltaEmp;
        private System.Windows.Forms.Button buttonModEmp;
        private ControlEmpleado controlEmpleado1;
    }
}

