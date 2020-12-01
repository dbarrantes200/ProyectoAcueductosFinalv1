
namespace ProyectoFinal
{
    partial class FormFuncionarios
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
            this.rbRegistrar = new System.Windows.Forms.RadioButton();
            this.rRModificar = new System.Windows.Forms.RadioButton();
            this.rBEliminar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbRegistrar
            // 
            this.rbRegistrar.AutoSize = true;
            this.rbRegistrar.Location = new System.Drawing.Point(142, 98);
            this.rbRegistrar.Name = "rbRegistrar";
            this.rbRegistrar.Size = new System.Drawing.Size(130, 29);
            this.rbRegistrar.TabIndex = 0;
            this.rbRegistrar.TabStop = true;
            this.rbRegistrar.Text = "Registrar";
            this.rbRegistrar.UseVisualStyleBackColor = true;
            this.rbRegistrar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rRModificar
            // 
            this.rRModificar.AutoSize = true;
            this.rRModificar.Location = new System.Drawing.Point(417, 98);
            this.rRModificar.Name = "rRModificar";
            this.rRModificar.Size = new System.Drawing.Size(131, 29);
            this.rRModificar.TabIndex = 1;
            this.rRModificar.TabStop = true;
            this.rRModificar.Text = "Modificar";
            this.rRModificar.UseVisualStyleBackColor = true;
            this.rRModificar.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rBEliminar
            // 
            this.rBEliminar.AutoSize = true;
            this.rBEliminar.Location = new System.Drawing.Point(684, 98);
            this.rBEliminar.Name = "rBEliminar";
            this.rBEliminar.Size = new System.Drawing.Size(120, 29);
            this.rBEliminar.TabIndex = 2;
            this.rBEliminar.TabStop = true;
            this.rBEliminar.Text = "Eliminar";
            this.rBEliminar.UseVisualStyleBackColor = true;
            this.rBEliminar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(73, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de Funcionarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(319, 225);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(386, 31);
            this.txtId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Primer Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Segundo Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(319, 290);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(386, 31);
            this.txtNombre.TabIndex = 17;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(319, 362);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(6);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(386, 31);
            this.txtApellido1.TabIndex = 18;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(319, 431);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(6);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(386, 31);
            this.txtApellido2.TabIndex = 19;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(825, 335);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 44);
            this.BtnModificar.TabIndex = 22;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(825, 279);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 44);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(825, 218);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 44);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(417, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 61);
            this.button5.TabIndex = 23;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1080, 655);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBEliminar);
            this.Controls.Add(this.rRModificar);
            this.Controls.Add(this.rbRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormFuncionarios";
            this.Text = "Ingreso de Funcionarios";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbRegistrar;
        private System.Windows.Forms.RadioButton rRModificar;
        private System.Windows.Forms.RadioButton rBEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button button5;
    }
}