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
    public partial class AdmMatxPlan : Form
    {
        //Propiedades
        MateriaPorPlanes MatxPla = new MateriaPorPlanes();
        Materia Materia = new Materia();
        
        int IdAgrupacion, IdMateriaxPlanes;


        //Metodos
        public int IdMatxPlan1
        {
            get { return IdAgrupacion; }
            set { IdAgrupacion = value; }
        }

        public AdmMatxPlan(int IdA)
        {
            InitializeComponent();
            IdAgrupacion = IdA;

        }

        public AdmMatxPlan(int IdA, int IdM)
        {
            InitializeComponent();
            IdAgrupacion = IdA;
            IdMateriaxPlanes = IdM;



        }

 

        private void AdmMatxPlan_Load(object sender, EventArgs e)
        {

            // Inicializar Controles
            Cursada.Items.Add("Trimestral");
            Cursada.Items.Add("Cuatrimestral");
            Cursada.Items.Add("Anual");


         
            // Cargar Combo

            cbmaterias = Materia.MostrarMaterias(cbmaterias);

            
             // Cargar Variables
             Materia = Materia.CargarMateria(cbmaterias.Text, 0);       
             vIdMateria.Text = Materia.IdMaterias.ToString();
             vCiclo.Text = Materia.Ciclo1;
             vNucleoDisciplinaAfin.Text = Materia.NucleoDisciplinaAfin1;
             vHsRelojSugeridas.Text = Materia.CargaHorariaSugeridaHsReloj1;
            


            if (this.Text == "Editar Materia Por Plan") // //Actualizo las variables con los valores de la base
            {
                MatxPla = MatxPla.ObtenerMateriaPorPlanes(IdMateriaxPlanes);
                Materia = Materia.CargarMateria("", MatxPla.Materias_idMaterias1);



                cbmaterias.Text = Materia.Nombre1;
                HoraReloj.Text = Convert.ToString(MatxPla.HoraRelojReal1);
                Cursada.Text = MatxPla.TiempoDeCursada1;

            }

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
          switch (this.Text)
            {
                case "Alta Materia Por Plan":
                    {
                        try
                        {
                            // Actualizar Propiedades
                            MatxPla.HoraRelojReal1 = Convert.ToInt32(HoraReloj.Text);
                            MatxPla.TiempoDeCursada1 = Cursada.Text;
                            MatxPla.Agrupaciones_idAgrupaciones1 = IdAgrupacion;
                            MatxPla.Materias_idMaterias1 = Convert.ToInt32(vIdMateria.Text);


                            //Verificar Valores Por defecto
                            if (HoraReloj.Text != null & MatxPla.TiempoDeCursada1 != "")
                                if (MatxPla.AgregarMateriaPorPlan(MatxPla)) //Agregado de Registro
                                    this.Close();
                                else
                                    MessageBox.Show("Registro No Insertado");
                            else
                                MessageBox.Show("Completar Valores por Defecto");

                            break;
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Se requiere valor entero");
                            break;
                        }
                    }


                case "Editar Materia Por Plan":
                    {
                        try
                        {
                            // Actualizar Propiedades
                            MatxPla.IdMateriaAsociada = IdMateriaxPlanes;
                            MatxPla.HoraRelojReal1 = Convert.ToInt32(HoraReloj.Text);
                            MatxPla.TiempoDeCursada1 = Cursada.Text;
                            MatxPla.Agrupaciones_idAgrupaciones1 = IdAgrupacion;
                            MatxPla.Materias_idMaterias1 = Convert.ToInt32(vIdMateria.Text);


                            //Verificar Valores Por defecto
                            if (HoraReloj.Text != null & MatxPla.TiempoDeCursada1 != "")
                                if (MatxPla.ActualizarMateriaPorPlanes(MatxPla)) //Actualizar Registro
                                    this.Close();
                                else
                                    MessageBox.Show("Registro No Insertado");
                            else
                                MessageBox.Show("Completar Valores por Defecto");

                            break;
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            break;
                        }
                    }

        } 

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vIdMateria.Text != "")
            {
                Materia = Materia.CargarMateria(cbmaterias.Text, 0);
                vIdMateria.Text = Materia.IdMaterias.ToString();
                vCiclo.Text = Materia.Ciclo1;
                vNucleoDisciplinaAfin.Text = Materia.NucleoDisciplinaAfin1;
                vHsRelojSugeridas.Text = Materia.CargaHorariaSugeridaHsReloj1;
            }

        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



       
    }
}
