namespace AgendaDeRecursos
{
    partial class AdmPlanEstudio
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
            this.dgPlanEstudio = new System.Windows.Forms.DataGridView();
            this.Salir = new System.Windows.Forms.Button();
            this.Materias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanEstudio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlanEstudio
            // 
            this.dgPlanEstudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanEstudio.Location = new System.Drawing.Point(34, 55);
            this.dgPlanEstudio.Name = "dgPlanEstudio";
            this.dgPlanEstudio.Size = new System.Drawing.Size(531, 110);
            this.dgPlanEstudio.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(490, 208);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Materias
            // 
            this.Materias.Location = new System.Drawing.Point(242, 208);
            this.Materias.Name = "Materias";
            this.Materias.Size = new System.Drawing.Size(75, 23);
            this.Materias.TabIndex = 2;
            this.Materias.Text = "Materias";
            this.Materias.UseVisualStyleBackColor = true;
            this.Materias.Click += new System.EventHandler(this.Materias_Click);
            // 
            // AdmPlanEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 262);
            this.Controls.Add(this.Materias);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.dgPlanEstudio);
            this.Name = "AdmPlanEstudio";
            this.Text = "Administrar Planes de Estudio";
            this.Load += new System.EventHandler(this.AdmPlanEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanEstudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlanEstudio;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Materias;
    }
}