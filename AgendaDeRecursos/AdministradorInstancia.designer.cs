namespace AgendaDeRecursos
{
    partial class AdministradorInstancia
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Agenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(43, 68);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(711, 150);
            this.dg.TabIndex = 0;
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(153, 12);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(378, 21);
            this.combo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unidad Educativa:";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(679, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(43, 276);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(132, 276);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 6;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cargos Vinculados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Agenda
            // 
            this.Agenda.Location = new System.Drawing.Point(496, 276);
            this.Agenda.Name = "Agenda";
            this.Agenda.Size = new System.Drawing.Size(75, 23);
            this.Agenda.TabIndex = 10;
            this.Agenda.Text = "Agenda";
            this.Agenda.UseVisualStyleBackColor = true;
            this.Agenda.Click += new System.EventHandler(this.Agenda_Click);
            // 
            // AdministradorInstancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.Agenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.dg);
            this.Name = "AdministradorInstancia";
            this.Text = "Administrador de Curso/Sección";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Agenda;
        
    }
}