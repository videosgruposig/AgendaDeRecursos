namespace AgendaDeRecursos
{
    partial class AdmCargarItem
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
            this.vSala = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vHoraInicio = new System.Windows.Forms.TextBox();
            this.vHoraFin = new System.Windows.Forms.TextBox();
            this.btListaMaterias = new System.Windows.Forms.Button();
            this.vMateria = new System.Windows.Forms.TextBox();
            this.btListaAmbientes = new System.Windows.Forms.Button();
            this.vAmbiente = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia*:";
            // 
            // vSala
            // 
            this.vSala.AutoSize = true;
            this.vSala.Location = new System.Drawing.Point(302, 23);
            this.vSala.Name = "vSala";
            this.vSala.Size = new System.Drawing.Size(58, 13);
            this.vSala.TabIndex = 2;
            this.vSala.Text = "Ambiente*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hora inicio:";
            // 
            // vHoraInicio
            // 
            this.vHoraInicio.Location = new System.Drawing.Point(109, 66);
            this.vHoraInicio.Name = "vHoraInicio";
            this.vHoraInicio.Size = new System.Drawing.Size(75, 20);
            this.vHoraInicio.TabIndex = 7;
            this.vHoraInicio.Validated += new System.EventHandler(this.vHoraInicio_Validated);
            // 
            // vHoraFin
            // 
            this.vHoraFin.Location = new System.Drawing.Point(423, 62);
            this.vHoraFin.Name = "vHoraFin";
            this.vHoraFin.Size = new System.Drawing.Size(75, 20);
            this.vHoraFin.TabIndex = 8;
            this.vHoraFin.Validated += new System.EventHandler(this.vHoraFin_Validated);
            // 
            // btListaMaterias
            // 
            this.btListaMaterias.Location = new System.Drawing.Point(245, 18);
            this.btListaMaterias.Name = "btListaMaterias";
            this.btListaMaterias.Size = new System.Drawing.Size(25, 23);
            this.btListaMaterias.TabIndex = 9;
            this.btListaMaterias.Text = "...";
            this.btListaMaterias.UseVisualStyleBackColor = true;
            this.btListaMaterias.Click += new System.EventHandler(this.btListaMaterias_Click);
            // 
            // vMateria
            // 
            this.vMateria.Location = new System.Drawing.Point(89, 19);
            this.vMateria.Name = "vMateria";
            this.vMateria.ReadOnly = true;
            this.vMateria.Size = new System.Drawing.Size(150, 20);
            this.vMateria.TabIndex = 11;
            // 
            // btListaAmbientes
            // 
            this.btListaAmbientes.Location = new System.Drawing.Point(522, 18);
            this.btListaAmbientes.Name = "btListaAmbientes";
            this.btListaAmbientes.Size = new System.Drawing.Size(25, 23);
            this.btListaAmbientes.TabIndex = 12;
            this.btListaAmbientes.Text = "...";
            this.btListaAmbientes.UseVisualStyleBackColor = true;
            this.btListaAmbientes.Click += new System.EventHandler(this.btListaAmbientes_Click);
            // 
            // vAmbiente
            // 
            this.vAmbiente.Location = new System.Drawing.Point(366, 19);
            this.vAmbiente.Name = "vAmbiente";
            this.vAmbiente.ReadOnly = true;
            this.vAmbiente.Size = new System.Drawing.Size(150, 20);
            this.vAmbiente.TabIndex = 13;
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(472, 124);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 14;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // AdmCargarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 159);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.vAmbiente);
            this.Controls.Add(this.btListaAmbientes);
            this.Controls.Add(this.vMateria);
            this.Controls.Add(this.btListaMaterias);
            this.Controls.Add(this.vHoraFin);
            this.Controls.Add(this.vHoraInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vSala);
            this.Controls.Add(this.label1);
            this.Name = "AdmCargarItem";
            this.Text = "Administrador de Item";
            this.Load += new System.EventHandler(this.AdmCargarItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vHoraInicio;
        private System.Windows.Forms.TextBox vHoraFin;
        private System.Windows.Forms.Button btListaMaterias;
        private System.Windows.Forms.TextBox vMateria;
        private System.Windows.Forms.Button btListaAmbientes;
        private System.Windows.Forms.TextBox vAmbiente;
        private System.Windows.Forms.Button Aceptar;
    }
}