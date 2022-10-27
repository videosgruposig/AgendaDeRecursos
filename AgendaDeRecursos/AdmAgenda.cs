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
    public partial class AdmAgenda : Form
    {

        List<CalendarItem> _items = new List<CalendarItem>();
        AgendaAmbiente AgendaAmbiente = new AgendaAmbiente();
        CalendarItem aux;
        ToolTip ToolTip1 = new ToolTip();
        InstanciaGrupo InstanciaGrupo = new InstanciaGrupo();
        Ambiente Ambiente = new Ambiente();

        public AdmAgenda(InstanciaGrupo rInstanciaGrupo)
        {
            InitializeComponent();
            dtVigenciaDesde.Value = AgendaAmbiente.ObtenerPrimerLunes(DateTime.Today);
            Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.ThirtyMinutes;
            trackBar1.Value = 4;
            Agenda.SetViewRange(dtVigenciaDesde.Value, dtVigenciaDesde.Value.AddDays(6));


            InstanciaGrupo = rInstanciaGrupo;
            vId.Text = rInstanciaGrupo.IdCursoSeccion.ToString();
            vUnidadEducativa.Text = rInstanciaGrupo.UnidadEducativaNombre1;
            vPlanEstudios.Text = rInstanciaGrupo.PlanDeEstudioNombre1;
            vGrupo.Text = rInstanciaGrupo.AgrupacionNombre1;
            vCurso.Text = rInstanciaGrupo.Curso1;
            vCursoDivision.Text = rInstanciaGrupo.Division1;
            vTurno.Text = rInstanciaGrupo.Turno1;

        }

        private void AdmAgenda_Load(object sender, EventArgs e)
        {
            // Reemplazar este grupo de código con la información de la BD
            aux = new CalendarItem(Agenda, dtVigenciaDesde.Value.AddHours(5), dtVigenciaDesde.Value.AddHours(9), "CargarTodo lo que tiene la lista");
            Agenda.Items.Add(aux);
            _items.Add(aux);
            // Fin código para cargar de la BD los registros de items.

            vTotalAgenda.Text = Agenda.Items.Count.ToString();
            vTotalLista.Text = _items.Count.ToString();
            
            
            
            ToolTip1.AutomaticDelay = 1000;
            ToolTip1.InitialDelay = 1000;
            ToolTip1.ReshowDelay = 500;
            //ToolTip1.ShowAlways = true;

            

        }

        private void vScroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case (1):
                    Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixtyMinutes;
                    break;

                case (2):
                    Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.ThirtyMinutes;
                    break;

                case (3):
                     Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.FifteenMinutes;
                     break;

                case (4):
                     Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.TenMinutes;
                     break;

                case (5):
                     Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.SixMinutes;
                     break;

                case (6):
                     Agenda.TimeScale = System.Windows.Forms.Calendar.CalendarTimeScale.FiveMinutes;
                     break;

            }


        }

        private void itemdobleclick(object sender, CalendarItemEventArgs e) // Carga de nuevos items 
        {
            AdmCargarItem CargarItem; // Declaración del form para cargar variables del item

            aux = e.Item;
            Agenda.Items.Remove(e.Item);

            if (e.Item.Text == "")   // Se crea un nuevo item
            {
                AgendaAmbiente.FechaDesde1 = e.Item.StartDate;
                AgendaAmbiente.FechaHasta1 = e.Item.EndDate;
                CargarItem = new AdmCargarItem(AgendaAmbiente, InstanciaGrupo, Ambiente);
                CargarItem.ShowDialog();
                aux.Text = AgendaAmbiente.GetTextoItem(CargarItem.Tarea, CargarItem.Sala, CargarItem.AgendaAmbiente.FechaDesde1, CargarItem.AgendaAmbiente.FechaHasta1);
                aux.StartDate = CargarItem.AgendaAmbiente.FechaDesde1;
                aux.EndDate = CargarItem.AgendaAmbiente.FechaHasta1;
                
            }
            else    // Se modifica un item existente
            {
                CargarItem = new AdmCargarItem(e.Item, InstanciaGrupo);
                CargarItem.ShowDialog();
                EliminarItems(aux);
                CargarItem.BotonCerrar = false;
                aux.Text = AgendaAmbiente.GetTextoItem(CargarItem.Tarea, CargarItem.Sala, CargarItem.AgendaAmbiente.FechaDesde1, CargarItem.AgendaAmbiente.FechaHasta1);
                aux.StartDate = CargarItem.AgendaAmbiente.FechaDesde1;
                aux.EndDate = CargarItem.AgendaAmbiente.FechaHasta1;
                _items.Add(aux); 
            }




            if ((AgendaAmbiente.InterseccionAgendas(Agenda, e.Item)) || (CargarItem.BotonCerrar))
            {
                Agenda.Items.Add(aux);
                if (!CargarItem.BotonCerrar)
                {
                    MessageBox.Show("Horario Superpuesto: El horario deseado se superpone con otro. Verifique y vuelva a crear uno nuevo");
                }
                Agenda.Items.Remove(aux);
                _items.RemoveAt(_items.Count - 1);
            }
            else
            {

                Agenda.Items.Add(aux);  // Si no hay intersección de items, entonces lo crea como nuevo.
                while (aux.EndDate < dtVigenciaHasta.Value)
                {
                    aux = new CalendarItem(Agenda, aux.StartDate, aux.EndDate, aux.Text);
                    aux.StartDate = aux.StartDate.AddDays(7);
                    aux.EndDate = aux.EndDate.AddDays(7);

                    Agenda.Items.Add(aux);
                    _items.Add(aux);


                } 
            }
            
            vTotalAgenda.Text = Agenda.Items.Count.ToString();
            vTotalLista.Text = _items.Count.ToString();

        }

        private void Agenda_ItemDatesChanged(object sender, CalendarItemEventArgs e) // Modificación de item existente
        {
            string xtarea, xsala;

            aux = e.Item;
            Agenda.Items.Remove(e.Item);
            //Antes de eliminar, se puede obtener el _item.Text, hora inicio y fin real del modificado y guardar en un auxiliar
            EliminarItems(aux); 

            xtarea = AgendaAmbiente.GetTareaItem(aux);
            xsala = AgendaAmbiente.GetSalaItem(aux);
            aux.Text = AgendaAmbiente.GetTextoItem(xtarea, xsala, aux.StartDate, aux.EndDate);

            if (AgendaAmbiente.InterseccionAgendas(Agenda, e.Item))
            {
                Agenda.Items.Add(aux);
                //Aqui se puede preguntar si desea continuar o cancelar y si cancela, se mantiene el item con el valor capturado antes de eliminar (línea 154)
                MessageBox.Show("Horario Superpuesto: El horario deseado se superpone con otro. Verifique y vuelva a crear otro");
                Agenda.Items.Remove(aux);
            }
            else
            {
                _items.Add(aux);
                Agenda.Items.Add(aux);   //Actualiza el valor de los items
                while (aux.EndDate < dtVigenciaHasta.Value)
                {
                    aux = new CalendarItem(Agenda, aux.StartDate, aux.EndDate, aux.Text);
                    aux.StartDate = aux.StartDate.AddDays(7);
                    aux.EndDate = aux.EndDate.AddDays(7);

                    Agenda.Items.Add(aux);
                    _items.Add(aux);
                 
                }
            }

            vTotalAgenda.Text = Agenda.Items.Count.ToString();
            vTotalLista.Text = _items.Count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }

        private void Agenda_LoadItems(object sender, CalendarLoadEventArgs e)
        {

            PlaceItems();
        }

        private void PlaceItems()
        {
            foreach (CalendarItem item in _items)
            {
            //    if (Agenda.ViewIntersects(item))
             //   {
                    Agenda.Items.Add(item);
              //  }
            }

        }

        private void EliminarItems(CalendarItem rItem)
        {
            EstructuraItem ItemPivot, ItemIteracion;
            ItemPivot = new EstructuraItem();
            ItemIteracion = new EstructuraItem();

            ItemPivot.Texto1 = rItem.Text;
            ItemPivot.FechaInicio1 = rItem.StartDate;
            ItemPivot.FechaFin1 = rItem.EndDate;
            ItemPivot.DiaDeSemana1 = rItem.Date.DayOfWeek.ToString();

            foreach (CalendarItem item in _items)
            {
                ItemIteracion.Texto1 = item.Text;
                ItemIteracion.FechaInicio1 = item.StartDate;
                ItemIteracion.FechaFin1 = item.EndDate;
                ItemIteracion.DiaDeSemana1 = item.Date.DayOfWeek.ToString();

                if (ItemPivot.CompararIgualdadEstructura(ItemIteracion))
                    Agenda.Items.Remove(item);
               
                
            }

            for (int i = _items.Count - 1; i >= 0; i--)
                {

                    ItemIteracion.Texto1 = _items[i].Text;
                    ItemIteracion.FechaInicio1 = _items[i].StartDate;
                    ItemIteracion.FechaFin1 = _items[i].EndDate;
                    ItemIteracion.DiaDeSemana1 = _items[i].Date.DayOfWeek.ToString();

                    if (ItemPivot.CompararIgualdadEstructura(ItemIteracion))
                        _items.RemoveAt(i);

                }

      
        }

        private void Agenda_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {

            _items.Add(e.Item);
        }

        private void dtVigenciaDesde_ValueChanged(object sender, EventArgs e)
        {
            dtVigenciaDesde.Value = AgendaAmbiente.ObtenerPrimerLunes(dtVigenciaDesde.Value);
            Agenda.SetViewRange(dtVigenciaDesde.Value, dtVigenciaDesde.Value.AddDays(6));
            dtVigenciaHasta.Value = dtVigenciaDesde.Value.AddMonths(8);
            dtVigenciaHasta.Value = AgendaAmbiente.ObtenerDomingo(dtVigenciaHasta.Value);
            vTotalAgenda.Text = Agenda.Items.Count.ToString();
            vTotalLista.Text = _items.Count.ToString();

        }

        private void dtVigenciaHasta_ValueChanged(object sender, EventArgs e)
        {
            dtVigenciaHasta.Value = AgendaAmbiente.ObtenerDomingo(dtVigenciaHasta.Value);
        }

        private void Agenda_ItemDeleted(object sender, CalendarItemEventArgs e)
        {
            EliminarItems(e.Item);
            vTotalAgenda.Text = Agenda.Items.Count.ToString();
            vTotalLista.Text = _items.Count.ToString();
        }

        private void Agenda_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Calendar.CalendarItem i = Agenda.ItemAt(Agenda.PointToClient(Cursor.Position));
            if (i == null)
            {
                ToolTip1.Active = false;
                ToolTip1.Hide(this);
            }
            else
                if (ToolTip1.Active == false)
                {

                    ToolTip1.Active = true;
                    ToolTip1.SetToolTip(this.Agenda, i.Text);

                }

        }

        private void btListaAmbientes_Click(object sender, EventArgs e)
        {
            //Llama al AdministradorCargosVinculados


            AdministradorDeAmbientes AdministradorDeAmbientes = new AdministradorDeAmbientes(false);
            AdministradorDeAmbientes.ShowDialog();
            Ambiente.Nombre1    = AdministradorDeAmbientes.AmbienteSeleccionadoNombre;
            Ambiente.IdAmbiente = AdministradorDeAmbientes.AmbienteSeleccionadoId;
            vAmbiente.Text = Ambiente.Nombre1;

        }





        
 
     

    }
}
