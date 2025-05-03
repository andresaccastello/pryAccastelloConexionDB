using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAccastelloConexionDB
{
    internal class clsConexionBD
    {

        //cadena de conexion
        string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=Comercio;Trusted_Connection=True";

        //conector
        SqlConnection coneccionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;


        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }

        public DataTable ObtenerDatosTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = $"SELECT * FROM {"Productos"}";
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        conexion.Open();
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }

            return tabla;
        }
        public void InsertarContacto(string nombre, string descripcion, decimal precio, int stock, string categoria)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    string consulta = "INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, CategoriaId) " +
                                      "VALUES (@Nombre, @Descripcion, @Precio, @Stock, @CategoriaId)";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion);
                        comando.Parameters.AddWithValue("@Precio", precio);
                        comando.Parameters.AddWithValue("@Stock", stock);
                        comando.Parameters.AddWithValue("@CategoriaId", categoria);

                        conexion.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Producto insertado correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el producto: " + ex.Message);
            }
        }

        public void ModificarProducto(int codigo, string nombre, string descripcion, decimal precio, int stock, string categoriaId)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "UPDATE Productos SET Nombre = @nombre, Descripcion = @descripcion, Precio = @precio, Stock = @stock, CategoriaId = @categoriaId WHERE Codigo = @codigo";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@categoriaId", categoriaId);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarProducto(int codigo)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "DELETE FROM Productos WHERE Codigo = @codigo";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObtenerCategorias()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT Id, Nombre FROM Categorias";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public DataTable BuscarProductoPorId(int codigo)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM Productos WHERE Codigo = @codigo";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }





    }


}
