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
    public partial class AdmMateriaPorPlan : Form
    {
        MateriaPorPlanes MatxPla = new MateriaPorPlanes();

        public AdmMateriaPorPlan(string Id, string Agrup, string Estr, string Plan, string Unid)
        {

            InitializeComponent();

            vId.Text = Id;
            vAgrupacion.Text = Agrup;
            vEstructuraCurricular.Text = Estr;
            vPlandeEstudio.Text = Plan;
            vUnidadEducativa.Text = Unid;

        }


        private void AdmMateriaPorPlan_Load(object sender, EventArgs e)
        {
            // Seteo Del DataGrid

            dgMateriaPorPlan.RowHeadersVisible = false;
            dgMateriaPorPlan.AllowUserToAddRows = false;
            dgMateriaPorPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgMateriaPorPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dgMateriaPorPlan.DataSource = MatxPla.ConsultaMateriaPorPlanes(Convert.ToInt32(vId.Text)); 

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            AdmMatxPlan amp = new AdmMatxPlan(Convert.ToInt32(vId.Text));
            amp.Text = "Alta Materia Por Plan";
            amp.ShowDialog();

            //Actualizar el DataGrid
            dgMateriaPorPlan.DataSource = MatxPla.ConsultaMateriaPorPlanes(Convert.ToInt32(vId.Text)); 

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            //Editar

            AdmMatxPlan amp = new AdmMatxPlan(Convert.ToInt32(vId.Text), Convert.ToInt32(dgMateriaPorPlan.CurrentRow.Cells[0].Value.ToString()));
            amp.Text = "Editar Materia Por Plan";
            amp.ShowDialog();

            // Actualizar el DataGrid  
            dgMateriaPorPlan.DataSource = MatxPla.ConsultaMateriaPorPlanes(Convert.ToInt32(vId.Text)); 


        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            MatxPla.EliminarMateriaPorPlanes(Convert.ToInt32(dgMateriaPorPlan.CurrentRow.Cells[0].Value.ToString()));

            //Actualizar el DataGrid
            dgMateriaPorPlan.DataSource = MatxPla.ConsultaMateriaPorPlanes(Convert.ToInt32(vId.Text));

        }


    }
}
