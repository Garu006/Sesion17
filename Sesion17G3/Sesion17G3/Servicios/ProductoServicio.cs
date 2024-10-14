using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Sesion17G3.Modelos;
using NLog;
using System.Windows.Forms;

namespace Sesion17G3.Servicios
{
    internal class ProductoServicio
    {
        List<Producto> productos = new List<Producto>();

        public List<Producto> Productos()
        {
            return productos;
        }
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public Producto BuscarProducto(Producto producto)
        {
            return productos.Find(prod => prod.ID == producto.ID);
        }

        public void EliminarProdcuto(Producto producto, Logger logger)
        {
            try
            {
                productos.Remove(producto);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "ta malo");
                MessageBox.Show($"Error: { ex.Message}");
            }   
        }
        public void ActualizarProducto(Producto producto, int id)/*Index = Identifica un producto en una lista segun el ID, el insert = inserta un nuevo producto en una lista */
        {
            int index = productos.FindIndex(prod => prod.ID == id);

            if(index != -1)
            {
                productos[index] = producto;
            }
        }
        public Logger GetLogger(Logger logger)
        {
            return logger;
        }
    }
}
