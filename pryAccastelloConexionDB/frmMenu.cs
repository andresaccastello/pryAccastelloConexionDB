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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        clsConexionBD objConexion = new clsConexionBD();
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInicio ventanaDatos = new frmInicio();
            ventanaDatos.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            objConexion.ConectarBD();
            DataTable datos = objConexion.ObtenerDatosTabla("Productos");
            dgvGrilla.DataSource = datos;
            dgvGrilla.DataSource = objConexion.ObtenerDatosTabla("Productos");
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditar ventanaDatos = new frmEditar();
            ventanaDatos.ShowDialog();
        }
    }
}
