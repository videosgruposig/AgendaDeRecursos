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
    public partial class AdministradorInstancia : Form
    {
        InstanciaGrupo inst = new InstanciaGrupo();
        UnidadEducativa uni = new UnidadEducativa();


        public AdministradorInstancia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Seteo Del DataGrid
            
            dg.RowHeadersVisible = false;
            dg.AllowUserToAddRows = false;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            

            combo = uni.MostrarUnidadEducativa(combo, true);
            dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);
           
            
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar
            AdmInstancia Instancia = new AdmInstancia();
            Instancia.Text = "Alta Instancia";
            Instancia.ShowDialog();
            dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Editar

            AdmInstancia Instancia = new AdmInstancia(Convert.ToInt32(this.dg.CurrentRow.Cells[0].Value.ToString()));
            
            Instancia.Text = "Editar Instancia";
            Instancia.ShowDialog();
            dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inst.EliminarInstancia(Convert.ToInt32(dg.CurrentRow.Cells[0].Value.ToString()))==false)
                MessageBox.Show("No se puede eliminar: La instancia que intenta eliminar tiene datos vinculados");
            dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Cargos Vinculados



            inst.IdCursoSeccion         = Convert.ToInt32(this.dg.CurrentRow.Cells[0].Value);
            inst.UnidadEducativaNombre1 = this.dg.CurrentRow.Cells[1].Value.ToString();
            inst.PlanDeEstudioNombre1   = this.dg.CurrentRow.Cells[2].Value.ToString();
            inst.AgrupacionNombre1      = this.dg.CurrentRow.Cells[4].Value.ToString();
            inst.Curso1                 = this.dg.CurrentRow.Cells[5].Value.ToString();
            inst.Division1              = this.dg.CurrentRow.Cells[6].Value.ToString();
            inst.Turno1                 = this.dg.CurrentRow.Cells[7].Value.ToString();

            AdministradorCargosVinculados CargosVinculados = new AdministradorCargosVinculados(inst, true);
            CargosVinculados.ShowDialog();
            dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);
        }

        private void Agenda_Click(object sender, EventArgs e)
        {
            //Agenda

            inst.IdCursoSeccion = Convert.ToInt32(this.dg.CurrentRow.Cells[0].Value);
            inst.UnidadEducativaNombre1 = this.dg.CurrentRow.Cells[1].Value.ToString();
            inst.PlanDeEstudioNombre1 = this.dg.CurrentRow.Cells[2].Value.ToString();
            inst.AgrupacionNombre1 = this.dg.CurrentRow.Cells[4].Value.ToString();
            inst.Curso1 = this.dg.CurrentRow.Cells[5].Value.ToString();
            inst.Division1 = this.dg.CurrentRow.Cells[6].Value.ToString();
            inst.Turno1 = this.dg.CurrentRow.Cells[7].Value.ToString();

            AdmAgenda Agenda = new AdmAgenda(inst);
            Agenda.ShowDialog();
            dg.DataSource = inst.MostrarConsultaInstancias(combo.Text);

        }
        }
    }

