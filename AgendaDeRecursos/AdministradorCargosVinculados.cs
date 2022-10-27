using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace AgendaDeRecursos
{
    public partial class AdministradorCargosVinculados : Form
    {
        CargoVinculado CargoVinculado = new CargoVinculado();
        bool ModoAdministrador;
        public string MateriaSeleccionada;

        public AdministradorCargosVinculados(InstanciaGrupo InstanciaGrupo, bool rModoAdministrador)
        {
            InitializeComponent();
            ModoAdministrador = rModoAdministrador;
 
            vId.Text = InstanciaGrupo.IdCursoSeccion.ToString();
            vUnidadEducativa.Text = InstanciaGrupo.UnidadEducativaNombre1;
            vPlanEstudios.Text = InstanciaGrupo.PlanDeEstudioNombre1;
            vGrupo.Text = InstanciaGrupo.AgrupacionNombre1;
            vCurso.Text = InstanciaGrupo.Curso1;
            vCursoDivision.Text = InstanciaGrupo.Division1;
            vTurno.Text = InstanciaGrupo.Turno1;




        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (!ModoAdministrador)
                MateriaSeleccionada = this.dgCargoVinculado.CurrentRow.Cells[1].Value.ToString();
 
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //Agregar
            AdmCargosVinculados fCargoVinculado = new AdmCargosVinculados(Convert.ToInt32(vId.Text), vUnidadEducativa.Text);
            fCargoVinculado.Text = "Alta Vinculación";
            fCargoVinculado.ShowDialog();

            //Actualizar el DataGrid
            dgCargoVinculado.DataSource = CargoVinculado.MostrarConsultaCargoVinculado(Convert.ToInt32(vId.Text));
        }

        private void AdministradorCargosVinculados_Load(object sender, EventArgs e)
        {
            // Si no es modo Administrador, oculto botones
            if (!ModoAdministrador)
            {
                Agregar.Hide();
                Editar.Hide();
                Eliminar.Hide();
                Salir.Text = "Aceptar";

            }

            // Seteo Del DataGrid

            dgCargoVinculado.RowHeadersVisible = false;
            dgCargoVinculado.AllowUserToAddRows = false;
            dgCargoVinculado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCargoVinculado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgCargoVinculado.DataSource = CargoVinculado.MostrarConsultaCargoVinculado(Convert.ToInt32(vId.Text));
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            CargoVinculado.EliminarCargoVinculado(Convert.ToInt32(dgCargoVinculado.CurrentRow.Cells[0].Value.ToString()));
            dgCargoVinculado.DataSource = CargoVinculado.MostrarConsultaCargoVinculado(Convert.ToInt32(vId.Text));
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            //Editar
            AdmCargosVinculados fCargoVinculado = new AdmCargosVinculados(Convert.ToInt32(vId.Text), vUnidadEducativa.Text, Convert.ToInt32(dgCargoVinculado.CurrentRow.Cells[0].Value.ToString()));
            fCargoVinculado.Text = "Editar Vinculación";
            fCargoVinculado.ShowDialog();
            
            //Actualizar el DataGrid
            dgCargoVinculado.DataSource = CargoVinculado.MostrarConsultaCargoVinculado(Convert.ToInt32(vId.Text));

        }

    }
}
