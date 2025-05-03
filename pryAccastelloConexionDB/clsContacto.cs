using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryAccastelloConexionDB
{
    internal class clsContacto
    {
        public int ContactoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Categoria { get; set; }

        // Constructor
        public clsContacto(int contactoId, string nombre, string descripcion, decimal precio, int stock, int categoria)
        {
            ContactoId = contactoId;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
            Categoria = categoria;
        }
    }
}
