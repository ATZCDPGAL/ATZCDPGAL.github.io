namespace SistemaSuperSecreto_1._0
{
    partial class VentanaPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbvisualc = new System.Windows.Forms.CheckBox();
            this.cbvisualbasic = new System.Windows.Forms.CheckBox();
            this.rdtarjeta = new System.Windows.Forms.RadioButton();
            this.rdpaypal = new System.Windows.Forms.RadioButton();
            this.btncomprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cursos en venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Formas de pago ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbvisualc
            // 
            this.cbvisualc.AutoSize = true;
            this.cbvisualc.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvisualc.Location = new System.Drawing.Point(109, 153);
            this.cbvisualc.Name = "cbvisualc";
            this.cbvisualc.Size = new System.Drawing.Size(138, 34);
            this.cbvisualc.TabIndex = 4;
            this.cbvisualc.Text = "Visual C#";
            this.cbvisualc.UseVisualStyleBackColor = true;
            // 
            // cbvisualbasic
            // 
            this.cbvisualbasic.AutoSize = true;
            this.cbvisualbasic.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvisualbasic.Location = new System.Drawing.Point(109, 202);
            this.cbvisualbasic.Name = "cbvisualbasic";
            this.cbvisualbasic.Size = new System.Drawing.Size(164, 34);
            this.cbvisualbasic.TabIndex = 5;
            this.cbvisualbasic.Text = "Visual Basic";
            this.cbvisualbasic.UseVisualStyleBackColor = true;
            // 
            // rdtarjeta
            // 
            this.rdtarjeta.AutoSize = true;
            this.rdtarjeta.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtarjeta.Location = new System.Drawing.Point(716, 153);
            this.rdtarjeta.Name = "rdtarjeta";
            this.rdtarjeta.Size = new System.Drawing.Size(241, 34);
            this.rdtarjeta.TabIndex = 6;
            this.rdtarjeta.TabStop = true;
            this.rdtarjeta.Text = "Tarjeta de Credito ";
            this.rdtarjeta.UseVisualStyleBackColor = true;
            // 
            // rdpaypal
            // 
            this.rdpaypal.AutoSize = true;
            this.rdpaypal.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpaypal.Location = new System.Drawing.Point(716, 202);
            this.rdpaypal.Name = "rdpaypal";
            this.rdpaypal.Size = new System.Drawing.Size(107, 34);
            this.rdpaypal.TabIndex = 7;
            this.rdpaypal.TabStop = true;
            this.rdpaypal.Text = "Paypal";
            this.rdpaypal.UseVisualStyleBackColor = true;
            // 
            // btncomprar
            // 
            this.btncomprar.Location = new System.Drawing.Point(334, 397);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(153, 59);
            this.btncomprar.TabIndex = 8;
            this.btncomprar.Text = "Comprar";
            this.btncomprar.UseVisualStyleBackColor = true;
            this.btncomprar.Click += new System.EventHandler(this.btncomprar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.rdpaypal);
            this.Controls.Add(this.rdtarjeta);
            this.Controls.Add(this.cbvisualbasic);
            this.Controls.Add(this.cbvisualc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbvisualc;
        private System.Windows.Forms.CheckBox cbvisualbasic;
        private System.Windows.Forms.RadioButton rdtarjeta;
        private System.Windows.Forms.RadioButton rdpaypal;
        private System.Windows.Forms.Button btncomprar;
    }
}