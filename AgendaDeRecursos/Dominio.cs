using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SesionBD;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;


namespace Dominio
{

    public class Ambiente 
    {

        Conexion ConexionDB = new Conexion();

        int idAmbiente, Superficiemt2;

        string EstadoConservacion, Observaciones, TipoCubierta, Nombre;


        public int Superficiemt21
        {
            get { return Superficiemt2; }
            set { Superficiemt2 = value; }
        }

        public int IdAmbiente
        {
            get { return idAmbiente; }
            set { idAmbiente = value; }
        }

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string TipoCubierta1
        {
            get { return TipoCubierta; }
            set { TipoCubierta = value; }
        }

        public string Observaciones1
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }

        public string EstadoConservacion1
        {
            get { return EstadoConservacion; }
            set { EstadoConservacion = value; }
        }


        public DataTable MostrarAmbiente(int ridAmbiente, string rNombre)
        {
            try
            {
                
                ConexionDB.Comando.CommandText = "call CargarAmbiente('" + ridAmbiente + "', '" + rNombre + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


        public Ambiente CargarAmbiente(int ridAmbiente)
        {
            try
            {
                Ambiente variable = new Ambiente();


                ConexionDB.Comando.CommandText = "call CargarAmbiente('" + ridAmbiente + "', '" + "" + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
           
               // DataTable tabla = new DataTable();
               // ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {

                    variable.IdAmbiente = Convert.ToInt32(ConexionDB.LectorDatos["Id"].ToString());
                    variable.Nombre1 = ConexionDB.LectorDatos["Nombre"].ToString();
                    variable.EstadoConservacion1 = ConexionDB.LectorDatos["EstadoConservacion"].ToString();
                    variable.Superficiemt21 = Convert.ToInt32(ConexionDB.LectorDatos["Superficiemt2"].ToString());
                    variable.TipoCubierta1 = ConexionDB.LectorDatos["TipoCubierta"].ToString();
                    variable.Observaciones1= ConexionDB.LectorDatos["Observaciones"].ToString();

                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

        public bool AgregarAmbiente(Ambiente Ambiente)
        {
            try
            {

                bool ejecucion = false;


                ConexionDB.Comando.CommandText = "call InsertarAmbiente('" + Ambiente.EstadoConservacion1 + "', '" + Ambiente.Observaciones1 + "', '" + Ambiente.Superficiemt21 + "', '" + Ambiente.TipoCubierta1 + "', '" + Ambiente.Nombre1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool ActualizarAmbiente(Ambiente rAmbiente)
        {
            try
            {
                bool ejecucion = false;


                ConexionDB.Comando.CommandText = "call ActualizarAmbiente('" + rAmbiente.IdAmbiente + "', '" + rAmbiente.EstadoConservacion1 + "', '" + rAmbiente.Observaciones1 + "', '" + rAmbiente.Superficiemt21 + "', '" + rAmbiente.TipoCubierta1 + "', '" + rAmbiente.Nombre1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool EliminarAmbiente(int Id)
        {
            try
            {


                bool ejecucion = false;

                ConexionDB.Comando.CommandText = "call EliminarAmbiente('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


    }

    public class NomencladorCargos
    {
        Conexion ConexionDB = new Conexion();

        int IdCargo;
        string Descripcion;


        public int IdCargo1
        {
            get { return IdCargo; }
            set { IdCargo = value; }
        }

        public string Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public NomencladorCargos CargarCargos(string Nombre, int Id)
        {
            try
            {
                NomencladorCargos variable = new NomencladorCargos();

                ConexionDB.Comando.CommandText = "select * from nomencladorcargospof where Descripcion like '" + Nombre + "' or  idNomencladorCargosPOF = '" + Id + "'";

                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {
                    variable.IdCargo1 = Convert.ToInt32(ConexionDB.LectorDatos["idNomencladorCargosPOF"].ToString());
                    variable.Descripcion1 = ConexionDB.LectorDatos["Descripcion"].ToString();
                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

        public ComboBox MostrarCargos(ComboBox combo)
        {

            try
            {
                ConexionDB.Comando.CommandText = "SELECT * FROM nomencladorcargospof";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                    combo.Items.Add(ConexionDB.LectorDatos["Descripcion"].ToString());
                combo.SelectedIndex = 0;
                return combo;
            }


            catch (Exception ex)
            {
                MessageBox.Show("mostrar: " + ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }

        }

    }

    public class NomencladorCargoPOF : NomencladorCargos 
    {
        Conexion ConexionDB = new Conexion();

        int idNomencladorCargosPOF;
        string Descripcion;

        public int IdNomencladorCargosPOF
        {
            get { return idNomencladorCargosPOF; }
            set { idNomencladorCargosPOF = value; }
        }

        public string  DescripcionCargo 
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }

        public NomencladorCargoPOF CargarNomencladorCargoPOF(string rDescripcion, int ridNomencladorCargosPOF)
        {
            try
            {
                NomencladorCargoPOF variable = new NomencladorCargoPOF();
                

                ConexionDB.Comando.CommandText = "call CargarNomencladorCargoPOF('" + ridNomencladorCargosPOF + "', '" + rDescripcion + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {
                    variable.idNomencladorCargosPOF = Convert.ToInt32(ConexionDB.LectorDatos["idNomencladorCargosPOF"].ToString());
                    variable.DescripcionCargo           = ConexionDB.LectorDatos["Descripcion"].ToString();

                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

        public ComboBox MostrarMaterias(ComboBox combo)
        {

            try
            {



                ConexionDB.Comando.CommandText = "SELECT * FROM educacion.materias";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                    combo.Items.Add(ConexionDB.LectorDatos["Nombre"].ToString());
                combo.SelectedIndex = 0;
                return combo;
            }


            catch (Exception ex)
            {
                MessageBox.Show("mostrar: " + ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }

        }

    }

    public class Agrupaciones
    {
        int Id, Id_EstructuraCurricular;
        string Nombre;
        Conexion ConexionDB = new Conexion();


        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }

        public int Id_EstructuraCurricular1
        {
            get { return Id_EstructuraCurricular; }
            set { Id_EstructuraCurricular = value; }
        }

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public bool AgregarAgrupaciones(Agrupaciones agrupacion)
        {
            try
            {

                bool ejecucion = false;
                ConexionDB.Comando.CommandText = "call InsertarAgrupaciones('" + agrupacion.Nombre1 + "', '" + agrupacion.Id_EstructuraCurricular1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public DataTable MostrarAgrupaciones()
        {
            try
            {

                ConexionDB.Comando.CommandText = "call ConsultaAgrupacion()";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

    }

    public class EstructuraCurricular
    {

        Conexion ConexionBD = new Conexion();

        public DataTable MostrarEstructuraCurricular()
        {
            try
            {
                ConexionBD.Comando.CommandText = "call ConsultaEstructuraCurricular()";
                ConexionBD.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionBD.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionBD.Conector != null)
                {
                    ConexionBD.Conector.Close();
                }
            }
        }

    }

    public class InstanciaGrupo
    {

        Conexion ConexionDB = new Conexion();

        int idCursoSeccion, Agrupaciones_idAgrupacio;
        public DateTime FechaCreacion = new DateTime();
        string Matricula, AliasCurso, AliasDivision, Curso, Division, MotivoCreacion, Observaciones, TipoInstrumentoLegal, Turno, InstrumentoLegal;
        string UnidadEducativaNombre, PlanDeEstudioNombre, EstructuraCurricularNombre, AgrupacionNombre;

        public string AgrupacionNombre1
        {
            get { return AgrupacionNombre; }
            set { AgrupacionNombre = value; }
        }

        public string EstructuraCurricularNombre1
        {
            get { return EstructuraCurricularNombre; }
            set { EstructuraCurricularNombre = value; }
        }

        public string PlanDeEstudioNombre1
        {
            get { return PlanDeEstudioNombre; }
            set { PlanDeEstudioNombre = value; }
        }

        public string UnidadEducativaNombre1
        {
            get { return UnidadEducativaNombre; }
            set { UnidadEducativaNombre = value; }
        }
 
        public string Matricula1
        {
            get { return Matricula; }
            set { Matricula = value; }
        }

        public string InstrumentoLegal1
        {
            get { return InstrumentoLegal; }
            set { InstrumentoLegal = value; }
        }

        public int IdCursoSeccion
        {
            get { return idCursoSeccion; }
            set { idCursoSeccion = value; }
        }

        public int Agrupaciones_idAgrupacio1
        {
            get { return Agrupaciones_idAgrupacio; }
            set { Agrupaciones_idAgrupacio = value; }
        }

        public string Turno1
        {
            get { return Turno; }
            set { Turno = value; }
        }

        public string TipoInstrumentoLegal1
        {
            get { return TipoInstrumentoLegal; }
            set { TipoInstrumentoLegal = value; }
        }

        public string Observaciones1
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }

        public string MotivoCreacion1
        {
            get { return MotivoCreacion; }
            set { MotivoCreacion = value; }
        }

        public string Division1
        {
            get { return Division; }
            set { Division = value; }
        }

        public string Curso1
        {
            get { return Curso; }
            set { Curso = value; }
        }

        public string AliasDivision1
        {
            get { return AliasDivision; }
            set { AliasDivision = value; }
        }

        public string AliasCurso1
        {
            get { return AliasCurso; }
            set { AliasCurso = value; }
        }



        public bool AgregarInstancia(InstanciaGrupo instancia)
        {
            try
            {


                bool ejecucion = false;
                string FechaCreacionAux = String.Format("{0:s}", instancia.FechaCreacion);

                ConexionDB.Comando.CommandText = "call InsertarInstancia('" + instancia.AliasCurso1 + "', '" + instancia.AliasDivision + "', '" + instancia.Curso1 + "', '" + instancia.Division1 + "', '" + FechaCreacionAux + "', '" + instancia.InstrumentoLegal1 + "', '" + instancia.Matricula1 + "', '" + instancia.MotivoCreacion1 + "', '" + instancia.Observaciones1 + "', '" + instancia.TipoInstrumentoLegal1 + "', '" + instancia.Turno1 + "', '" + instancia.Agrupaciones_idAgrupacio1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


        public bool ActualizarInstancia(InstanciaGrupo instancia)
        {
            try
            {


                bool ejecucion = false;
                string FechaCreacionAux = String.Format("{0:s}", instancia.FechaCreacion);

                ConexionDB.Comando.CommandText = "call ActualizarInstancia('" + instancia.idCursoSeccion + "','" + instancia.AliasCurso1 + "', '" + instancia.AliasDivision + "', '" + instancia.Curso1 + "', '" + instancia.Division1 + "', '" + FechaCreacionAux + "', '" + instancia.InstrumentoLegal1 + "', '" + instancia.Matricula1 + "', '" + instancia.MotivoCreacion1 + "', '" + instancia.Observaciones1 + "', '" + instancia.TipoInstrumentoLegal1 + "', '" + instancia.Turno1 + "', '" + instancia.Agrupaciones_idAgrupacio1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


        public bool EliminarInstancia(int Id)
        {
            try
            {

                bool ejecucion = false;

                ConexionDB.Comando.CommandText = "call EliminarInstancia('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }



            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());               
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


        public DataTable MostrarConsultaInstancias(string UnidadEducativa)
        {
            try
            {
                if (UnidadEducativa == "Todas...")
                {
                    UnidadEducativa = "%";
                }

                ConexionDB.Comando.CommandText = "call ConsultaDeInstancias('" + UnidadEducativa + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public int ObtnerIdAgrupamiento(DataGridView agrupamiento, int IdAgrupamiento)
        {


            int FilaAgrupamiento = 0;
            while (IdAgrupamiento != Convert.ToInt32(agrupamiento.Rows[FilaAgrupamiento].Cells[0].Value))
                FilaAgrupamiento++;


            return FilaAgrupamiento;
        }

        public int ObtenerAgrupacionId(int IdAgrupamiento)
        {
            try
            {
                ConexionDB.Comando.CommandText = "call ObtenerAgrupacionId('" + IdAgrupamiento + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);

                return Convert.ToInt32(tabla.Rows[0].Table.Columns[0].ToString());

            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


        public InstanciaGrupo ObtenerInstancia(int IdInstancia)
        {
            try
            {


                InstanciaGrupo variable = new InstanciaGrupo();



                ConexionDB.Comando.CommandText = "call ObtenerInstancia('" + IdInstancia + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                variable.idCursoSeccion = Convert.ToInt32(tabla.Rows[0][0]);
                variable.AliasCurso1 = tabla.Rows[0][1].ToString();
                variable.AliasDivision1 = tabla.Rows[0][2].ToString();
                variable.Curso1 = tabla.Rows[0][3].ToString();
                variable.Division1 = tabla.Rows[0][4].ToString();
                variable.FechaCreacion = Convert.ToDateTime(tabla.Rows[0][5].ToString());
                variable.InstrumentoLegal1 = tabla.Rows[0][6].ToString(); ;
                variable.Matricula1 = tabla.Rows[0][7].ToString();
                variable.MotivoCreacion1 = tabla.Rows[0][8].ToString();
                variable.Observaciones1 = tabla.Rows[0][9].ToString();
                variable.TipoInstrumentoLegal1 = tabla.Rows[0][10].ToString();
                variable.Turno1 = tabla.Rows[0][11].ToString();
                variable.Agrupaciones_idAgrupacio1 = Convert.ToInt32(tabla.Rows[0][12].ToString());


                return variable;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }



    }

    public class UnidadEducativa
    {
        Conexion ConexionDB = new Conexion();
        int Id;

        string Descripcion;

        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }

        public string Descripcion1
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }


        public ComboBox MostrarUnidadEducativa(ComboBox combo, bool todas)
        {


            try
            {

                ConexionDB.Comando.CommandText = "SELECT idUnidadEducativa,Descripcion FROM educacion.unidadeducativa";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                if (todas)
                    combo.Items.Add("Todas...");
                while (ConexionDB.LectorDatos.Read())
                    combo.Items.Add(ConexionDB.LectorDatos["Descripcion"].ToString());
                combo.SelectedIndex = 0;
                return combo;
            }


            catch (Exception ex)
            {
                MessageBox.Show("mostrar: " + ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


        public UnidadEducativa CargarUnidadEducativa(string Nombre, int Id)
        {
            try
            {
                UnidadEducativa variable = new UnidadEducativa();

                ConexionDB.Comando.CommandText = "select * from unidadeducativa where Descripcion like '" + Nombre + "' or  idUnidadEducativa = '" + Id + "'";

                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {
                    variable.Id1 = Convert.ToInt32(ConexionDB.LectorDatos["idUnidadEducativa"].ToString());
                    variable.Descripcion1 = ConexionDB.LectorDatos["Descripcion"].ToString();
                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

    }

    public class PlanesEstudio
    {

        Conexion ConexionDB = new Conexion();

        public DataTable MostrarPlanesEstudio()
        {
            try
            {
                /*      if (UnidadEducativa == "Todas...")
                      {
                          UnidadEducativa = "%";
                      } */

                ConexionDB.Comando.CommandText = "call ConsultaAgrupacion()";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }



    }

    public class MateriaPorPlanes
    {
        Conexion ConexionDB = new Conexion();

        int idMateriaAsociada, HoraRelojReal, Agrupaciones_idAgrupaciones, Materias_idMaterias;
        string TiempoDeCursada;

        public string TiempoDeCursada1
        {
            get { return TiempoDeCursada; }
            set { TiempoDeCursada = value; }
        }

        public int Materias_idMaterias1
        {
            get { return Materias_idMaterias; }
            set { Materias_idMaterias = value; }
        }

        public int Agrupaciones_idAgrupaciones1
        {
            get { return Agrupaciones_idAgrupaciones; }
            set { Agrupaciones_idAgrupaciones = value; }
        }

        public int HoraRelojReal1
        {
            get { return HoraRelojReal; }
            set { HoraRelojReal = value; }
        }

        public int IdMateriaAsociada
        {
            get { return idMateriaAsociada; }
            set { idMateriaAsociada = value; }
        }

        public bool AgregarMateriaPorPlan(MateriaPorPlanes MatxPlan)
        {
            try
            {


                bool ejecucion = false;



                ConexionDB.Comando.CommandText = "call InsertarMateriaPorPlanes('" + MatxPlan.HoraRelojReal1 + "', '" + MatxPlan.TiempoDeCursada1 + "', '" + MatxPlan.Agrupaciones_idAgrupaciones1 + "', '" + MatxPlan.Materias_idMaterias1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public DataTable ConsultaMateriaPorPlanes(int IdAgr)
        {
            try
            {
                ConexionDB.Comando.CommandText = "call ConsultaMateriaPorPlanes('" + IdAgr + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public MateriaPorPlanes ObtenerMateriaPorPlanes(int IdAgr)
        {
            try
            {


                MateriaPorPlanes variable = new MateriaPorPlanes();



                ConexionDB.Comando.CommandText = "call ObtenerMateriaPorPlanes('" + IdAgr + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                variable.idMateriaAsociada = Convert.ToInt32(tabla.Rows[0][0]);
                variable.HoraRelojReal1 = Convert.ToInt32(tabla.Rows[0][1]);
                variable.TiempoDeCursada1 = tabla.Rows[0][2].ToString();
                variable.Agrupaciones_idAgrupaciones1 = Convert.ToInt32(tabla.Rows[0][3].ToString());
                variable.Materias_idMaterias1 = Convert.ToInt32(tabla.Rows[0][4].ToString());

                return variable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool EliminarMateriaPorPlanes(int Id)
        {
            try
            {


                bool ejecucion = false;

                ConexionDB.Comando.CommandText = "call EliminarMateriaPorPlanes('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }

            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Eliminación incorrecta: La Materia que intenta eliminar tiene datos vinculados");
                return true;
            }
                

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool ActualizarMateriaPorPlanes(MateriaPorPlanes MatxPlan)
        {
            try
            {
                bool ejecucion = false;

                ConexionDB.Comando.CommandText = "call ActualizarMateriaPorPlanes('" + MatxPlan.idMateriaAsociada + "','" + MatxPlan.HoraRelojReal1 + "', '" + MatxPlan.TiempoDeCursada1 + "', '" + MatxPlan.Agrupaciones_idAgrupaciones1 + "', '" + MatxPlan.Materias_idMaterias1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }


    }

    public class Materia
    {
        Conexion ConexionDB = new Conexion();

        int idMaterias;
        string Alias, Nombre, Ciclo, Contenido, InstrumentoLegal, Nivel, NucleoDisciplinaAfin, TipoInstrumentoLegal, CargaHorariaSugeridaHsReloj;


        public string CargaHorariaSugeridaHsReloj1
        {
            get { return CargaHorariaSugeridaHsReloj; }
            set { CargaHorariaSugeridaHsReloj = value; }
        }

        public string TipoInstrumentoLegal1
        {
            get { return TipoInstrumentoLegal; }
            set { TipoInstrumentoLegal = value; }
        }

        public string NucleoDisciplinaAfin1
        {
            get { return NucleoDisciplinaAfin; }
            set { NucleoDisciplinaAfin = value; }
        }

        public string Nivel1
        {
            get { return Nivel; }
            set { Nivel = value; }
        }

        public string InstrumentoLegal1
        {
            get { return InstrumentoLegal; }
            set { InstrumentoLegal = value; }
        }

        public string Contenido1
        {
            get { return Contenido; }
            set { Contenido = value; }
        }

        public string Ciclo1
        {
            get { return Ciclo; }
            set { Ciclo = value; }
        }

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string Alias1
        {
            get { return Alias; }
            set { Alias = value; }
        }

        public int IdMaterias
        {
            get { return idMaterias; }
            set { idMaterias = value; }
        }

        public Materia CargarMateria(string Nombre_Materia, int ridMaterias)
        {
            try
            {
                Materia variable = new Materia();

                ConexionDB.Comando.CommandText = "call ConsultaDeMateria('" + ridMaterias + "', '" + Nombre_Materia + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {

                    variable.IdMaterias = Convert.ToInt32(ConexionDB.LectorDatos["IdMaterias"].ToString());
                    variable.Alias1 = ConexionDB.LectorDatos["Alias"].ToString();
                    variable.Nombre1 = ConexionDB.LectorDatos["Nombre"].ToString();
                    variable.Ciclo1 = ConexionDB.LectorDatos["Ciclo"].ToString();

                    variable.Contenido1 = ConexionDB.LectorDatos["Contenido"].ToString();
                    variable.InstrumentoLegal1 = ConexionDB.LectorDatos["InstrumentoLegal"].ToString();
                    variable.Nivel1 = ConexionDB.LectorDatos["Nivel"].ToString();
                    variable.NucleoDisciplinaAfin1 = ConexionDB.LectorDatos["NucleoDisciplinaAfin"].ToString();
                    variable.TipoInstrumentoLegal1 = ConexionDB.LectorDatos["TipoInstrumentoLegal"].ToString();
                    variable.CargaHorariaSugeridaHsReloj1 = ConexionDB.LectorDatos["CargaHorariaSugeridaHsReloj"].ToString();
                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

        public ComboBox MostrarMaterias(ComboBox combo)
        {

            try
            {



                ConexionDB.Comando.CommandText = "SELECT * FROM educacion.materias";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                    combo.Items.Add(ConexionDB.LectorDatos["Nombre"].ToString());
                combo.SelectedIndex = 0;
                return combo;
            }


            catch (Exception ex)
            {
                MessageBox.Show("mostrar: " + ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }

        }

    }

    public class MateriaAsociada
    {
        Conexion ConexionDB = new Conexion();

        string TiempoDeCursada;

        int idMateriaAsociada, HoraRelojReal, Agrupaciones_idAgrupaciones, Materias_idMaterias;



        public int Materias_idMaterias1
        {
            get { return Materias_idMaterias; }
            set { Materias_idMaterias = value; }
        }

        public int Agrupaciones_idAgrupaciones1
        {
            get { return Agrupaciones_idAgrupaciones; }
            set { Agrupaciones_idAgrupaciones = value; }
        }

        public string TiempoDeCursada1
        {
            get { return TiempoDeCursada; }
            set { TiempoDeCursada = value; }
        }

        public int HoraRelojReal1
        {
            get { return HoraRelojReal; }
            set { HoraRelojReal = value; }
        }

        public int IdMateriaAsociada
        {
            get { return idMateriaAsociada; }
            set { idMateriaAsociada = value; }
        }

        public MateriaAsociada ConsultaDeMateriaAsociada(string rNombre, int rId)
        {
            try
            {
                MateriaAsociada variable = new MateriaAsociada();

                ConexionDB.Comando.CommandText = "call ConsultaDeMateriaAsociada('" + rNombre + "', '" + rId + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {
                    variable.IdMateriaAsociada = Convert.ToInt32(ConexionDB.LectorDatos["idMateriaAsociada"].ToString());
                    variable.HoraRelojReal1 = Convert.ToInt32(ConexionDB.LectorDatos["HoraRelojReal"].ToString());
                    variable.TiempoDeCursada1 = ConexionDB.LectorDatos["TiempoDeCursada"].ToString();
                    variable.Agrupaciones_idAgrupaciones1 = Convert.ToInt32(ConexionDB.LectorDatos["Agrupaciones_idAgrupaciones"].ToString());
                    variable.Materias_idMaterias = Convert.ToInt32(ConexionDB.LectorDatos["Materias_idMaterias"].ToString());
                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

        public ComboBox MostrarMateriaCargoVinculado(ComboBox combo, int Id)
        {
            Conexion ConexionDB = new Conexion();

            try
            {

                ConexionDB.Comando.CommandText = "call ObtenerMateriasCargoVinculado('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                    combo.Items.Add(ConexionDB.LectorDatos["Nombre"].ToString());
                combo.SelectedIndex = 0;
                return combo;
            }


            catch (Exception ex)
            {
                MessageBox.Show("mostrar: " + ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public MateriaAsociada CargarMateriaAsociada(int ridMateriaAsociada)
        {
            try
            {
                MateriaAsociada variable = new MateriaAsociada();

                ConexionDB.Comando.CommandText = "call CargarMateriaAsociada('" + ridMateriaAsociada + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {
                    
                    variable.idMateriaAsociada = Convert.ToInt32(ConexionDB.LectorDatos["idMateriaAsociada"].ToString());
                    variable.HoraRelojReal1 = Convert.ToInt32(ConexionDB.LectorDatos["HoraRelojReal"].ToString());
                    variable.TiempoDeCursada1 = ConexionDB.LectorDatos["TiempoDeCursada"].ToString();
                    variable.Agrupaciones_idAgrupaciones1 = Convert.ToInt32(ConexionDB.LectorDatos["Agrupaciones_idAgrupaciones"].ToString());
                    variable.Materias_idMaterias1 = Convert.ToInt32(ConexionDB.LectorDatos["Materias_idMaterias"].ToString());

                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

    }

    public class CargosPorEstablecimiento
    {
        Conexion ConexionDB = new Conexion();

        int idCargoPorEstablecimiento, idNomencladorCargosPOF, idUnidadEducativa, horas;
        string Año, Division, Turno, Observaciones;
        DateTime FechaCreacion = new DateTime();



        public int IdCargoPorEstablecimiento
        {
            get { return idCargoPorEstablecimiento; }
            set { idCargoPorEstablecimiento = value; }
        }

        public int IdUnidadEducativa
        {
            get { return idUnidadEducativa; }
            set { idUnidadEducativa = value; }
        }

        public int IdNomencladorCargosPOF
        {
            get { return idNomencladorCargosPOF; }
            set { idNomencladorCargosPOF = value; }
        }

        public DateTime FechaCreacion1
        {
            get { return FechaCreacion; }
            set { FechaCreacion = value; }
        }

        public string Observaciones1
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }

        public string Año1
        {
            get { return Año; }
            set { Año = value; }
        }

        public string Turno1
        {
            get { return Turno; }
            set { Turno = value; }
        }

        public string Division1
        {
            get { return Division; }
            set { Division = value; }
        }

        public int Horas
        {
            get { return horas; }
            set { horas = value; }
        }

        public bool AgregarCargosPorEstablecimiento(CargosPorEstablecimiento Cargo)
        {
            try
            {

                bool ejecucion = false;
                string FechaCreacionAux = String.Format("{0:s}", Cargo.FechaCreacion1);


                ConexionDB.Comando.CommandText = "call InsertarCargosPorEstablecimiento('" + Cargo.IdNomencladorCargosPOF + "', '" + Cargo.IdUnidadEducativa + "', '" + FechaCreacionAux + "', '" + Cargo.Año1 + "', '" + Cargo.Division1 + "', '" + Cargo.Turno1 + "', '" + Cargo.Horas + "', '" + Cargo.Observaciones1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public DataTable MostrarConsultaCargos(string UnidadEducativa)
        {
            try
            {
                if (UnidadEducativa == "Todas...")
                {
                    UnidadEducativa = "%";
                }

                ConexionDB.Comando.CommandText = "call ConsultaCargos('" + UnidadEducativa + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public ComboBox MostrarNomencladorCargos(ComboBox combo, bool todas)
        {
            Conexion ConexionDB = new Conexion();

            try
            {

                ConexionDB.Comando.CommandText = "SELECT idUnidadEducativa,Descripcion FROM educacion.unidadeducativa";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                if (todas)
                    combo.Items.Add("Todos...");
                while (ConexionDB.LectorDatos.Read())
                    combo.Items.Add(ConexionDB.LectorDatos["Descripcion"].ToString());
                combo.SelectedIndex = 0;
                return combo;
            }


            catch (Exception ex)
            {
                MessageBox.Show("mostrar: " + ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool EliminarCargosPorEstablecimiento(int Id)
        {
            try
            {


                bool ejecucion = false;

                ConexionDB.Comando.CommandText = "call EliminarCargosPorEstablecimiento('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public CargosPorEstablecimiento ObtenerCargosPorEstablecimiento(int Id)
        {
            try
            {
                CargosPorEstablecimiento variable = new CargosPorEstablecimiento();

                ConexionDB.Comando.CommandText = "call ObtenerCargosPorEstablecimiento('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);

                variable.IdCargoPorEstablecimiento = Convert.ToInt32(tabla.Rows[0][0]);
                variable.IdNomencladorCargosPOF = Convert.ToInt32(tabla.Rows[0][1]);
                variable.IdUnidadEducativa = Convert.ToInt32(tabla.Rows[0][2]);
                variable.FechaCreacion1 = Convert.ToDateTime(tabla.Rows[0][3].ToString());
                variable.Año1 = tabla.Rows[0][4].ToString();
                variable.Division1 = tabla.Rows[0][5].ToString();
                variable.Turno1 = tabla.Rows[0][6].ToString();
                variable.Horas = Convert.ToInt32(tabla.Rows[0][7]);
                variable.Observaciones1 = tabla.Rows[0][8].ToString();

                return variable;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool ActualizarCargoPorEstablecimiento(CargosPorEstablecimiento Cargo)
        {
            try
            {
                bool ejecucion = false;
                string FechaCreacionAux = String.Format("{0:s}", Cargo.FechaCreacion1);


                ConexionDB.Comando.CommandText = "call ActualizarCargoPorEstablecimiento('" + Cargo.idCargoPorEstablecimiento + "','" + Cargo.IdNomencladorCargosPOF + "', '" + Cargo.IdUnidadEducativa + "', '" + FechaCreacionAux + "', '" + Cargo.Año1 + "', '" + Cargo.Division1 + "', '" + Cargo.Turno + "', '" + Cargo.Horas + "', '" + Cargo.Observaciones1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public CargosPorEstablecimiento CargarCargoPorEstablecimiento(int ridCargoPorEstablecimiento)
        {
            try
            {
                CargosPorEstablecimiento variable = new CargosPorEstablecimiento();

                ConexionDB.Comando.CommandText = "call CargarCargoPorEstablecimiento('" + ridCargoPorEstablecimiento + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {

                    variable.IdCargoPorEstablecimiento = Convert.ToInt32(ConexionDB.LectorDatos["idCargoPorEstablecimiento"].ToString());
                    variable.IdNomencladorCargosPOF = Convert.ToInt32(ConexionDB.LectorDatos["NomencladorCargosPOF_idNomencladorCargosPOF"].ToString());
                    variable.IdUnidadEducativa = Convert.ToInt32(ConexionDB.LectorDatos["UnidadEducativa_idUnidadEducativa"].ToString());
                    variable.FechaCreacion1 = Convert.ToDateTime(ConexionDB.LectorDatos["FechaCreacion"].ToString());
                    variable.Division1 = ConexionDB.LectorDatos["Division"].ToString();
                    variable.Turno1 = ConexionDB.LectorDatos["Turno"].ToString();
                    variable.Horas = Convert.ToInt32(ConexionDB.LectorDatos["Horas"].ToString());
                    variable.Observaciones1 = ConexionDB.LectorDatos["Observaciones"].ToString();
                    variable.Año1 = ConexionDB.LectorDatos["Año"].ToString();

                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }


    }

    public class CargoVinculado
    {
        Conexion ConexionDB = new Conexion();


        int idDistribucionPorCargo, CursoSeccion_idCursoSeccion, CargoPorEstablecimiento_idCargoPorEstablecimiento, MateriaAsociada_idMateriaAsociada;

        DateTime FechaVinculo, FechaDesvinculo = new DateTime();

        public DateTime FechaDesvinculo1
        {
            get { return FechaDesvinculo; }
            set { FechaDesvinculo = value; }
        }

        public DateTime FechaVinculo1
        {
            get { return FechaVinculo; }
            set { FechaVinculo = value; }
        }

        public int MateriaAsociada_idMateriaAsociada1
        {
            get { return MateriaAsociada_idMateriaAsociada; }
            set { MateriaAsociada_idMateriaAsociada = value; }
        }

        public int CargoPorEstablecimiento_idCargoPorEstablecimiento1
        {
            get { return CargoPorEstablecimiento_idCargoPorEstablecimiento; }
            set { CargoPorEstablecimiento_idCargoPorEstablecimiento = value; }
        }

        public int CursoSeccion_idCursoSeccion1
        {
            get { return CursoSeccion_idCursoSeccion; }
            set { CursoSeccion_idCursoSeccion = value; }
        }

        public int IdDistribucionPorCargo
        {
            get { return idDistribucionPorCargo; }
            set { idDistribucionPorCargo = value; }
        }

        public ComboBox ObtenerCargoDistribucionPorCargo(ComboBox combo, string rUnidadEducativa)
        {
            Conexion ConexionDB = new Conexion();
            string cadena;
            try
            {

                ConexionDB.Comando.CommandText = "call ObtenerCargoDistribucionPorCargo('" + rUnidadEducativa + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {
                    cadena = ConexionDB.LectorDatos["idCargoPorEstablecimiento"].ToString();
                    cadena = cadena + " - " + ConexionDB.LectorDatos["Descripcion"].ToString();
                    cadena = cadena + " - " + ConexionDB.LectorDatos["Horas"].ToString() + "Hs.";
                    cadena = cadena + " - " + ConexionDB.LectorDatos["Año"].ToString();
                    cadena = cadena + " - " + ConexionDB.LectorDatos["Division"].ToString();
                    cadena = cadena + " - " + ConexionDB.LectorDatos["Turno"].ToString();

                    combo.Items.Add(cadena);

                }


                combo.SelectedIndex = 0;
                return combo;
            }


            catch (Exception ex)
            {
                MessageBox.Show("mostrar: " + ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public DataTable MostrarConsultaCargoVinculado(int Id)
        {
            try
            {

                ConexionDB.Comando.CommandText = "call ConsultaCargoVinculado('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);
                return tabla;
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool AgregarCargoVinculado(CargoVinculado CargoVinculado)
        {
            try
            {

                bool ejecucion = false;
                string FechaVinculoAux = String.Format("{0:s}", CargoVinculado.FechaVinculo1);

                ConexionDB.Comando.CommandText = "call InsertarCargoVinculado('" + FechaVinculoAux + "', '" + CargoVinculado.CursoSeccion_idCursoSeccion1 + "', '" + CargoVinculado.CargoPorEstablecimiento_idCargoPorEstablecimiento1 + "', '" + CargoVinculado.MateriaAsociada_idMateriaAsociada1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public bool EliminarCargoVinculado(int Id)
        {
            try
            {


                bool ejecucion = false;

                ConexionDB.Comando.CommandText = "call EliminarCargoVinculado('" + Id + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

        public CargoVinculado CargarCargoVinculado(int ridCargoVinculado)
        {
            try
            {
                CargoVinculado variable = new CargoVinculado();


                ConexionDB.Comando.CommandText = "call CargarCargoVinculado('" + ridCargoVinculado + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                DataTable tabla = new DataTable();
                ConexionDB.adaptador.Fill(tabla);


                ConexionDB.Conector.Open();
                ConexionDB.LectorDatos = ConexionDB.Comando.ExecuteReader();
                while (ConexionDB.LectorDatos.Read())
                {
                    variable.IdDistribucionPorCargo = Convert.ToInt32(ConexionDB.LectorDatos["idDistribucionPorCargo"].ToString());
                    variable.CargoPorEstablecimiento_idCargoPorEstablecimiento1 = Convert.ToInt32(ConexionDB.LectorDatos["CargoPorEstablecimiento_idCargoPorEstablecimiento"].ToString());
                    variable.CursoSeccion_idCursoSeccion1 = Convert.ToInt32(ConexionDB.LectorDatos["CursoSeccion_idCursoSeccion"].ToString());
                    variable.FechaVinculo1 = Convert.ToDateTime(ConexionDB.LectorDatos["FechaVinculo"]);
                    if (!DBNull.Value.Equals(ConexionDB.LectorDatos["FechaDesvinculo"]))
                        variable.FechaDesvinculo1 = Convert.ToDateTime(ConexionDB.LectorDatos["FechaDesvinculo"]);



                    variable.MateriaAsociada_idMateriaAsociada1 = Convert.ToInt32(ConexionDB.LectorDatos["MateriaAsociada_idMateriaAsociada"].ToString());

                }

                return variable;

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }


        }

        public bool ActualizarDistribucionPorCargo(CargoVinculado rCargoVinculado)
        {
            try
            {
                bool ejecucion = false;
                string FechaCreacionAux1 = String.Format("{0:s}", rCargoVinculado.FechaVinculo1);
                string FechaCreacionAux2 = String.Format("{0:s}", rCargoVinculado.FechaDesvinculo1);

                ConexionDB.Comando.CommandText = "call ActualizarDistribucionPorCargo('" + rCargoVinculado.IdDistribucionPorCargo + "','" + FechaCreacionAux1 + "', '" + FechaCreacionAux2 + "', '" + rCargoVinculado.CursoSeccion_idCursoSeccion1 + "', '" + rCargoVinculado.CargoPorEstablecimiento_idCargoPorEstablecimiento1 + "', '" + rCargoVinculado.MateriaAsociada_idMateriaAsociada1 + "')";
                ConexionDB.Comando.CommandType = CommandType.Text;
                ConexionDB.Conector.Open();
                ConexionDB.Comando.ExecuteNonQuery();
                ejecucion = true;
                return ejecucion;

            }


            catch (Exception)
            {
                throw;
            }


            finally
            {
                if (ConexionDB.Conector != null)
                {
                    ConexionDB.Conector.Close();
                }
            }
        }

    }
    
    public class AgendaAmbiente
    {
        int idAgendaAmbiente, DistribucionPorCargo_idDistribucionPorCargo, Ambiente_idAmbiente;
        DateTime FechaDesde, FechaHasta;
        string Observaciones;

        public int Ambiente_idAmbiente1
        {
            get { return Ambiente_idAmbiente; }
            set { Ambiente_idAmbiente = value; }
        }

        public int DistribucionPorCargo_idDistribucionPorCargo1
        {
            get { return DistribucionPorCargo_idDistribucionPorCargo; }
            set { DistribucionPorCargo_idDistribucionPorCargo = value; }
        }

        public int IdAgendaAmbiente
        {
            get { return idAgendaAmbiente; }
            set { idAgendaAmbiente = value; }
        }

        public DateTime FechaHasta1
        {
            get { return FechaHasta; }
            set { FechaHasta = value; }
        }

        public DateTime FechaDesde1
        {
            get { return FechaDesde; }
            set { FechaDesde = value; }
        }

        public string Observaciones1
        {
            get { return Observaciones; }
            set { Observaciones = value; }
        }
            
        public bool InterseccionAgendas(Calendar rAgenda, CalendarItem rItem)
        {
            foreach(CalendarItem pivot in rAgenda.Items)
            {
                if (Calendar.DateIntersects(rItem.StartDate, rItem.EndDate, pivot.StartDate, pivot.EndDate))
                {
                    //MessageBox.Show("Item pivot: " + pivot.StartDate.ToString() + "a" + pivot.EndDate.ToString() + "\r" + "Item duplicado: " + rItem.StartDate.ToString() + "a" + rItem.EndDate.ToString());
                    return true;
                }
            }

            return false;
        }

        public DateTime ObtenerPrimerLunes(DateTime rfecha)
        {
            DateTime aux = Convert.ToDateTime("01/" + rfecha.Month.ToString() + "/" + rfecha.Year.ToString());

            while (aux.DayOfWeek.ToString() != "Monday")
            {
                aux = aux.AddDays(1);
            }



            return aux;
        }

        public DateTime ObtenerDomingo(DateTime rfecha)
        {
            DateTime aux = rfecha;

            while (aux.DayOfWeek.ToString() != "Sunday")
            {
                aux = aux.AddDays(1);
            }



            return aux;
        }

        public string GetTareaItem(CalendarItem rItem)
        {
            try
            {
                // (Tarea) Obtengo de la cadena de carateres la tarea
                return rItem.Text.Substring(0, rItem.Text.IndexOf(','));
            }

            catch (ArgumentOutOfRangeException)
            {
                return "";
            }



        }

        public string GetSalaItem(CalendarItem rItem)
        {
            try
            {
                string aux;
                //Elimino de la cadena de caracteres la tarea y los caracteres especiales a la derecha
                aux = rItem.Text.Replace(this.GetTareaItem(rItem) + ",\r", "");

                //(Sala)Elimino la coma de la derecha
                return aux.Substring(0, aux.IndexOf(','));

            }

            catch (ArgumentOutOfRangeException)
            {
                return "";
            }

        }

        public string GetTextoItem(string rTarea, string rSala, DateTime rStarDate, DateTime rEndDate) 
        {

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("Es-Es");
            return rTarea + ",\r" + rSala + ",\r" + rStarDate.TimeOfDay.ToString() + " a " + rEndDate.TimeOfDay.ToString() + "\r<" + Convert.ToString(ci.DateTimeFormat.GetDayName(rStarDate.DayOfWeek)) + ">";

        }

    }

    public struct EstructuraItem
    {
        string Texto, DiaDeSemana;
        DateTime FechaInicio, FechaFin;


        public string DiaDeSemana1
        {
            get { return DiaDeSemana; }
            set { DiaDeSemana = value; }
        }

        public string Texto1
        {
            get { return Texto; }
            set { Texto = value; }
        }

        public DateTime FechaFin1
        {
            get { return FechaFin; }
            set { FechaFin = value; }
        }

        public DateTime FechaInicio1
        {
            get { return FechaInicio; }
            set { FechaInicio = value; }
        }

        public bool CompararIgualdadEstructura(EstructuraItem E2)
        {
            if (this.Texto1 == E2.Texto1) // & this.DiaDeSemana1 == E2.DiaDeSemana1
                return true;
            return false;

        }



    }

}
