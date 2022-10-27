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
    public partial class AdmCargos : Form
    {
        CargosPorEstablecimiento Cargos = new CargosPorEstablecimiento();
        UnidadEducativa UnidadEducativa = new UnidadEducativa();
        NomencladorCargos NomencladorCargo = new NomencladorCargos();


        int IdCargo;

        public int IdCargo1
        {
            get { return IdCargo; }
            set { IdCargo = value; }
        }


        public AdmCargos()
        {
            InitializeComponent();
        }


        public AdmCargos(int Id)
        {
            InitializeComponent();
            IdCargo1 = Id;
        }


        private void AdmCargos_Load(object sender, EventArgs e)
        {

            // Inicializar Controles
            cbTurno.Items.Add("Mañana");
            cbTurno.Items.Add("Tarde");
            cbTurno.Items.Add("Vespertino");
            cbTurno.Items.Add("Noche");
            cbTurno.Items.Add("Otro");
            cbTurno.Text = "Mañana";

            // Cargar Combo
            cbUnidadEducativa = UnidadEducativa.MostrarUnidadEducativa(cbUnidadEducativa, false);
            cbNombreCargo = NomencladorCargo.MostrarCargos(cbNombreCargo);


            if (this.Text == "Editar Cargos")
            { //Actualizo las variables con los valores de la base

                    Cargos = Cargos.ObtenerCargosPorEstablecimiento(IdCargo);
                    NomencladorCargo = NomencladorCargo.CargarCargos("", Cargos.IdNomencladorCargosPOF);
                    UnidadEducativa = UnidadEducativa.CargarUnidadEducativa("", Cargos.IdUnidadEducativa);
                    cbNombreCargo.Text = NomencladorCargo.Descripcion1;
                    cbUnidadEducativa.Text = UnidadEducativa.Descripcion1;

                    IdCargo1 = Cargos.IdCargoPorEstablecimiento;
                    FechaCreacion.Value = Cargos.FechaCreacion1;
                    Año.Text = Cargos.Año1;
                    Division.Text = Cargos.Division1;
                    CantidadHoras.Text = Cargos.Horas.ToString();
                    cbTurno.Text = Cargos.Turno1;


   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Alta Cargos":
                    {// Actualizar Propiedades

                        //Cargar Variables
                        NomencladorCargo = NomencladorCargo.CargarCargos(cbNombreCargo.Text, 0);
                        UnidadEducativa = UnidadEducativa.CargarUnidadEducativa(cbUnidadEducativa.Text, 0);
                        Cargos.IdNomencladorCargosPOF = NomencladorCargo.IdCargo1;
                        Cargos.IdUnidadEducativa = UnidadEducativa.Id1;
                        Cargos.Observaciones1 = "";
                        Cargos.Año1 = Año.Text;
                        Cargos.Division1 = Division.Text;
                        Cargos.FechaCreacion1 = FechaCreacion.Value;
                        Cargos.Turno1 = cbTurno.Text;
                        Cargos.Horas = Convert.ToInt32(CantidadHoras.Text);
                      


                        //Verificar Valores Por defecto
                     //   if (inst.Curso1 != "" & inst.Division1 != "" & inst.Turno1 != "")
                            if (Cargos.AgregarCargosPorEstablecimiento(Cargos)) //Agregado de Registro
                                this.Close();
                            else
                                MessageBox.Show("Registro No Insertado");
                  //      else
                    //        MessageBox.Show("Completar Valores por Defecto");
                    

                        break;
                    }

                case "Editar Cargos":
                    {
                        // Actualizar Propiedades

                        Cargos.IdCargoPorEstablecimiento = IdCargo1;

                        NomencladorCargo = NomencladorCargo.CargarCargos(cbNombreCargo.Text, 0);
                        UnidadEducativa = UnidadEducativa.CargarUnidadEducativa(cbUnidadEducativa.Text, 0);
                        Cargos.IdNomencladorCargosPOF = NomencladorCargo.IdCargo1;
                        Cargos.IdUnidadEducativa = UnidadEducativa.Id1;
                        Cargos.Observaciones1 = "";
                        Cargos.Año1 = Año.Text;
                        Cargos.Division1 = Division.Text;
                        Cargos.FechaCreacion1 = FechaCreacion.Value;
                        Cargos.Turno1 = cbTurno.Text;
                        Cargos.Horas = Convert.ToInt32(CantidadHoras.Text);

                        //Verificar Valores Por defecto
                  //      if (inst.Curso1 != "" & inst.Division1 != "" & inst.Turno1 != "")
                            if (Cargos.ActualizarCargoPorEstablecimiento(Cargos)) //Agregado de Registro
                                this.Close();
                            else
                                MessageBox.Show("Registro No Insertado");
                  //      else
                   //         MessageBox.Show("Completar Valores por Defecto");                    
                   
                        break;
                    }

            }
        }
    }
}
