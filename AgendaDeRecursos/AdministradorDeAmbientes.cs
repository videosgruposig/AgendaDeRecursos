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
    public partial class AdministradorDeAmbientes : Form
    {
        Ambiente ambiente = new Ambiente();
        bool ModoAdministrador;
        public string AmbienteSeleccionadoNombre;
        public int AmbienteSeleccionadoId;

        public AdministradorDeAmbientes(bool rModoAdministrador)
        {
            InitializeComponent();
            ModoAdministrador = rModoAdministrador;
        }



        private void AdministradorDeAmbientes_Load(object sender, EventArgs e)
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


            dgAmbiente.RowHeadersVisible = false;
            dgAmbiente.AllowUserToAddRows = false;
            dgAmbiente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAmbiente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgAmbiente.DataSource = ambiente.MostrarAmbiente(0,"%");
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //Agregar
            AdmAmbiente Ambiente = new AdmAmbiente();
            Ambiente.Text = "Alta Ambiente";
            Ambiente.ShowDialog();
            dgAmbiente.DataSource = ambiente.MostrarAmbiente(0, "%");
        }

        private void Editar_Click(object sender, EventArgs e)
        {

            //Editar
            AdmAmbiente Ambiente = new AdmAmbiente(Convert.ToInt32(this.dgAmbiente.CurrentRow.Cells[0].Value.ToString()));
            Ambiente.Text = "Editar Ambiente";
            Ambiente.ShowDialog();
            dgAmbiente.DataSource = ambiente.MostrarAmbiente(0, "%");            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            ambiente.EliminarAmbiente(Convert.ToInt32(dgAmbiente.CurrentRow.Cells[0].Value.ToString()));

            //Actualizar el DataGrid
            dgAmbiente.DataSource = ambiente.MostrarAmbiente(0, "%");

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (!ModoAdministrador)
             AmbienteSeleccionadoNombre = this.dgAmbiente.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

    }
}
