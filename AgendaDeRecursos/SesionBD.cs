using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using AgendaDeRecursos;


namespace SesionBD
{
    public class Conexion
    {
        //OleDbConnection Conector;
        public MySqlConnection Conector;
        public MySqlCommand Comando;
        public MySqlDataAdapter adaptador;
        public MySqlDataReader LectorDatos;




        private void ConectarA()
        {

            Conector = new MySqlConnection(@"server=127.0.0.1; database=Educacion; Uid=root; pwd=root");
            Comando = Conector.CreateCommand();
            adaptador = new MySqlDataAdapter(Comando);
        }

        public Conexion()
        {
            ConectarA();
        }




    }
}

