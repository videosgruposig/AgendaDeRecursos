namespace AgendaDeRecursos
{
    partial class AdmAmbiente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vNombre = new System.Windows.Forms.TextBox();
            this.vObservaciones = new System.Windows.Forms.RichTextBox();
            this.vSuperficie = new System.Windows.Forms.TextBox();
            this.cbTipoCubierta = new System.Windows.Forms.ComboBox();
            this.cbEstadoConservacion = new System.Windows.Forms.ComboBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Cubierta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Superficie (mt2):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado de Conservacion:";
            // 
            // vNombre
            // 
            this.vNombre.Location = new System.Drawing.Point(82, 37);
            this.vNombre.Name = "vNombre";
            this.vNombre.Size = new System.Drawing.Size(100, 20);
            this.vNombre.TabIndex = 6;
            // 
            // vObservaciones
            // 
            this.vObservaciones.Location = new System.Drawing.Point(15, 137);
            this.vObservaciones.Name = "vObservaciones";
            this.vObservaciones.Size = new System.Drawing.Size(403, 60);
            this.vObservaciones.TabIndex = 7;
            this.vObservaciones.Text = "";
            // 
            // vSuperficie
            // 
            this.vSuperficie.Location = new System.Drawing.Point(329, 37);
            this.vSuperficie.Name = "vSuperficie";
            this.vSuperficie.Size = new System.Drawing.Size(100, 20);
            this.vSuperficie.TabIndex = 8;
            // 
            // cbTipoCubierta
            // 
            this.cbTipoCubierta.FormattingEnabled = true;
            this.cbTipoCubierta.Location = new System.Drawing.Point(367, 74);
            this.cbTipoCubierta.Name = "cbTipoCubierta";
            this.cbTipoCubierta.Size = new System.Drawing.Size(129, 21);
            this.cbTipoCubierta.TabIndex = 9;
            // 
            // cbEstadoConservacion
            // 
            this.cbEstadoConservacion.FormattingEnabled = true;
            this.cbEstadoConservacion.Location = new System.Drawing.Point(144, 74);
            this.cbEstadoConservacion.Name = "cbEstadoConservacion";
            this.cbEstadoConservacion.Size = new System.Drawing.Size(138, 21);
            this.cbEstadoConservacion.TabIndex = 10;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(325, 234);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 11;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(421, 234);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 12;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // AdmAmbiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 273);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.cbEstadoConservacion);
            this.Controls.Add(this.cbTipoCubierta);
            this.Controls.Add(this.vSuperficie);
            this.Controls.Add(this.vObservaciones);
            this.Controls.Add(this.vNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdmAmbiente";
            this.Text = "AdmAmbiente";
            this.Load += new System.EventHandler(this.AdmAmbiente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox vNombre;
        private System.Windows.Forms.RichTextBox vObservaciones;
        private System.Windows.Forms.TextBox vSuperficie;
        private System.Windows.Forms.ComboBox cbTipoCubierta;
        private System.Windows.Forms.ComboBox cbEstadoConservacion;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Salir;
    }
}