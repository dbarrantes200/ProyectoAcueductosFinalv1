
namespace ProyectoAcueductosFinal
{
    partial class FrmPrincipal
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
            this.btnServidor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServidor
            // 
            this.btnServidor.Location = new System.Drawing.Point(178, 175);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(180, 87);
            this.btnServidor.TabIndex = 0;
            this.btnServidor.Text = "Servidor";
            this.btnServidor.UseVisualStyleBackColor = true;
            this.btnServidor.Click += new System.EventHandler(this.btnServidor_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(481, 175);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(180, 87);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnServidor);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServidor;
        private System.Windows.Forms.Button btnCliente;
    }
}

