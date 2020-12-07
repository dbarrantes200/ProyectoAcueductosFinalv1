
namespace ProyectoFinal
{
    partial class HistorialConsumoForm
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.GrabarConsumos = new System.Windows.Forms.GroupBox();
            this.RbModificar = new System.Windows.Forms.RadioButton();
            this.RbEliminar = new System.Windows.Forms.RadioButton();
            this.RbInsertar = new System.Windows.Forms.RadioButton();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtLectura = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtNIS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.comboNIS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            this.GrabarConsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(247, 374);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(386, 31);
            this.dtpFecha.TabIndex = 33;
            // 
            // DgvPersonas
            // 
            this.DgvPersonas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPersonas.Location = new System.Drawing.Point(37, 438);
            this.DgvPersonas.Margin = new System.Windows.Forms.Padding(6);
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.RowHeadersWidth = 82;
            this.DgvPersonas.Size = new System.Drawing.Size(786, 205);
            this.DgvPersonas.TabIndex = 32;
            // 
            // GrabarConsumos
            // 
            this.GrabarConsumos.Controls.Add(this.RbModificar);
            this.GrabarConsumos.Controls.Add(this.RbEliminar);
            this.GrabarConsumos.Controls.Add(this.RbInsertar);
            this.GrabarConsumos.Location = new System.Drawing.Point(48, 43);
            this.GrabarConsumos.Margin = new System.Windows.Forms.Padding(6);
            this.GrabarConsumos.Name = "GrabarConsumos";
            this.GrabarConsumos.Padding = new System.Windows.Forms.Padding(6);
            this.GrabarConsumos.Size = new System.Drawing.Size(788, 110);
            this.GrabarConsumos.TabIndex = 31;
            this.GrabarConsumos.TabStop = false;
            this.GrabarConsumos.Text = "Mantenimiento de Consumos";
            // 
            // RbModificar
            // 
            this.RbModificar.AutoSize = true;
            this.RbModificar.Location = new System.Drawing.Point(492, 38);
            this.RbModificar.Margin = new System.Windows.Forms.Padding(6);
            this.RbModificar.Name = "RbModificar";
            this.RbModificar.Size = new System.Drawing.Size(131, 29);
            this.RbModificar.TabIndex = 2;
            this.RbModificar.Text = "Modificar";
            this.RbModificar.UseVisualStyleBackColor = true;
            this.RbModificar.CheckedChanged += new System.EventHandler(this.RbModificar_CheckedChanged);
            // 
            // RbEliminar
            // 
            this.RbEliminar.AutoSize = true;
            this.RbEliminar.Location = new System.Drawing.Point(258, 38);
            this.RbEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.RbEliminar.Name = "RbEliminar";
            this.RbEliminar.Size = new System.Drawing.Size(120, 29);
            this.RbEliminar.TabIndex = 1;
            this.RbEliminar.Text = "Eliminar";
            this.RbEliminar.UseVisualStyleBackColor = true;
            this.RbEliminar.CheckedChanged += new System.EventHandler(this.RbEliminar_CheckedChanged);
            // 
            // RbInsertar
            // 
            this.RbInsertar.AutoSize = true;
            this.RbInsertar.Checked = true;
            this.RbInsertar.Location = new System.Drawing.Point(14, 38);
            this.RbInsertar.Margin = new System.Windows.Forms.Padding(6);
            this.RbInsertar.Name = "RbInsertar";
            this.RbInsertar.Size = new System.Drawing.Size(130, 29);
            this.RbInsertar.TabIndex = 0;
            this.RbInsertar.TabStop = true;
            this.RbInsertar.Text = "Registrar";
            this.RbInsertar.UseVisualStyleBackColor = true;
            this.RbInsertar.CheckedChanged += new System.EventHandler(this.RbInsertar_CheckedChanged);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(686, 320);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 44);
            this.BtnModificar.TabIndex = 30;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(686, 264);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 44);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(686, 203);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 44);
            this.BtnAgregar.TabIndex = 28;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtLectura
            // 
            this.txtLectura.Location = new System.Drawing.Point(248, 314);
            this.txtLectura.Margin = new System.Windows.Forms.Padding(6);
            this.txtLectura.Name = "txtLectura";
            this.txtLectura.Size = new System.Drawing.Size(386, 31);
            this.txtLectura.TabIndex = 27;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(514, 739);
            this.txtMes.Margin = new System.Windows.Forms.Padding(6);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(386, 31);
            this.txtMes.TabIndex = 26;
            this.txtMes.Visible = false;
            // 
            // txtNIS
            // 
            this.txtNIS.Location = new System.Drawing.Point(514, 683);
            this.txtNIS.Margin = new System.Windows.Forms.Padding(6);
            this.txtNIS.Name = "txtNIS";
            this.txtNIS.Size = new System.Drawing.Size(386, 31);
            this.txtNIS.TabIndex = 25;
            this.txtNIS.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Fecha Lectura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lectura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "NIS:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 701);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboMes
            // 
            this.comboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboMes.Location = new System.Drawing.Point(250, 264);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(386, 33);
            this.comboMes.TabIndex = 35;
            this.comboMes.UseWaitCursor = true;
            this.comboMes.SelectedIndexChanged += new System.EventHandler(this.comboMes_SelectedIndexChanged);
            // 
            // comboNIS
            // 
            this.comboNIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNIS.FormattingEnabled = true;
            this.comboNIS.Location = new System.Drawing.Point(250, 204);
            this.comboNIS.Name = "comboNIS";
            this.comboNIS.Size = new System.Drawing.Size(382, 33);
            this.comboNIS.TabIndex = 36;
            this.comboNIS.SelectedIndexChanged += new System.EventHandler(this.comboNIS_SelectedIndexChanged);
            // 
            // HistorialConsumoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 799);
            this.Controls.Add(this.comboNIS);
            this.Controls.Add(this.comboMes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.GrabarConsumos);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtLectura);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtNIS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HistorialConsumoForm";
            this.Text = "Historial Consumo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            this.GrabarConsumos.ResumeLayout(false);
            this.GrabarConsumos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.GroupBox GrabarConsumos;
        private System.Windows.Forms.RadioButton RbModificar;
        private System.Windows.Forms.RadioButton RbEliminar;
        private System.Windows.Forms.RadioButton RbInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtLectura;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtNIS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboNIS;
        protected System.Windows.Forms.ComboBox comboMes;
    }
}