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
    public partial class AdmCargosVinculados : Form
    {

        CargoVinculado CargoVinculado = new CargoVinculado();
        MateriaAsociada MateriaAsociada = new MateriaAsociada();
        CargosPorEstablecimiento CargosPorEstablecimiento = new CargosPorEstablecimiento();
        Materia Materia = new Materia();
        NomencladorCargoPOF NomencladorCargoPOF = new NomencladorCargoPOF();

        int CursoSeccion, vIdCargoVinculado;
        string vUnidadEducativa;

        
        public AdmCargosVinculados(int Id, string rUnidadEducativa)
        {
            InitializeComponent();
            CursoSeccion = Id;
            vUnidadEducativa = rUnidadEducativa;
        }

        public AdmCargosVinculados(int Id, string rUnidadEducativa, int rIdCargoVinculado)
        {
            InitializeComponent();
            CursoSeccion = Id;
            vUnidadEducativa = rUnidadEducativa;
            vIdCargoVinculado = rIdCargoVinculado;

        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdmCargosVinculados_Load(object sender, EventArgs e)
        {
            // Cargar Combo
            cbMateria = MateriaAsociada.MostrarMateriaCargoVinculado(cbMateria, CursoSeccion);
            cbCargo = CargoVinculado.ObtenerCargoDistribucionPorCargo(cbCargo, vUnidadEducativa);

            // Cargar Variables
            CargosPorEstablecimiento = CargosPorEstablecimiento.CargarCargoPorEstablecimiento(CargosPorEstablecimiento.IdCargoPorEstablecimiento);
            vIdC.Text = CargosPorEstablecimiento.IdCargoPorEstablecimiento.ToString();
            vHoras.Text = CargosPorEstablecimiento.Horas.ToString();
            vAño.Text = CargosPorEstablecimiento.Año1;
            vDivisión.Text = CargosPorEstablecimiento.Division1;
            vTurno.Text = CargosPorEstablecimiento.Turno1;

            MateriaAsociada = MateriaAsociada.ConsultaDeMateriaAsociada(cbMateria.Text, CursoSeccion);
            vId.Text = MateriaAsociada.IdMateriaAsociada.ToString();
            vTiempoDeCursada.Text = MateriaAsociada.TiempoDeCursada1;
            vHoraRelojReal.Text = MateriaAsociada.HoraRelojReal1.ToString();




            if (this.Text == "Editar Vinculación") // //Actualizo las variables con los valores de la base
            {
                CargoVinculado = CargoVinculado.CargarCargoVinculado(vIdCargoVinculado);
                MateriaAsociada = MateriaAsociada.CargarMateriaAsociada(CargoVinculado.MateriaAsociada_idMateriaAsociada1);
                Materia = Materia.CargarMateria("", MateriaAsociada.Materias_idMaterias1);
                cbMateria.Text = Materia.Nombre1;
                vId.Text = MateriaAsociada.IdMateriaAsociada.ToString();
                vTiempoDeCursada.Text = MateriaAsociada.TiempoDeCursada1;
                vHoraRelojReal.Text = MateriaAsociada.HoraRelojReal1.ToString();

                CargosPorEstablecimiento = CargosPorEstablecimiento.CargarCargoPorEstablecimiento(CargoVinculado.CargoPorEstablecimiento_idCargoPorEstablecimiento1);
                NomencladorCargoPOF = NomencladorCargoPOF.CargarNomencladorCargoPOF("",CargosPorEstablecimiento.IdNomencladorCargosPOF);
                cbCargo.Text = NomencladorCargoPOF.DescripcionCargo;

                FechaVinculacion.Value = CargoVinculado.FechaVinculo1;

            }


        }

        private void cbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vId.Text != "")
            {

                MateriaAsociada = MateriaAsociada.ConsultaDeMateriaAsociada(cbMateria.Text, CursoSeccion);
                vId.Text = MateriaAsociada.IdMateriaAsociada.ToString();
                vTiempoDeCursada.Text = MateriaAsociada.TiempoDeCursada1;
                vHoraRelojReal.Text = MateriaAsociada.HoraRelojReal1.ToString();
            }
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vIdC.Text != "")
            {
                CargosPorEstablecimiento.IdCargoPorEstablecimiento = Convert.ToInt32(cbCargo.Text.Substring(0, cbCargo.Text.IndexOf('-') - 1));
               // MessageBox.Show("Indice de Cargo: "+CargosPorEstablecimiento.IdCargoPorEstablecimiento.ToString());

                CargosPorEstablecimiento = CargosPorEstablecimiento.CargarCargoPorEstablecimiento(CargosPorEstablecimiento.IdCargoPorEstablecimiento);

                vIdC.Text = CargosPorEstablecimiento.IdCargoPorEstablecimiento.ToString();
                vHoras.Text = CargosPorEstablecimiento.Horas.ToString();
                vAño.Text = CargosPorEstablecimiento.Año1;
                vDivisión.Text = CargosPorEstablecimiento.Division1;
                vTurno.Text = CargosPorEstablecimiento.Turno1;
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case ("Alta Vinculación"):
                    {
                        try
                        {
                            // Actualizar Propiedades
                            CargoVinculado.FechaVinculo1 = FechaVinculacion.Value;
                            CargoVinculado.CursoSeccion_idCursoSeccion1 = CursoSeccion;
                            CargoVinculado.CargoPorEstablecimiento_idCargoPorEstablecimiento1 = CargosPorEstablecimiento.IdCargoPorEstablecimiento;
                            CargoVinculado.MateriaAsociada_idMateriaAsociada1 = MateriaAsociada.IdMateriaAsociada;



                            if (CargoVinculado.AgregarCargoVinculado(CargoVinculado)) //Agregado de Registro
                                    this.Close();
                            else
                                    MessageBox.Show("Registro No Insertado");
           

                            break;
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                            break;
                        }
                    }


                case ("Editar Vinculación"):
                    {
                        try
                        {
                            // Actualizar Propiedades

                            CargoVinculado.FechaVinculo1 = FechaVinculacion.Value;
                            CargoVinculado.CursoSeccion_idCursoSeccion1 = CursoSeccion;
                            CargoVinculado.CargoPorEstablecimiento_idCargoPorEstablecimiento1 = Convert.ToInt32(vIdC.Text);
                            CargoVinculado.MateriaAsociada_idMateriaAsociada1 = Convert.ToInt32(vId.Text);


                            if (CargoVinculado.ActualizarDistribucionPorCargo(CargoVinculado) ) //Update de Registro
                                    this.Close();
                            else
                                    MessageBox.Show("Registro No Insertado");

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




    }
}
