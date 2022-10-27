namespace AgendaDeRecursos
{
    partial class AdmCargosVinculados
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.FechaVinculacion = new System.Windows.Forms.DateTimePicker();
            this.GMateria = new System.Windows.Forms.GroupBox();
            this.vId = new System.Windows.Forms.Label();
            this.vHoraRelojReal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vTiempoDeCursada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GCargo = new System.Windows.Forms.GroupBox();
            this.vHoras = new System.Windows.Forms.Label();
            this.vDivisión = new System.Windows.Forms.Label();
            this.vTurno = new System.Windows.Forms.Label();
            this.vAño = new System.Windows.Forms.Label();
            this.vIdC = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GMateria.SuspendLayout();
            this.GCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(590, 195);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 15;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(684, 195);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 14;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha Vinculación:";
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(107, 18);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(170, 21);
            this.cbMateria.TabIndex = 19;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(74, 18);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(267, 21);
            this.cbCargo.TabIndex = 20;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // FechaVinculacion
            // 
            this.FechaVinculacion.Location = new System.Drawing.Point(146, 194);
            this.FechaVinculacion.Name = "FechaVinculacion";
            this.FechaVinculacion.Size = new System.Drawing.Size(200, 20);
            this.FechaVinculacion.TabIndex = 21;
            // 
            // GMateria
            // 
            this.GMateria.Controls.Add(this.vId);
            this.GMateria.Controls.Add(this.vHoraRelojReal);
            this.GMateria.Controls.Add(this.label8);
            this.GMateria.Controls.Add(this.label7);
            this.GMateria.Controls.Add(this.vTiempoDeCursada);
            this.GMateria.Controls.Add(this.label4);
            this.GMateria.Controls.Add(this.cbMateria);
            this.GMateria.Controls.Add(this.label1);
            this.GMateria.Location = new System.Drawing.Point(22, 22);
            this.GMateria.Name = "GMateria";
            this.GMateria.Size = new System.Drawing.Size(367, 137);
            this.GMateria.TabIndex = 22;
            this.GMateria.TabStop = false;
            this.GMateria.Text = "Materia";
            // 
            // vId
            // 
            this.vId.AutoSize = true;
            this.vId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vId.Location = new System.Drawing.Point(53, 52);
            this.vId.Name = "vId";
            this.vId.Size = new System.Drawing.Size(25, 13);
            this.vId.TabIndex = 26;
            this.vId.Text = "vId";
            // 
            // vHoraRelojReal
            // 
            this.vHoraRelojReal.AutoSize = true;
            this.vHoraRelojReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vHoraRelojReal.Location = new System.Drawing.Point(124, 99);
            this.vHoraRelojReal.Name = "vHoraRelojReal";
            this.vHoraRelojReal.Size = new System.Drawing.Size(96, 13);
            this.vHoraRelojReal.TabIndex = 25;
            this.vHoraRelojReal.Text = "vHoraRelojReal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Horas Reloj Real:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tiempo de Cursada:";
            // 
            // vTiempoDeCursada
            // 
            this.vTiempoDeCursada.AutoSize = true;
            this.vTiempoDeCursada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vTiempoDeCursada.Location = new System.Drawing.Point(124, 77);
            this.vTiempoDeCursada.Name = "vTiempoDeCursada";
            this.vTiempoDeCursada.Size = new System.Drawing.Size(117, 13);
            this.vTiempoDeCursada.TabIndex = 21;
            this.vTiempoDeCursada.Text = "vTiempoDeCursada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Id:";
            // 
            // GCargo
            // 
            this.GCargo.Controls.Add(this.vHoras);
            this.GCargo.Controls.Add(this.vDivisión);
            this.GCargo.Controls.Add(this.vTurno);
            this.GCargo.Controls.Add(this.vAño);
            this.GCargo.Controls.Add(this.vIdC);
            this.GCargo.Controls.Add(this.label12);
            this.GCargo.Controls.Add(this.label11);
            this.GCargo.Controls.Add(this.label10);
            this.GCargo.Controls.Add(this.label9);
            this.GCargo.Controls.Add(this.label5);
            this.GCargo.Controls.Add(this.label2);
            this.GCargo.Controls.Add(this.cbCargo);
            this.GCargo.Location = new System.Drawing.Point(395, 22);
            this.GCargo.Name = "GCargo";
            this.GCargo.Size = new System.Drawing.Size(364, 137);
            this.GCargo.TabIndex = 23;
            this.GCargo.TabStop = false;
            this.GCargo.Text = "Cargo";
            // 
            // vHoras
            // 
            this.vHoras.AutoSize = true;
            this.vHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vHoras.Location = new System.Drawing.Point(179, 65);
            this.vHoras.Name = "vHoras";
            this.vHoras.Size = new System.Drawing.Size(47, 13);
            this.vHoras.TabIndex = 29;
            this.vHoras.Text = "vHoras";
            // 
            // vDivisión
            // 
            this.vDivisión.AutoSize = true;
            this.vDivisión.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vDivisión.Location = new System.Drawing.Point(192, 92);
            this.vDivisión.Name = "vDivisión";
            this.vDivisión.Size = new System.Drawing.Size(59, 13);
            this.vDivisión.TabIndex = 28;
            this.vDivisión.Text = "vDivisión";
            // 
            // vTurno
            // 
            this.vTurno.AutoSize = true;
            this.vTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vTurno.Location = new System.Drawing.Point(62, 121);
            this.vTurno.Name = "vTurno";
            this.vTurno.Size = new System.Drawing.Size(47, 13);
            this.vTurno.TabIndex = 27;
            this.vTurno.Text = "vTurno";
            // 
            // vAño
            // 
            this.vAño.AutoSize = true;
            this.vAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vAño.Location = new System.Drawing.Point(71, 92);
            this.vAño.Name = "vAño";
            this.vAño.Size = new System.Drawing.Size(36, 13);
            this.vAño.TabIndex = 26;
            this.vAño.Text = "vAño";
            // 
            // vIdC
            // 
            this.vIdC.AutoSize = true;
            this.vIdC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vIdC.Location = new System.Drawing.Point(71, 65);
            this.vIdC.Name = "vIdC";
            this.vIdC.Size = new System.Drawing.Size(33, 13);
            this.vIdC.TabIndex = 25;
            this.vIdC.Text = "vIdC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "División:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Año:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Turno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(145, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Horas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Id:";
            // 
            // AdmCargosVinculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 248);
            this.Controls.Add(this.GCargo);
            this.Controls.Add(this.GMateria);
            this.Controls.Add(this.FechaVinculacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Name = "AdmCargosVinculados";
            this.Text = "AdmCargosVinculados";
            this.Load += new System.EventHandler(this.AdmCargosVinculados_Load);
            this.GMateria.ResumeLayout(false);
            this.GMateria.PerformLayout();
            this.GCargo.ResumeLayout(false);
            this.GCargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.DateTimePicker FechaVinculacion;
        private System.Windows.Forms.GroupBox GMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label vTiempoDeCursada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label vId;
        private System.Windows.Forms.Label vHoraRelojReal;
        private System.Windows.Forms.Label vHoras;
        private System.Windows.Forms.Label vDivisión;
        private System.Windows.Forms.Label vTurno;
        private System.Windows.Forms.Label vAño;
        private System.Windows.Forms.Label vIdC;
    }
}