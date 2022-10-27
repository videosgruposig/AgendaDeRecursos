namespace AgendaDeRecursos
{
    partial class AdministrarCursoSeccion
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
            this.dgCursoSeccion = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCursoSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCursoSeccion
            // 
            this.dgCursoSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCursoSeccion.Location = new System.Drawing.Point(51, 76);
            this.dgCursoSeccion.Name = "dgCursoSeccion";
            this.dgCursoSeccion.Size = new System.Drawing.Size(439, 150);
            this.dgCursoSeccion.TabIndex = 0;
            this.dgCursoSeccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCursoSeccion_CellContentClick);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(51, 256);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(151, 256);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 2;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(254, 256);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(415, 256);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // AdministrarCursoSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 291);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.dgCursoSeccion);
            this.Name = "AdministrarCursoSeccion";
            this.Text = "AdministrarCursoSeccion";
            this.Load += new System.EventHandler(this.AdministrarCursoSeccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCursoSeccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCursoSeccion;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Salir;
    }
}