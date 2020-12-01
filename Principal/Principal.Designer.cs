
namespace Principal
{
    partial class Principal
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnServidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(618, 273);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(200, 105);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnServidor
            // 
            this.btnServidor.Location = new System.Drawing.Point(286, 273);
            this.btnServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.Size = new System.Drawing.Size(200, 105);
            this.btnServidor.TabIndex = 4;
            this.btnServidor.Text = "Servidor";
            this.btnServidor.UseVisualStyleBackColor = true;
            this.btnServidor.Click += new System.EventHandler(this.btnServidor_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 650);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnServidor);
            this.Name = "Principal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnServidor;
    }
}

