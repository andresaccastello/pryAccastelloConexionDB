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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        clsConexionBD objConexion = new clsConexionBD();
        
        private int codigoSeleccionado = -1;

        private void Form1_Load(object sender, EventArgs e)
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

            btnCargar.Enabled = camposCompletos;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            decimal precio = numPrecio.Value;
            int stock = (int)numStock.Value;
            string categoriaId = cmbCategoria.SelectedValue.ToString();

            objConexion.InsertarContacto(
                nombre,
                descripcion,
                precio,
                stock,
                categoriaId
            );

            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Categorias");
        }

        private void btnDesacer_Click(object sender, EventArgs e)
        {
          
            // Limpiar controles
            txtNombre.Clear();
            txtDescripcion.Clear();
            numPrecio.Value = 0;
            numStock.Value = 0;
            
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


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
