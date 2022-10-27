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
    public partial class AdmPlanEstudio : Form
    {
        PlanesEstudio pla = new PlanesEstudio();
    
        public AdmPlanEstudio()
        {
            InitializeComponent();
        }

        private void AdmPlanEstudio_Load(object sender, EventArgs e)
        {
            // Seteo Del DataGrid
            dgPlanEstudio.RowHeadersVisible = false;
            dgPlanEstudio.AllowUserToAddRows = false;
            dgPlanEstudio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgPlanEstudio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgPlanEstudio.DataSource = pla.MostrarPlanesEstudio();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Materias_Click(object sender, EventArgs e)
        {
            
            string Id, Agrup, Estr, Plan, Unid;

            Id = this.dgPlanEstudio.CurrentRow.Cells[0].Value.ToString();
            Agrup =  this.dgPlanEstudio.CurrentRow.Cells[1].Value.ToString();
            Estr = this.dgPlanEstudio.CurrentRow.Cells[2].Value.ToString();
            Plan = this.dgPlanEstudio.CurrentRow.Cells[3].Value.ToString();
            Unid = this.dgPlanEstudio.CurrentRow.Cells[4].Value.ToString();

            AdmMateriaPorPlan matxpla = new AdmMateriaPorPlan(Id, Agrup, Estr, Plan, Unid);


            



            matxpla.ShowDialog();
          //  dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);

        }
    }
}
