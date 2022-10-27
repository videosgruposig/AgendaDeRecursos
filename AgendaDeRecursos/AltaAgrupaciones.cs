using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SesionBD;
using Dominio;


namespace AgendaDeRecursos
{
    public partial class AltaAgrupaciones : Form
        {

        EstructuraCurricular est = new EstructuraCurricular();
        Agrupaciones agru = new Agrupaciones();



        public AltaAgrupaciones()
        {
            InitializeComponent();
        }

   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void Agrupaciones_Load(object sender, EventArgs e)
        {

            // Seteo Del DataGrid
            dgEstructuraCurricular.RowHeadersVisible = false;
            dgEstructuraCurricular.AllowUserToAddRows = false;
            dgEstructuraCurricular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgEstructuraCurricular.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            this.nombre.Focus();

            dgEstructuraCurricular.DataSource = est.MostrarEstructuraCurricular();
            

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            
            agru.Nombre1 = nombre.Text;
            agru.Id_EstructuraCurricular1 = Convert.ToInt32(dgEstructuraCurricular.CurrentRow.Cells[0].Value.ToString());
            if (agru.Nombre1 != "")
                  if (agru.AgregarAgrupaciones(agru))
                           this.Close();
                   else
                           MessageBox.Show("Registro No Insertado");
            else
                MessageBox.Show("Ingrese un valor válido para Nombre");

            
        }

    }
}
