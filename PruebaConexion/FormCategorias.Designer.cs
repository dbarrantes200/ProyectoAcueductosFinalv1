
namespace ProyectoFinal
{
    partial class FormCategorias
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
            this.GrabarCategorias = new System.Windows.Forms.GroupBox();
            this.RbModificar = new System.Windows.Forms.RadioButton();
            this.RbEliminar = new System.Windows.Forms.RadioButton();
            this.RbInsertar = new System.Windows.Forms.RadioButton();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.GrabarCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrabarCategorias
            // 
            this.GrabarCategorias.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrabarCategorias.Controls.Add(this.RbModificar);
            this.GrabarCategorias.Controls.Add(this.RbEliminar);
            this.GrabarCategorias.Controls.Add(this.RbInsertar);
            this.GrabarCategorias.Location = new System.Drawing.Point(6, 46);
            this.GrabarCategorias.Margin = new System.Windows.Forms.Padding(6);
            this.GrabarCategorias.Name = "GrabarCategorias";
            this.GrabarCategorias.Padding = new System.Windows.Forms.Padding(6);
            this.GrabarCategorias.Size = new System.Drawing.Size(849, 115);
            this.GrabarCategorias.TabIndex = 13;
            this.GrabarCategorias.TabStop = false;
            this.GrabarCategorias.Text = "Mantenimiento de Categorias";
            // 
            // RbModificar
            // 
            this.RbModificar.AutoSize = true;
            this.RbModificar.Location = new System.Drawing.Point(605, 53);
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
            this.RbEliminar.Location = new System.Drawing.Point(352, 53);
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
            this.RbInsertar.Location = new System.Drawing.Point(108, 53);
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
            this.BtnModificar.Location = new System.Drawing.Point(897, 348);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 44);
            this.BtnModificar.TabIndex = 16;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(897, 292);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(150, 44);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(897, 231);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 44);
            this.BtnAgregar.TabIndex = 14;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(272, 238);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(6);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(386, 31);
            this.txtCategoria.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código Categoria:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(272, 333);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(386, 31);
            this.txtDescripcion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Descripción:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(465, 519);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 61);
            this.button5.TabIndex = 24;
            this.button5.Text = "Cerrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 702);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GrabarCategorias);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.GrabarCategorias.ResumeLayout(false);
            this.GrabarCategorias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrabarCategorias;
        private System.Windows.Forms.RadioButton RbModificar;
        private System.Windows.Forms.RadioButton RbEliminar;
        private System.Windows.Forms.RadioButton RbInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
    }
}