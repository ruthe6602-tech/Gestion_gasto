using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gastos.Config;
using gastos.Controllers;
using gastos.Models;
namespace gastos.Views
{
    public partial class frmGastos : Form
    {
        ConexionSqlite conexionSqlita = new ConexionSqlite();

        private readonly GastoController gastoController;
        public frmGastos()
        {
            InitializeComponent();

            gastoController = new GastoController();
        }

        
        private void Categoria(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Alimentación");
            combo.Items.Add("Transporte");
            combo.Items.Add("Salud");
            combo.Items.Add("Educación");
            combo.Items.Add("Entretenimiento");
            combo.Items.Add("Vivienda");
            combo.Items.Add("Servicios");
            combo.Items.Add("Compras");
        }

      private void Metodopago (ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Efectivo");
            combo.Items.Add("Tarjeta");
            combo.Items.Add("Transferencia");
            combo.Items.Add("Yape");
            combo.Items.Add("Plin");
            combo.Items.Add("Otro");

        }

       private void frmGastos_Load(object sender, EventArgs e)
       {
            Categoria(cbxcategoria);
            Metodopago(cbxmetodopago);
            CargarTablaGastos(dgvtablagastos);

            if (conexionSqlita.ProbarConexion())
            {
                // MessageBox.Show("Conexion exitosa ", "EXITO");

                lblEstatus.Text = "Conectado a la Base de Datos";
                lblEstatus.ForeColor = Color.Green;

            }
            else
            {
                //MessageBox.Show("Nose pudo conectar a la base de datos ", "ALERTA");
                lblEstatus.Text = "No tiene conexion a la base de Datos";
                lblEstatus.ForeColor = Color.Red;
            }
       }

        private void CargarTablaGastos(DataGridView dataGridView)
        {
            dataGridView.DataSource =null;
            dataGridView.DataSource = gastoController.ListarGastos();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripcion no puede ser vacío", "Atención");
                return;
            }
            if(cbxcategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar algun valor", "Atención");
                return;
            }
            if(txtmonto.Value == 0)
            {
                MessageBox.Show("Debes seleccionar algun monto", "Atención");
                return;

            }
            if(cbxmetodopago.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar Método de pago", "Atención");
                return;
            }

            Gasto gasto = new Gasto
            {
                Descripcion = txtdescripcion.Text,
                Categoria = cbxcategoria.Text,
                Monto = (int)decimal.Parse(txtmonto.Value.ToString()),
                Fecha = datefecha.Value,
                MetodoPago = cbxmetodopago.Text,

            };

            gastoController.Registrar(gasto);
            {
                CargarTablaGastos(dgvtablagastos);
                MessageBox.Show("Datos registrados correctamente", "Correcto!");
                return;
            }

            
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(dgvtablagastos.CurrentRow== null)
            {
                return;
            }
            int idGasto = Convert.ToInt32(dgvtablagastos.CurrentRow.Cells["IdGasto"].Value);

            gastoController.Eliminar(idGasto);
            {
                CargarTablaGastos(dgvtablagastos);
                MessageBox.Show("Datos eliminado correctamente", "correcto!");
                 return;
            }
            }

        private void dgvtablagastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvtablagastos.CurrentRow == null)
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea actualizar el registro?", 
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {

                DataGridViewRow fila = dgvtablagastos.CurrentRow;

                txtdescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                cbxcategoria.Text = fila.Cells["Categoria"].Value.ToString();
                txtmonto.Value = Convert.ToDecimal(fila.Cells["Monto"].Value);

                if (fila.Cells["Fecha"].Value != null)
                {
                    datefecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                }

                cbxmetodopago.Text = fila.Cells["MetodoPago"].Value.ToString();
            }



        }
    }
}





