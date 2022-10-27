using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using Dominio;

namespace AgendaDeRecursos
{
    public partial class AdmCargarItem : Form
    {

        public string Tarea, Sala;
        public AgendaAmbiente AgendaAmbiente = new AgendaAmbiente();
        MateriaPorPlanes MateriaPorPlanes = new MateriaPorPlanes();
        InstanciaGrupo InstanciaGrupo = new InstanciaGrupo();
        Ambiente Ambiente = new Ambiente();
        public bool BotonCerrar = false;

      



        public AdmCargarItem(AgendaAmbiente rAgendaAmbiente, InstanciaGrupo rInstanciaGrupo, Ambiente rAmbiente)  // Alta
        {
            
            InitializeComponent();
            AgendaAmbiente.FechaDesde1 = rAgendaAmbiente.FechaDesde1;
            AgendaAmbiente.FechaHasta1 = rAgendaAmbiente.FechaHasta1;
            InstanciaGrupo = rInstanciaGrupo;
            Ambiente = rAmbiente;

            vHoraInicio.Text = AgendaAmbiente.FechaDesde1.TimeOfDay.ToString();
            vHoraFin.Text = AgendaAmbiente.FechaHasta1.TimeOfDay.ToString();
            vAmbiente.Text = Ambiente.Nombre1;


     
  
        }

        public AdmCargarItem(CalendarItem ritem, InstanciaGrupo rInstanciaGrupo) // Modificación
        {
            InitializeComponent();
            InstanciaGrupo = rInstanciaGrupo;


            vHoraInicio.Text = ritem.StartDate.TimeOfDay.ToString();
            vHoraFin.Text = ritem.EndDate.TimeOfDay.ToString();
            AgendaAmbiente.FechaDesde1 = ritem.StartDate;
            AgendaAmbiente.FechaHasta1 = ritem.EndDate;
            vMateria.Text = AgendaAmbiente.GetTareaItem(ritem);
            vAmbiente.Text = AgendaAmbiente.GetSalaItem(ritem);
            

        }





        private void vHoraFin_Validated(object sender, EventArgs e)
        {
            try
            {
                AgendaAmbiente.FechaHasta1 = AgendaAmbiente.FechaHasta1.Date + Convert.ToDateTime(vHoraFin.Text).TimeOfDay;
            }


            catch (FormatException)
            {
                MessageBox.Show("Formato de hora incorrecto: Verifique y vuelva a ingresarlo");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void vHoraInicio_Validated(object sender, EventArgs e)
        {
            try
            {
                AgendaAmbiente.FechaDesde1 = AgendaAmbiente.FechaDesde1.Date + Convert.ToDateTime(vHoraInicio.Text).TimeOfDay;
            }


            catch (FormatException)
            {
                MessageBox.Show("Formato de hora incorrecto: Verifique y vuelva a ingresarlo");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void AdmCargarItem_Load(object sender, EventArgs e)
        {

        }

        private void btListaMaterias_Click(object sender, EventArgs e)
        {

            //Llama al AdministradorCargosVinculados


            AdministradorCargosVinculados CargosVinculados = new AdministradorCargosVinculados(InstanciaGrupo, false);
            CargosVinculados.ShowDialog();
            vMateria.Text = CargosVinculados.MateriaSeleccionada;           
            
        }

        private void btListaAmbientes_Click(object sender, EventArgs e)
        {

            //Llama al AdministradorCargosVinculados

            
            AdministradorDeAmbientes AdministradorDeAmbientes = new AdministradorDeAmbientes(false);
            AdministradorDeAmbientes.ShowDialog();
            vAmbiente.Text = AdministradorDeAmbientes.AmbienteSeleccionadoNombre;

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            
            Tarea = vMateria.Text;
            Sala = vAmbiente.Text;


            if (vMateria.Text != "" && vAmbiente.Text != "")
            {
                BotonCerrar = true;
                this.Close();
            }
            else
                MessageBox.Show("Por favor seleccione Materia y Ambiente");

        }




        protected override void OnClosed(EventArgs e)
        {
            Tarea = vMateria.Text;
            Sala = vAmbiente.Text;
            if (BotonCerrar)
                BotonCerrar = false;
            else
                BotonCerrar = true;
            this.Close();
 
        }


    }
}
