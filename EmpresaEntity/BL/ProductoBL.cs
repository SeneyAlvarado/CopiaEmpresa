using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;
using System.Data;

namespace BL
{
    public class ProductoBL
    {
        public int Codigo;
        public String Descripcion;
        public int PrecioVenta;
        public int CantidadInventario;
        public DAOHandler dao = new DAOHandler();


        public void getProductos(DataTable tableProductos)
        {
            tableProductos.Rows.Clear();

            foreach (ProductoTO item in dao.getProductos())
            {
                tableProductos.Rows.Add(item.Codigo, item.Descripcion, item.PrecioVenta
                    , item.CantidadInventario);
            }
        }

        public void agregarProducto(int ID, String descrip, int precio,
            int disponibles)
        {
            this.Codigo = ID;
            this.Descripcion = descrip;
            this.PrecioVenta = precio;
            this.CantidadInventario = disponibles;

            ProductoTO productoTO = new ProductoTO();
            productoTO.Codigo = this.Codigo;
            productoTO.CantidadInventario = this.CantidadInventario;
            productoTO.Descripcion = this.Descripcion;
            productoTO.PrecioVenta = this.PrecioVenta;

            dao = new DAOHandler();
            dao.insertarProducto(productoTO);

        }

        public void eliminarProducto(String codigo)
        {
            this.Codigo = int.Parse(codigo);

            ProductoTO productoTO = new ProductoTO();
            productoTO.Codigo = this.Codigo;

            try
            {
                dao = new DAOHandler();
                dao.eliminarProducto(productoTO);
            }
            catch (Exception e)
            {
                throw new Exception();
            }

        }


    }
}
