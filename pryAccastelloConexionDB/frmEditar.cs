using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAccastelloConexionDB
{
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
        }
        clsConexionBD objConexion = new clsConexionBD();

        private int codigoSeleccionado = -1;
        private void frmEditar_Load(object sender, EventArgs e)
        {
            objConexion.ConectarBD();
            DataTable datos = objConexion.ObtenerDatosTabla("Productos");
            dgvGrilla.DataSource = datos;
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Productos");
            DataTable categorias = objConexion.ObtenerCategorias();
            
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";  // Lo que se muestra
            cmbCategoria.ValueMember = "Id";        // El valor real (por ejemplo, para guardar en DB)
            cmbCategoria.SelectedIndex = -1;        // Opcional, para que no haya nada seleccionado al inicio
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);


            // Suscribir los eventos de cambio
            txtNombre.TextChanged += new EventHandler(ControlCambio);
            txtDescripcion.TextChanged += new EventHandler(ControlCambio);
            cmbCategoria.SelectedIndexChanged += new EventHandler(ControlCambio);
            numPrecio.ValueChanged += new EventHandler(ControlCambio);
            numStock.ValueChanged += new EventHandler(ControlCambio);

            // Validar al iniciar el formulario
            ValidarCampos();
        }
        private void ControlCambio(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            bool camposCompletos =
           !string.IsNullOrWhiteSpace(txtNombre.Text) &&
           !string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
           cmbCategoria.SelectedIndex >= 0 &&
           numPrecio.Value > 0 &&
           numStock.Value > 0;

            btnModificar.Enabled = camposCompletos;
        }


        private void dgvGrilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            numBuscarId.Value = 0;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvGrilla.Rows[e.RowIndex];

                // Guardamos el Código del producto para luego usarlo en la modificación
                codigoSeleccionado = Convert.ToInt32(fila.Cells["Codigo"].Value);

                // Cargamos los valores en los controles
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                numPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                numStock.Value = Convert.ToInt32(fila.Cells["Stock"].Value);
                cmbCategoria.SelectedValue = fila.Cells["CategoriaId"].Value;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (codigoSeleccionado == -1)
            {
                MessageBox.Show("Seleccioná un producto para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = numPrecio.Value;
            int stock = (int)numStock.Value;
            string categoriaId = cmbCategoria.SelectedValue.ToString();

            // Llamar al método que actualiza en la base de datos
            objConexion.ModificarProducto(
                codigoSeleccionado,
                nombre,
                descripcion,
                precio,
                stock,
                categoriaId
            );

            // Actualizar la grilla
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Productos");

            // Limpiar los controles
            codigoSeleccionado = -1;
            txtNombre.Clear();
            txtDescripcion.Clear();
            numPrecio.Value = 0;
            numStock.Value = 0;
            cmbCategoria.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (codigoSeleccionado == -1)
            {
                MessageBox.Show("Seleccioná un producto para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            var resultado = MessageBox.Show("¿Estás seguro de que querés eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                objConexion.EliminarProducto(codigoSeleccionado);

                // Actualizar la grilla
                dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Productos");

                // Limpiar controles
                codigoSeleccionado = -1;
                txtNombre.Clear();
                txtDescripcion.Clear();
                numPrecio.Value = 0;
                numStock.Value = 0;
                cmbCategoria.SelectedIndex = -1;
            }
        }

        private void btnDesacer_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            // Limpiar controles
            txtNombre.Clear();
            txtDescripcion.Clear();
            numPrecio.Value = 0;
            numStock.Value = 0;
            numBuscarId.Value = 0;
            cmbCategoria.SelectedIndex = -1;

            // Habilitar los controles nuevamente si estaban desactivados
            txtNombre.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            numPrecio.Enabled = true;
            numStock.Enabled = true;
            cmbCategoria.Enabled = true;

            // Quitar selección del DataGridView
            dgvGrilla.ClearSelection();
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Productos");

            // Resetear el identificador seleccionado
            codigoSeleccionado = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            int idBuscado = (int)numBuscarId.Value;

            DataTable resultado = objConexion.BuscarProductoPorId(idBuscado);

            if (resultado.Rows.Count > 0)
            {
                DataRow fila = resultado.Rows[0];

                // Cargar datos en los controles
                codigoSeleccionado = idBuscado;
                txtNombre.Text = fila["Nombre"].ToString();
                txtDescripcion.Text = fila["Descripcion"].ToString();
                numPrecio.Value = Convert.ToDecimal(fila["Precio"]);
                numStock.Value = Convert.ToInt32(fila["Stock"]);
                cmbCategoria.SelectedValue = fila["CategoriaId"];

                
                dgvGrilla.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("No se encontró un producto con ese ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
