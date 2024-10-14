using Sesion17G3.Servicios;
using Sesion17G3.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion17G3.Formularios
{
    public partial class ProductoFrm : Form
    {
        //Crear un objeto de la clase producto
        ProductoServicio productos;

        public ProductoFrm()
        {
            InitializeComponent();
            productos = new ProductoServicio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductoFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.ID = int.Parse(tbID.Text);
            prod.Nombre = tbNombre.Text;
            prod.Descripcion = tbDescripcion.Text;
            prod.Precio =double.Parse(tbPrecio.Text);
            productos.AgregarProducto(prod);
            MostrarRegistros();
        }

        private void MostrarRegistros()
        {
            DvgRegistros.DataSource = null;
            DvgRegistros.DataSource = productos.Productos();
        }
    }
}
