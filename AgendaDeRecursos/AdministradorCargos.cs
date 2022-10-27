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
    public partial class AdministradorCargos : Form
    {
        CargosPorEstablecimiento Cargos = new CargosPorEstablecimiento();
        UnidadEducativa uni = new UnidadEducativa();



        public AdministradorCargos()
        {
            InitializeComponent();
        }

        private void AdministradorCargos_Load(object sender, EventArgs e)
        {
            

            // Seteo Del DataGrid


            dgCargos.RowHeadersVisible = false;
            dgCargos.AllowUserToAddRows = false;
            dgCargos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgCargos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;




            cbUnidadEducativa = uni.MostrarUnidadEducativa(cbUnidadEducativa, true);
            dgCargos.DataSource = Cargos.MostrarConsultaCargos(cbUnidadEducativa.Text);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //Agregar
            AdmCargos Cargo = new AdmCargos();
            Cargo.Text = "Alta Cargos";
            Cargo.ShowDialog();
            dgCargos.DataSource = Cargos.MostrarConsultaCargos(cbUnidadEducativa.Text);
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            //Editar

            AdmCargos Cargo = new AdmCargos(Convert.ToInt32(this.dgCargos.CurrentRow.Cells[0].Value.ToString()));

            Cargo.Text = "Editar Cargos";
            Cargo.ShowDialog();
            dgCargos.DataSource = Cargos.MostrarConsultaCargos(cbUnidadEducativa.Text);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Cargos.EliminarCargosPorEstablecimiento(Convert.ToInt32(dgCargos.CurrentRow.Cells[0].Value.ToString()));
            dgCargos.DataSource = Cargos.MostrarConsultaCargos(cbUnidadEducativa.Text);
        }



    }
}
