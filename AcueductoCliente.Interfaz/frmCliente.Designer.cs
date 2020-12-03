
namespace AcueductoCliente.Interfaz
{
    partial class frmCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaestros = new System.Windows.Forms.Button();
            this.btnConsultaMonto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdentificador);
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1233, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión con el servidor";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(194, 44);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(150, 25);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Desconectado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Identificador:";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(193, 136);
            this.txtIdentificador.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdentificador.MaxLength = 15;
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(196, 31);
            this.txtIdentificador.TabIndex = 8;
            this.txtIdentificador.Leave += new System.EventHandler(this.txtIdentificador_TextChanged);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(919, 130);
            this.btnDesconectar.Margin = new System.Windows.Forms.Padding(6);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(180, 44);
            this.btnDesconectar.TabIndex = 7;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(677, 130);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(6);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(168, 44);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado:";
            // 
            // btnMaestros
            // 
            this.btnMaestros.Location = new System.Drawing.Point(145, 391);
            this.btnMaestros.Name = "btnMaestros";
            this.btnMaestros.Size = new System.Drawing.Size(439, 177);
            this.btnMaestros.TabIndex = 1;
            this.btnMaestros.Text = "Mantenimiento de Maestros";
            this.btnMaestros.UseVisualStyleBackColor = true;
            this.btnMaestros.Click += new System.EventHandler(this.btnMaestros_Click);
            // 
            // btnConsultaMonto
            // 
            this.btnConsultaMonto.Location = new System.Drawing.Point(711, 391);
            this.btnConsultaMonto.Name = "btnConsultaMonto";
            this.btnConsultaMonto.Size = new System.Drawing.Size(439, 177);
            this.btnConsultaMonto.TabIndex = 2;
            this.btnConsultaMonto.Text = "Consulta Monto a Cancelar";
            this.btnConsultaMonto.UseVisualStyleBackColor = true;
            this.btnConsultaMonto.Click += new System.EventHandler(this.btnConsultaMonto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultaMonto);
            this.Controls.Add(this.btnMaestros);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCliente";
            this.Text = "Formulario Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaestros;
        private System.Windows.Forms.Button btnConsultaMonto;
        private System.Windows.Forms.Button button1;
    }
}

