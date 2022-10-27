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
    public partial class AdmInstancia : Form 
    {
        Agrupaciones agru = new Agrupaciones();
        InstanciaGrupo inst = new InstanciaGrupo();
        int IdInstancia;


        public AdmInstancia() 
        {
            InitializeComponent();
        }

        public AdmInstancia(int Id)
        {
            InitializeComponent();
            IdInstancia1 = Id;
            
        }

        public int IdInstancia1
        {
            get { return IdInstancia; }
            set { IdInstancia = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } //Salir

        private void AltaInstancia_Load(object sender, EventArgs e)
        {
            // Seteo Del DataGrid
            dgAgrupamiento.RowHeadersVisible = false;
            dgAgrupamiento.AllowUserToAddRows = false;
            dgAgrupamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgAgrupamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Inicializar Controles
            Turno.Items.Add("Mañana");
            Turno.Items.Add("Tarde");
            Turno.Items.Add("Vespertino");
            Turno.Items.Add("Noche");
            Turno.Items.Add("Otro");

            TipoInstrumentoLegal.Items.Add("Ley");
            TipoInstrumentoLegal.Items.Add("Decreto");
            TipoInstrumentoLegal.Items.Add("Resolución");
            TipoInstrumentoLegal.Items.Add("Otro");

            MotivoCreacion.Items.Add("N/A");

            dgAgrupamiento.DataSource = agru.MostrarAgrupaciones();


           if (this.Text == "Editar Instancia")

                    { //Actualizo las variables con los valores de la base
                        inst = inst.ObtenerInstancia(IdInstancia1);


                        IdInstancia1 = inst.IdCursoSeccion;
                        AliasCurso.Text = inst.AliasCurso1;
                        AliasDivision.Text = inst.AliasDivision1;
                        Curso.Text = inst.Curso1;
                        Division.Text = inst.Division1;
                        InstrumentoLegal.Text = inst.InstrumentoLegal1;
                        Matricula.Text = inst.Matricula1;
                        MotivoCreacion.Text = inst.MotivoCreacion1;
                        Turno.ValueMember = inst.Turno1;
                        Turno.DisplayMember = inst.Turno1;
                        Turno.Text = inst.Turno1;
                        Observaciones.Text = inst.Observaciones1;
                        TipoInstrumentoLegal.Text = inst.TipoInstrumentoLegal1;
                        FechaCreacion.Value = inst.FechaCreacion;


                        //DataGridView
                        dgAgrupamiento.DataSource = agru.MostrarAgrupaciones();
                        int i = inst.ObtnerIdAgrupamiento(dgAgrupamiento, inst.Agrupaciones_idAgrupacio1);
                        dgAgrupamiento.Rows[0].Selected = false;
                        dgAgrupamiento.Rows[i].Selected = true; //Selecciona la fila en función del Id de la Grilla
                        dgAgrupamiento.CurrentCell = this.dgAgrupamiento[0, i]; //Apunta el puntero de la Grilla al Id seleccionado.
                    }
        }
    


        

        private void button2_Click(object sender, EventArgs e) //Botón Aceptar
        {
            switch (this.Text)
            {
                case "Alta Instancia":
                    {// Actualizar Propiedades
                        inst.AliasCurso1 = AliasCurso.Text;
                        inst.AliasDivision1 = AliasDivision.Text;
                        inst.Curso1 = Curso.Text;
                        inst.Division1 = Division.Text;
                        inst.InstrumentoLegal1 = InstrumentoLegal.Text;
                        inst.Matricula1 = Matricula.Text;
                        inst.MotivoCreacion1 = MotivoCreacion.Text;
                        inst.Turno1 = Turno.Text;
                        inst.Observaciones1 = Observaciones.Text;
                        inst.TipoInstrumentoLegal1 = TipoInstrumentoLegal.Text;
                        inst.Agrupaciones_idAgrupacio1 = Convert.ToInt32(dgAgrupamiento.CurrentRow.Cells[0].Value.ToString());
                        inst.FechaCreacion = FechaCreacion.Value;


                        //Verificar Valores Por defecto
                        if (inst.Curso1 != "" & inst.Division1 != "" & inst.Turno1!="")
                            if (inst.AgregarInstancia(inst)) //Agregado de Registro
                                this.Close();
                            else
                                MessageBox.Show("Registro No Insertado");
                        else
                            MessageBox.Show("Completar Valores por Defecto");

                        break;
                    }

                case "Editar Instancia":
                    {
                            // Actualizar Propiedades
                            inst.IdCursoSeccion = IdInstancia;
                            inst.AliasCurso1 = AliasCurso.Text;
                            inst.AliasDivision1 = AliasDivision.Text;
                            inst.Curso1 = Curso.Text;
                            inst.Division1 = Division.Text;
                            inst.InstrumentoLegal1 = InstrumentoLegal.Text;
                            inst.Matricula1 = Matricula.Text;
                            inst.MotivoCreacion1 = MotivoCreacion.Text;
                            inst.Turno1 = Turno.Text;
                            inst.Observaciones1 = Observaciones.Text;
                            inst.TipoInstrumentoLegal1 = TipoInstrumentoLegal.Text;
                            inst.Agrupaciones_idAgrupacio1 = Convert.ToInt32(dgAgrupamiento.CurrentRow.Cells[0].Value.ToString());
                            inst.FechaCreacion = FechaCreacion.Value;

                            //Verificar Valores Por defecto
                            if (inst.Curso1 != "" & inst.Division1 != "" & inst.Turno1 != "")
                                if (inst.ActualizarInstancia(inst)) //Agregado de Registro
                                    this.Close();
                                else
                                    MessageBox.Show("Registro No Insertado");
                            else
                                MessageBox.Show("Completar Valores por Defecto");
                        }

                        

                        dgAgrupamiento.Rows[0].Selected = false;
                        dgAgrupamiento.Rows[inst.ObtnerIdAgrupamiento(dgAgrupamiento, inst.Agrupaciones_idAgrupacio1)].Selected = true;

                        

                        
                        break;
                        }
             

            }

            
        }

        
    }

