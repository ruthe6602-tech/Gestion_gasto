using System;

namespace gastos.Models
{
    public class Gasto
    {
        public int IdGasto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }

    }
}
