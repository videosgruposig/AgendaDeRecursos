using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SesionBD;

namespace AgendaDeRecursos
{
    public partial class AdministrarCursoSeccion : Form
    {

        Conexion CursoSeccion = new Conexion();

        public AdministrarCursoSeccion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarCursoSeccion_Load(object sender, EventArgs e)
        {
          //  dgCursoSeccion.DataSource = 
//            dg.DataSource = x.MostrarConsultaCursos(combo.Text);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgCursoSeccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
