namespace AgendaDeRecursos
{
    partial class AltaAgrupaciones
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
            this.txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.idAgrupaciones = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.dgEstructuraCurricular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstructuraCurricular)).BeginInit();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(59, 37);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(19, 13);
            this.txt.TabIndex = 0;
            this.txt.Text = "Id:";
            this.txt.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EstructuraCurricular:";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(189, 248);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(82, 26);
            this.Aceptar.TabIndex = 3;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(298, 248);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(82, 26);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Cancelar";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // idAgrupaciones
            // 
            this.idAgrupaciones.Enabled = false;
            this.idAgrupaciones.Location = new System.Drawing.Point(104, 34);
            this.idAgrupaciones.Name = "idAgrupaciones";
            this.idAgrupaciones.Size = new System.Drawing.Size(38, 20);
            this.idAgrupaciones.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(104, 69);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(223, 20);
            this.nombre.TabIndex = 6;
            // 
            // dgEstructuraCurricular
            // 
            this.dgEstructuraCurricular.AllowUserToAddRows = false;
            this.dgEstructuraCurricular.AllowUserToDeleteRows = false;
            this.dgEstructuraCurricular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEstructuraCurricular.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEstructuraCurricular.Location = new System.Drawing.Point(32, 127);
            this.dgEstructuraCurricular.Name = "dgEstructuraCurricular";
            this.dgEstructuraCurricular.ReadOnly = true;
            this.dgEstructuraCurricular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstructuraCurricular.Size = new System.Drawing.Size(415, 93);
            this.dgEstructuraCurricular.TabIndex = 7;
            // 
            // AltaAgrupaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 279);
            this.Controls.Add(this.dgEstructuraCurricular);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.idAgrupaciones);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt);
            this.Name = "AltaAgrupaciones";
            this.Text = "Alta Agrupaciones";
            this.Load += new System.EventHandler(this.Agrupaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstructuraCurricular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox idAgrupaciones;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.DataGridView dgEstructuraCurricular;
    }
}