using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaDeRecursos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void administradorCursoSecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administracionCursoSeccónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarCursoSeccion ACurSec = new AdministrarCursoSeccion();
            ACurSec.MdiParent = this;
            ACurSec.Show();
        }

        private void administradorAgrupacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AltaAgrupaciones AAgrup = new AltaAgrupaciones();
            AAgrup.MdiParent = this;
            AAgrup.Show();
        }

        private void administradorDeInstanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorInstancia AInst = new AdministradorInstancia();
            AInst.MdiParent = this;
            AInst.Show();
        }

        private void administradorPlanesDeEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmPlanEstudio APla = new AdmPlanEstudio();
            APla.MdiParent = this;
            APla.Show();
        }

        private void administradorDeCargosPorEstablecimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorCargos ACargos = new AdministradorCargos();
            ACargos.MdiParent = this;
            ACargos.Show();

        }

        private void AdministradorAmbientes_Click(object sender, EventArgs e)
        {
            AdministradorDeAmbientes AAmbientes = new AdministradorDeAmbientes(true);
            AAmbientes.MdiParent = this;
            AAmbientes.Show();
        }
    }
}
