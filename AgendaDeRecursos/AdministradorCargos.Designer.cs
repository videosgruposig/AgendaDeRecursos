namespace AgendaDeRecursos
{
    partial class AdministradorCargos
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
            this.cbUnidadEducativa = new System.Windows.Forms.ComboBox();
            this.dgCargos = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Bucar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unidad Educativa:";
            // 
            // cbUnidadEducativa
            // 
            this.cbUnidadEducativa.FormattingEnabled = true;
            this.cbUnidadEducativa.Location = new System.Drawing.Point(113, 10);
            this.cbUnidadEducativa.Name = "cbUnidadEducativa";
            this.cbUnidadEducativa.Size = new System.Drawing.Size(389, 21);
            this.cbUnidadEducativa.TabIndex = 5;
            // 
            // dgCargos
            // 
            this.dgCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCargos.Location = new System.Drawing.Point(15, 53);
            this.dgCargos.Name = "dgCargos";
            this.dgCargos.Size = new System.Drawing.Size(532, 150);
            this.dgCargos.TabIndex = 6;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(15, 313);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 7;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(96, 313);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 8;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(177, 313);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(472, 313);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 10;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Bucar
            // 
            this.Bucar.Location = new System.Drawing.Point(521, 9);
            this.Bucar.Name = "Bucar";
            this.Bucar.Size = new System.Drawing.Size(26, 23);
            this.Bucar.TabIndex = 11;
            this.Bucar.Text = "...";
            this.Bucar.UseVisualStyleBackColor = true;
            // 
            // AdministradorCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 348);
            this.Controls.Add(this.Bucar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dgCargos);
            this.Controls.Add(this.cbUnidadEducativa);
            this.Controls.Add(this.label1);
            this.Name = "AdministradorCargos";
            this.Text = "Administrador de Cargos";
            this.Load += new System.EventHandler(this.AdministradorCargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnidadEducativa;
        private System.Windows.Forms.DataGridView dgCargos;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Bucar;
    }
}