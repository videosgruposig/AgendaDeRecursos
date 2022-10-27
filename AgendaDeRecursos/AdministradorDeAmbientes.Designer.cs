namespace AgendaDeRecursos
{
    partial class AdministradorDeAmbientes
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
            this.Salir = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.dgAmbiente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAmbiente)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(411, 239);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(70, 24);
            this.Salir.TabIndex = 0;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(164, 239);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(70, 24);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(88, 239);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(70, 24);
            this.Editar.TabIndex = 2;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(12, 239);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(70, 24);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // dgAmbiente
            // 
            this.dgAmbiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAmbiente.Location = new System.Drawing.Point(12, 64);
            this.dgAmbiente.Name = "dgAmbiente";
            this.dgAmbiente.Size = new System.Drawing.Size(479, 150);
            this.dgAmbiente.TabIndex = 4;
            // 
            // AdministradorDeAmbientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 293);
            this.Controls.Add(this.dgAmbiente);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Salir);
            this.Name = "AdministradorDeAmbientes";
            this.Text = "Administrador de Ambientes";
            this.Load += new System.EventHandler(this.AdministradorDeAmbientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAmbiente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridView dgAmbiente;
    }
}