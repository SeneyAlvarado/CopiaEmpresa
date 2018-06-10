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
        public Double PrecioVenta;
        public int CantidadInventario;
        public ProductoDAO productoDAO = new ProductoDAO();


        public void getProductos(DataTable tableProductos)
        {
            tableProductos.Rows.Clear();

            foreach (ProductoTO item in productoDAO.getProductos())
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

            try
            {
                productoDAO = new ProductoDAO();
                productoDAO.insertarProducto(productoTO);
            }
            catch (Exception e)
            {
                throw;
            }
            

        }

        public void eliminarProducto(String codigo)
        {
            this.Codigo = int.Parse(codigo);

            ProductoTO productoTO = new ProductoTO();
            productoTO.Codigo = this.Codigo;

            try
            {
                productoDAO = new ProductoDAO();
                productoDAO.eliminarProducto(productoTO);
            }
            catch (Exception e)
            {
                throw new Exception();
            }

        }

        public void buscarProducto(String codigo)
        {
            try
            {
                this.Codigo = int.Parse(codigo);
                ProductoTO productoTO = new ProductoTO();
                productoTO.Codigo = this.Codigo;

                productoDAO = new ProductoDAO();
                productoDAO.extraerProducto(productoTO);

                this.CantidadInventario = productoTO.CantidadInventario;
                this.Descripcion = productoTO.Descripcion;
                this.PrecioVenta  = productoTO.PrecioVenta;
            }
            catch (Exception)
            {
                throw;
            }
    }

        public void actualizarProducto(String codigo, String descripcion, String precio,
            String cantidad)
        {
            this.Codigo = int.Parse(codigo);
            this.Descripcion = descripcion;
            this.PrecioVenta = Double.Parse(precio);
            this.CantidadInventario = int.Parse(cantidad);

            ProductoTO productoTO = new ProductoTO();
            productoTO.Codigo = int.Parse(codigo);
            productoTO.CantidadInventario = int.Parse(cantidad);
            productoTO.Descripcion = descripcion;
            productoTO.PrecioVenta = Double.Parse(precio);

            productoDAO = new ProductoDAO();
            productoDAO.actualizarProducto(productoTO);
        }
    }
}
