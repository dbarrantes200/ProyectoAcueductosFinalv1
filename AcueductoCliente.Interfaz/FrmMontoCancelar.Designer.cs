
namespace AcueductoCliente.Interfaz
{
    partial class FrmMontoCancelar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNumeroNIS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textApellido2 = new System.Windows.Forms.TextBox();
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textMesActual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textConsumo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textTarifa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textMesAnterior = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textMontoAntesIVA = new System.Windows.Forms.TextBox();
            this.textIVA = new System.Windows.Forms.TextBox();
            this.textMontoPagar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(360, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Monto a Cancelar";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
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
            this.cbMes.Location = new System.Drawing.Point(871, 36);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(100, 33);
            this.cbMes.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(798, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de NIS";
            // 
            // cbNumeroNIS
            // 
            this.cbNumeroNIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroNIS.FormattingEnabled = true;
            this.cbNumeroNIS.Location = new System.Drawing.Point(184, 39);
            this.cbNumeroNIS.Name = "cbNumeroNIS";
            this.cbNumeroNIS.Size = new System.Drawing.Size(121, 33);
            this.cbNumeroNIS.TabIndex = 4;
            this.cbNumeroNIS.SelectedIndexChanged += new System.EventHandler(this.cbNumeroNIS_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente";
            // 
            // textCliente
            // 
            this.textCliente.Location = new System.Drawing.Point(419, 39);
            this.textCliente.Name = "textCliente";
            this.textCliente.ReadOnly = true;
            this.textCliente.Size = new System.Drawing.Size(121, 31);
            this.textCliente.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.textCategoria);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textApellido2);
            this.groupBox1.Controls.Add(this.textApellido1);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbNumeroNIS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCliente);
            this.groupBox1.Location = new System.Drawing.Point(75, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(990, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Cliente";
            // 
            // textCategoria
            // 
            this.textCategoria.Location = new System.Drawing.Point(684, 33);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.ReadOnly = true;
            this.textCategoria.Size = new System.Drawing.Size(93, 31);
            this.textCategoria.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(562, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "Categoria";
            // 
            // textApellido2
            // 
            this.textApellido2.Location = new System.Drawing.Point(470, 102);
            this.textApellido2.Name = "textApellido2";
            this.textApellido2.ReadOnly = true;
            this.textApellido2.Size = new System.Drawing.Size(121, 31);
            this.textApellido2.TabIndex = 26;
            // 
            // textApellido1
            // 
            this.textApellido1.Location = new System.Drawing.Point(330, 102);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.ReadOnly = true;
            this.textApellido1.Size = new System.Drawing.Size(121, 31);
            this.textApellido1.TabIndex = 25;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(184, 102);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(121, 31);
            this.textNombre.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(635, 105);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(176, 33);
            this.cbCliente.TabIndex = 22;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 581);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 72);
            this.button2.TabIndex = 22;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mes Actual";
            // 
            // textMesActual
            // 
            this.textMesActual.Location = new System.Drawing.Point(257, 47);
            this.textMesActual.Name = "textMesActual";
            this.textMesActual.ReadOnly = true;
            this.textMesActual.Size = new System.Drawing.Size(121, 31);
            this.textMesActual.TabIndex = 9;
            this.textMesActual.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Consumo";
            // 
            // textConsumo
            // 
            this.textConsumo.Location = new System.Drawing.Point(257, 105);
            this.textConsumo.Name = "textConsumo";
            this.textConsumo.ReadOnly = true;
            this.textConsumo.Size = new System.Drawing.Size(121, 31);
            this.textConsumo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tarifa";
            // 
            // textTarifa
            // 
            this.textTarifa.Location = new System.Drawing.Point(652, 111);
            this.textTarifa.Name = "textTarifa";
            this.textTarifa.ReadOnly = true;
            this.textTarifa.Size = new System.Drawing.Size(121, 31);
            this.textTarifa.TabIndex = 13;
            this.textTarifa.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Monto antes IVA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "IVA 13%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 678);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Monto a Pagar";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.textMesAnterior);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textMesActual);
            this.groupBox2.Controls.Add(this.textConsumo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textTarifa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(75, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 184);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lecturas Hidrometro";
            // 
            // textMesAnterior
            // 
            this.textMesAnterior.Location = new System.Drawing.Point(652, 47);
            this.textMesAnterior.Name = "textMesAnterior";
            this.textMesAnterior.ReadOnly = true;
            this.textMesAnterior.Size = new System.Drawing.Size(121, 31);
            this.textMesAnterior.TabIndex = 14;
            this.textMesAnterior.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Mes Anterior";
            // 
            // textMontoAntesIVA
            // 
            this.textMontoAntesIVA.Location = new System.Drawing.Point(390, 539);
            this.textMontoAntesIVA.Name = "textMontoAntesIVA";
            this.textMontoAntesIVA.ReadOnly = true;
            this.textMontoAntesIVA.Size = new System.Drawing.Size(121, 31);
            this.textMontoAntesIVA.TabIndex = 18;
            this.textMontoAntesIVA.Text = "0";
            // 
            // textIVA
            // 
            this.textIVA.Location = new System.Drawing.Point(390, 605);
            this.textIVA.Name = "textIVA";
            this.textIVA.ReadOnly = true;
            this.textIVA.Size = new System.Drawing.Size(121, 31);
            this.textIVA.TabIndex = 19;
            this.textIVA.Text = "0";
            // 
            // textMontoPagar
            // 
            this.textMontoPagar.Location = new System.Drawing.Point(390, 672);
            this.textMontoPagar.Name = "textMontoPagar";
            this.textMontoPagar.ReadOnly = true;
            this.textMontoPagar.Size = new System.Drawing.Size(121, 31);
            this.textMontoPagar.TabIndex = 20;
            this.textMontoPagar.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 751);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMontoCancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 883);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textMontoPagar);
            this.Controls.Add(this.textIVA);
            this.Controls.Add(this.textMontoAntesIVA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmMontoCancelar";
            this.Text = "Consulta Monto a Cancelar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNumeroNIS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textMesActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textConsumo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTarifa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textMesAnterior;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textMontoAntesIVA;
        private System.Windows.Forms.TextBox textIVA;
        private System.Windows.Forms.TextBox textMontoPagar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox textApellido2;
        private System.Windows.Forms.TextBox textApellido1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.Label label13;
    }
}