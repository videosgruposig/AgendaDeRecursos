namespace AgendaDeRecursos
{
    partial class AdministradorCargosVinculados
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
            this.Eliminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.dgCargoVinculado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vId = new System.Windows.Forms.Label();
            this.vTurno = new System.Windows.Forms.Label();
            this.vCursoDivision = new System.Windows.Forms.Label();
            this.vGrupo = new System.Windows.Forms.Label();
            this.vPlanEstudios = new System.Windows.Forms.Label();
            this.vCurso = new System.Windows.Forms.Label();
            this.vUnidadEducativa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargoVinculado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(193, 311);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 10;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(110, 311);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 9;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(21, 311);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(401, 311);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 11;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // dgCargoVinculado
            // 
            this.dgCargoVinculado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCargoVinculado.Location = new System.Drawing.Point(21, 138);
            this.dgCargoVinculado.Name = "dgCargoVinculado";
            this.dgCargoVinculado.Size = new System.Drawing.Size(455, 131);
            this.dgCargoVinculado.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vId);
            this.groupBox1.Controls.Add(this.vTurno);
            this.groupBox1.Controls.Add(this.vCursoDivision);
            this.groupBox1.Controls.Add(this.vGrupo);
            this.groupBox1.Controls.Add(this.vPlanEstudios);
            this.groupBox1.Controls.Add(this.vCurso);
            this.groupBox1.Controls.Add(this.vUnidadEducativa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 110);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instancia de Grupo";
            // 
            // vId
            // 
            this.vId.AutoSize = true;
            this.vId.Location = new System.Drawing.Point(6, 94);
            this.vId.Name = "vId";
            this.vId.Size = new System.Drawing.Size(25, 13);
            this.vId.TabIndex = 12;
            this.vId.Text = "VID";
            this.vId.Visible = false;
            // 
            // vTurno
            // 
            this.vTurno.AutoSize = true;
            this.vTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vTurno.Location = new System.Drawing.Point(383, 26);
            this.vTurno.Name = "vTurno";
            this.vTurno.Size = new System.Drawing.Size(44, 13);
            this.vTurno.TabIndex = 11;
            this.vTurno.Text = "Turno:";
            // 
            // vCursoDivision
            // 
            this.vCursoDivision.AutoSize = true;
            this.vCursoDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCursoDivision.Location = new System.Drawing.Point(383, 71);
            this.vCursoDivision.Name = "vCursoDivision";
            this.vCursoDivision.Size = new System.Drawing.Size(108, 13);
            this.vCursoDivision.TabIndex = 10;
            this.vCursoDivision.Text = "División/Sección:";
            // 
            // vGrupo
            // 
            this.vGrupo.AutoSize = true;
            this.vGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vGrupo.Location = new System.Drawing.Point(107, 71);
            this.vGrupo.Name = "vGrupo";
            this.vGrupo.Size = new System.Drawing.Size(45, 13);
            this.vGrupo.TabIndex = 8;
            this.vGrupo.Text = "Grupo:";
            // 
            // vPlanEstudios
            // 
            this.vPlanEstudios.AutoSize = true;
            this.vPlanEstudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPlanEstudios.Location = new System.Drawing.Point(107, 49);
            this.vPlanEstudios.Name = "vPlanEstudios";
            this.vPlanEstudios.Size = new System.Drawing.Size(106, 13);
            this.vPlanEstudios.TabIndex = 7;
            this.vPlanEstudios.Text = "Plan de Estudios:";
            // 
            // vCurso
            // 
            this.vCurso.AutoSize = true;
            this.vCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCurso.Location = new System.Drawing.Point(382, 49);
            this.vCurso.Name = "vCurso";
            this.vCurso.Size = new System.Drawing.Size(43, 13);
            this.vCurso.TabIndex = 9;
            this.vCurso.Text = "Curso:";
            // 
            // vUnidadEducativa
            // 
            this.vUnidadEducativa.AutoSize = true;
            this.vUnidadEducativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vUnidadEducativa.Location = new System.Drawing.Point(107, 26);
            this.vUnidadEducativa.Name = "vUnidadEducativa";
            this.vUnidadEducativa.Size = new System.Drawing.Size(112, 13);
            this.vUnidadEducativa.TabIndex = 6;
            this.vUnidadEducativa.Text = "Unidad Educativa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Turno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plan de Estudios:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "División/Sección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidad Educativa:";
            // 
            // AdministradorCargosVinculados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgCargoVinculado);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Agregar);
            this.Name = "AdministradorCargosVinculados";
            this.Text = "Administrador de Cargos Vinculados";
            this.Load += new System.EventHandler(this.AdministradorCargosVinculados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCargoVinculado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.DataGridView dgCargoVinculado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vTurno;
        private System.Windows.Forms.Label vCursoDivision;
        private System.Windows.Forms.Label vCurso;
        private System.Windows.Forms.Label vGrupo;
        private System.Windows.Forms.Label vPlanEstudios;
        private System.Windows.Forms.Label vUnidadEducativa;
        private System.Windows.Forms.Label vId;
    }
}