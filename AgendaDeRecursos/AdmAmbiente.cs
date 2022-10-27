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
    public partial class AdmAmbiente : Form
    {
        Ambiente ambiente = new Ambiente();

        public AdmAmbiente()
        {
            InitializeComponent();
        }

        public AdmAmbiente(int Id)
        {
            InitializeComponent();
            ambiente.IdAmbiente = Id;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdmAmbiente_Load(object sender, EventArgs e)
        {

            // Inicializar Controles



            cbEstadoConservacion.Items.Add("Muy Bueno");
            cbEstadoConservacion.Items.Add("Bueno");
            cbEstadoConservacion.Items.Add("Regular");
            cbEstadoConservacion.Items.Add("Malo");

            cbTipoCubierta.Items.Add("Cubierta");
            cbTipoCubierta.Items.Add("Semi cubierta");
            cbTipoCubierta.Items.Add("Exterior");


            if (this.Text == "Editar Ambiente") // //Actualizo las variables con los valores de la base
            {
                ambiente = ambiente.CargarAmbiente(ambiente.IdAmbiente);

                vNombre.Text = ambiente.Nombre1;
                vSuperficie.Text = ambiente.Superficiemt21.ToString();
                cbTipoCubierta.Text = ambiente.TipoCubierta1;
                vObservaciones.Text = ambiente.Observaciones1;
                cbEstadoConservacion.Text = ambiente.EstadoConservacion1;
            
            }

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            switch (this.Text)
            {
                case "Alta Ambiente":
                    {
                        try
                        {
                            // Actualizar Propiedades
                            ambiente.Nombre1 = vNombre.Text;
                            ambiente.Superficiemt21 = Convert.ToInt32(vSuperficie.Text);
                            ambiente.EstadoConservacion1 = cbEstadoConservacion.Text;
                            ambiente.TipoCubierta1 = cbTipoCubierta.Text;
                            ambiente.Observaciones1 = vObservaciones.Text;




                            //Verificar Valores Por defecto
                            if (vNombre.Text != "")
                                if (ambiente.AgregarAmbiente(ambiente)) //Agregado de Registro
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


                case "Editar Ambiente":
                    {
                        try
                        {
                            // Actualizar Propiedades

                            ambiente.Nombre1 = vNombre.Text;
                            ambiente.Superficiemt21 = Convert.ToInt32(vSuperficie.Text);
                            ambiente.EstadoConservacion1 = cbEstadoConservacion.Text;
                            ambiente.TipoCubierta1 = cbTipoCubierta.Text;
                            ambiente.Observaciones1 = vObservaciones.Text;



                            //Verificar Valores Por defecto

                            if (vNombre.Text != "")
                                if (ambiente.ActualizarAmbiente(ambiente)) //Actualizar de Registro
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
    }
}
