using System;
using System.Collections.Generic;
using System.Data.SQLite;         
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gastos.Config
{
    public class ConexionSqlite
    {
        private const string CadenaConexion = "Data Source=gastos.db;Version=3";

        public SQLiteConnection ObtenerConexion()
        {
            return new SQLiteConnection(CadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (var conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERROR DE SQLITE:\n\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}