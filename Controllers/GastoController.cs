using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gastos.DAO;
using gastos.Models;

namespace gastos.Controllers
{
    public class GastoController
    {
        private readonly GastoDAO gastoDAO;

        public GastoController()
        {
            gastoDAO = new GastoDAO();
            gastoDAO.CrearTabla();
        }

        public  void Registrar(Gasto gasto)
        {
            gastoDAO.InsertarGasto(gasto);
        }
        public void Actualizar(Gasto gasto)
        {
            gastoDAO.actualizarGasto(gasto);
        }

        public List<Gasto> ListarGastos()
        {
            return gastoDAO.Lista();
        }

        public void Eliminar(int id)
        {
            gastoDAO.Eliminar(id);
        }
    }
}
