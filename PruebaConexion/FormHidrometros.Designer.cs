
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
            this.button5 = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
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
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(426, 595);
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
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(328, 437);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(386, 31);
            this.txtCategoria.TabIndex = 35;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(328, 368);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(6);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(386, 31);
            this.txtSerie.TabIndex = 34;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(328, 296);
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
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Categoría:";
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
            this.txtNIS.Location = new System.Drawing.Point(328, 231);
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
            this.txtCliente.Location = new System.Drawing.Point(328, 497);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(6);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(386, 31);
            this.txtCliente.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 503);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cliente:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(744, 435);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(300, 33);
            this.cbCategoria.TabIndex = 43;
            // 
            // FormHidrometros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 712);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtCategoria);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtCategoria;
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
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}