
namespace ProyectoFinal
{
    partial class FormHidrometros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rBEliminar = new System.Windows.Forms.RadioButton();
            this.rRModificar = new System.Windows.Forms.RadioButton();
            this.rBRegistrar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textApe1 = new System.Windows.Forms.TextBox();
            this.textApe2 = new System.Windows.Forms.TextBox();
            this.DgvHidrometros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHidrometros)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(565, 1024);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 61);
            this.button5.TabIndex = 39;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(834, 341);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 44);
            this.BtnModificar.TabIndex = 38;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(834, 285);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 44);
            this.BtnEliminar.TabIndex = 37;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(834, 224);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 44);
            this.BtnAgregar.TabIndex = 36;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(769, 440);
            this.txtCat.Margin = new System.Windows.Forms.Padding(6);
            this.txtCat.Name = "txtCat";
            this.txtCat.ReadOnly = true;
            this.txtCat.Size = new System.Drawing.Size(310, 31);
            this.txtCat.TabIndex = 35;
            this.txtCat.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(319, 368);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(6);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(386, 31);
            this.txtSerie.TabIndex = 34;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(319, 299);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(6);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(386, 31);
            this.txtMarca.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Descripcion/Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número de serie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Marca:";
            // 
            // txtNIS
            // 
            this.txtNIS.Location = new System.Drawing.Point(319, 231);
            this.txtNIS.Margin = new System.Windows.Forms.Padding(6);
            this.txtNIS.Name = "txtNIS";
            this.txtNIS.Size = new System.Drawing.Size(386, 31);
            this.txtNIS.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Número de NIS:";
            // 
            // rBEliminar
            // 
            this.rBEliminar.AutoSize = true;
            this.rBEliminar.Location = new System.Drawing.Point(693, 104);
            this.rBEliminar.Name = "rBEliminar";
            this.rBEliminar.Size = new System.Drawing.Size(120, 29);
            this.rBEliminar.TabIndex = 26;
            this.rBEliminar.TabStop = true;
            this.rBEliminar.Text = "Eliminar";
            this.rBEliminar.UseVisualStyleBackColor = true;
            this.rBEliminar.CheckedChanged += new System.EventHandler(this.rBEliminar_CheckedChanged);
            // 
            // rRModificar
            // 
            this.rRModificar.AutoSize = true;
            this.rRModificar.Location = new System.Drawing.Point(426, 104);
            this.rRModificar.Name = "rRModificar";
            this.rRModificar.Size = new System.Drawing.Size(131, 29);
            this.rRModificar.TabIndex = 25;
            this.rRModificar.TabStop = true;
            this.rRModificar.Text = "Modificar";
            this.rRModificar.UseVisualStyleBackColor = true;
            this.rRModificar.CheckedChanged += new System.EventHandler(this.rRModificar_CheckedChanged);
            // 
            // rBRegistrar
            // 
            this.rBRegistrar.AutoSize = true;
            this.rBRegistrar.Location = new System.Drawing.Point(151, 104);
            this.rBRegistrar.Name = "rBRegistrar";
            this.rBRegistrar.Size = new System.Drawing.Size(130, 29);
            this.rBRegistrar.TabIndex = 24;
            this.rBRegistrar.TabStop = true;
            this.rBRegistrar.Text = "Registrar";
            this.rBRegistrar.UseVisualStyleBackColor = true;
            this.rBRegistrar.CheckedChanged += new System.EventHandler(this.rBRegistrar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(82, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 117);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de Hidrometros";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(769, 497);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(6);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(309, 31);
            this.txtCliente.TabIndex = 41;
            this.txtCliente.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 503);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cliente/Identificacion:";
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(319, 435);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(386, 33);
            this.cbCat.TabIndex = 43;
            this.cbCat.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(319, 495);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(386, 33);
            this.cbCliente.TabIndex = 44;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nombre del Cliente:";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(319, 562);
            this.textNom.Margin = new System.Windows.Forms.Padding(6);
            this.textNom.Name = "textNom";
            this.textNom.ReadOnly = true;
            this.textNom.Size = new System.Drawing.Size(155, 31);
            this.textNom.TabIndex = 46;
            // 
            // textApe1
            // 
            this.textApe1.Location = new System.Drawing.Point(500, 562);
            this.textApe1.Margin = new System.Windows.Forms.Padding(6);
            this.textApe1.Name = "textApe1";
            this.textApe1.ReadOnly = true;
            this.textApe1.Size = new System.Drawing.Size(155, 31);
            this.textApe1.TabIndex = 47;
            // 
            // textApe2
            // 
            this.textApe2.Location = new System.Drawing.Point(678, 562);
            this.textApe2.Margin = new System.Windows.Forms.Padding(6);
            this.textApe2.Name = "textApe2";
            this.textApe2.ReadOnly = true;
            this.textApe2.Size = new System.Drawing.Size(155, 31);
            this.textApe2.TabIndex = 48;
            // 
            // DgvHidrometros
            // 
            this.DgvHidrometros.AllowUserToAddRows = false;
            this.DgvHidrometros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHidrometros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHidrometros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvHidrometros.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvHidrometros.Location = new System.Drawing.Point(92, 670);
            this.DgvHidrometros.Margin = new System.Windows.Forms.Padding(6);
            this.DgvHidrometros.Name = "DgvHidrometros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHidrometros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvHidrometros.RowHeadersVisible = false;
            this.DgvHidrometros.RowHeadersWidth = 82;
            this.DgvHidrometros.Size = new System.Drawing.Size(1262, 301);
            this.DgvHidrometros.TabIndex = 49;
            // 
            // FormHidrometros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1484, 1154);
            this.Controls.Add(this.DgvHidrometros);
            this.Controls.Add(this.textApe2);
            this.Controls.Add(this.textApe1);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNIS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBEliminar);
            this.Controls.Add(this.rRModificar);
            this.Controls.Add(this.rBRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHidrometros";
            this.Text = "Ingreso de Hidrometros";
            this.Load += new System.EventHandler(this.FormHidrometros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHidrometros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBEliminar;
        private System.Windows.Forms.RadioButton rRModificar;
        private System.Windows.Forms.RadioButton rBRegistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textApe1;
        private System.Windows.Forms.TextBox textApe2;
        private System.Windows.Forms.DataGridView DgvHidrometros;
    }
}