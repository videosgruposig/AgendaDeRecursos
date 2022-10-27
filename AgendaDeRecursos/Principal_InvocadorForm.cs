using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SesionBD;

using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;




namespace AgendaDeRecursos
{
    static class Principal_InvocadorForm
    {
 
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }
    }
}
