namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.GrabarClientes = new System.Windows.Forms.GroupBox();
            this.RbModificar = new System.Windows.Forms.RadioButton();
            this.RbEliminar = new System.Windows.Forms.RadioButton();
            this.RbInsertar = new System.Windows.Forms.RadioButton();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GrabarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 542);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(375, 197);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(386, 31);
            this.txtId.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(373, 255);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(386, 31);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(373, 311);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(6);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(386, 31);
            this.txtApellido1.TabIndex = 6;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(811, 200);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 44);
            this.BtnAgregar.TabIndex = 8;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(811, 261);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 44);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(811, 317);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 44);
            this.BtnModificar.TabIndex = 10;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // GrabarClientes
            // 
            this.GrabarClientes.Controls.Add(this.RbModificar);
            this.GrabarClientes.Controls.Add(this.RbEliminar);
            this.GrabarClientes.Controls.Add(this.RbInsertar);
            this.GrabarClientes.Location = new System.Drawing.Point(172, 40);
            this.GrabarClientes.Margin = new System.Windows.Forms.Padding(6);
            this.GrabarClientes.Name = "GrabarClientes";
            this.GrabarClientes.Padding = new System.Windows.Forms.Padding(6);
            this.GrabarClientes.Size = new System.Drawing.Size(874, 110);
            this.GrabarClientes.TabIndex = 12;
            this.GrabarClientes.TabStop = false;
            this.GrabarClientes.Text = "Mantenimiento de Clientes";
            // 
            // RbModificar
            // 
            this.RbModificar.AutoSize = true;
            this.RbModificar.Location = new System.Drawing.Point(626, 48);
            this.RbModificar.Margin = new System.Windows.Forms.Padding(6);
            this.RbModificar.Name = "RbModificar";
            this.RbModificar.Size = new System.Drawing.Size(131, 29);
            this.RbModificar.TabIndex = 2;
            this.RbModificar.TabStop = true;
            this.RbModificar.Text = "Modificar";
            this.RbModificar.UseVisualStyleBackColor = true;
            this.RbModificar.CheckedChanged += new System.EventHandler(this.RbModificar_CheckedChanged);
            // 
            // RbEliminar
            // 
            this.RbEliminar.AutoSize = true;
            this.RbEliminar.Location = new System.Drawing.Point(361, 48);
            this.RbEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.RbEliminar.Name = "RbEliminar";
            this.RbEliminar.Size = new System.Drawing.Size(120, 29);
            this.RbEliminar.TabIndex = 1;
            this.RbEliminar.TabStop = true;
            this.RbEliminar.Text = "Eliminar";
            this.RbEliminar.UseVisualStyleBackColor = true;
            this.RbEliminar.CheckedChanged += new System.EventHandler(this.RbEliminar_CheckedChanged);
            // 
            // RbInsertar
            // 
            this.RbInsertar.AutoSize = true;
            this.RbInsertar.Location = new System.Drawing.Point(64, 48);
            this.RbInsertar.Margin = new System.Windows.Forms.Padding(6);
            this.RbInsertar.Name = "RbInsertar";
            this.RbInsertar.Size = new System.Drawing.Size(130, 29);
            this.RbInsertar.TabIndex = 0;
            this.RbInsertar.TabStop = true;
            this.RbInsertar.Text = "Registrar";
            this.RbInsertar.UseVisualStyleBackColor = true;
            this.RbInsertar.CheckedChanged += new System.EventHandler(this.RbInsertar_CheckedChanged);
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvClientes.Location = new System.Drawing.Point(105, 615);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(6);
            this.DgvClientes.Name = "DgvClientes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvClientes.RowHeadersVisible = false;
            this.DgvClientes.RowHeadersWidth = 82;
            this.DgvClientes.Size = new System.Drawing.Size(1262, 301);
            this.DgvClientes.TabIndex = 13;
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPersonas_CellContentClick);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(373, 537);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(386, 31);
            this.dtpFecha.TabIndex = 14;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(375, 364);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(6);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(386, 31);
            this.txtApellido2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 370);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Segundo Apellido:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(375, 416);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(6);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(386, 31);
            this.txtCorreo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Correo Electrónico:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(375, 469);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(386, 31);
            this.txtCelular.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Número de Celular:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 997);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 63);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1404, 1102);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.GrabarClientes);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrabarClientes.ResumeLayout(false);
            this.GrabarClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.GroupBox GrabarClientes;
        private System.Windows.Forms.RadioButton RbModificar;
        private System.Windows.Forms.RadioButton RbEliminar;
        private System.Windows.Forms.RadioButton RbInsertar;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

