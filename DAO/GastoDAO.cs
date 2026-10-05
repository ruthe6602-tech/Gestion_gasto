using System;
using System.Collections.Generic;
using gastos.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gastos.Config;
using System.Windows.Forms;

namespace gastos.DAO
{
    public class GastoDAO
    {
        ConexionSqlite conexionBD = new ConexionSqlite();

        public void CrearTabla()
        {
            using (var conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();
                string SQL = @"
                    CREATE TABLE IF NOT EXISTS Gasto (
                        IdGasto INTEGER PRIMARY KEY AUTOINCREMENT,
                        Descripcion TEXT NOT NULL,
                        Categoria TEXT NOT NULL,
                        Monto INTEGER NOT NULL,
                        Fecha DATETIME NOT NULL,
                        MetodoPago TEXT NOT NULL
                    );
                ";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(SQL, conexion))
                {
                    cmd.ExecuteNonQuery();
                }
            }

        }

        public void InsertarGasto(Gasto gasto)
        {
            using (var conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();
                string SQL = @"
                    INSERT INTO Gasto 
                    (Descripcion, 
                     Categoria, 
                     Monto, 
                     Fecha, 
                     MetodoPago)
                    VALUES 
                    (@Descripcion, 
                     @Categoria, 
                     @Monto, 
                     @Fecha, 
                     @MetodoPago);
                ";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(SQL, conexion))
                {

                    cmd.Parameters.AddWithValue("@Descripcion", gasto.Descripcion);
                    cmd.Parameters.AddWithValue("@Categoria", gasto.Categoria);
                    cmd.Parameters.AddWithValue("@Monto", gasto.Monto);
                    cmd.Parameters.AddWithValue("@Fecha", gasto.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@MetodoPago", gasto.MetodoPago);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Gasto> Lista()
        {
            var lista = new List<Gasto>();

            using (var conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();
                string SQL = @"SELECT 
                                  IdGasto,
                                  Descripcion,
                                  Categoria,
                                  Monto,
                                  Fecha,
                                  MetodoPago
                           FROM Gasto
                           ORDER BY Fecha DESC";

                using (var cmd = new System.Data.SQLite.SQLiteCommand(SQL, conexion))
                {
                    using (var resultado = cmd.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            lista.Add(new Gasto
                            {
                                IdGasto = resultado.GetInt32(0),
                                Descripcion = resultado.GetString(1),
                                Categoria = resultado.GetString(2),
                                Monto = Convert.ToInt32(resultado.GetValue(3)),
                                Fecha = DateTime.ParseExact(resultado.GetString(4), "yyyy-MM-dd HH:mm:ss", null),
                                MetodoPago = resultado.GetString(5),

                            });
                        }
                    }
                }
            }

            return lista;
        }


        public void actualizarGasto(Gasto gasto)
        {
            using (var conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();
                string SQL = @"
                    UPDATE Gasto
                    SET Descripcion = @Descripcion,
                        Categoria = @Categoria,
                        Monto = @Monto,
                        Fecha = @Fecha,
                        MetodoPago = @MetodoPago
                    WHERE IdGasto = @IdGasto;
                ";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(SQL, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdGasto", gasto.IdGasto);
                    cmd.Parameters.AddWithValue("@Descripcion", gasto.Descripcion);
                    cmd.Parameters.AddWithValue("@Categoria", gasto.Categoria);
                    cmd.Parameters.AddWithValue("@Monto", gasto.Monto);
                    cmd.Parameters.AddWithValue("@Fecha", gasto.Fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@MetodoPago", gasto.MetodoPago);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();
                string SQL = @"
                    DELETE FROM Gasto
                    WHERE IdGasto = @IdGasto;
                ";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(SQL, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdGasto", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


