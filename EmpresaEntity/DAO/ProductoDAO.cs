using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
using System.Data.Entity.Infrastructure;

namespace DAO
{
    public class ProductoDAO
    {

        private EmpresaEntities context;

        public void insertarProducto(ProductoTO productoTO)
        {
            using (context = new EmpresaEntities())
            {
                Producto productoDAO = new Producto
                {

                    Cantidad_Disponible = productoTO.CantidadInventario,
                    Descripcion = productoTO.Descripcion,
                    ID_Producto = productoTO.Codigo,
                    Precio_Unidad = productoTO.PrecioVenta
                };

                try
                {
                    context.Productoes.Add(productoDAO);
                    context.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    throw new DbUpdateException();
                }
                
            }
        }

        public List<TO.ProductoTO> getProductos()
        {
            using (context = new EmpresaEntities())
            {

                var query = from producto in context.Productoes
                            select producto;

                List<ProductoTO> list = new List<ProductoTO>();
                ProductoTO productoTO = new ProductoTO();
                foreach (Producto producto in query)
                {
                    productoTO = new ProductoTO();
                    productoTO.CantidadInventario = producto.Cantidad_Disponible;
                    productoTO.Codigo = producto.ID_Producto;
                    productoTO.Descripcion = producto.Descripcion;
                    productoTO.PrecioVenta = producto.Precio_Unidad;
                    list.Add(productoTO);
                }
                return list;
            }
        }

        public void eliminarProducto(ProductoTO productoTO)
        {
            Boolean error = true;
            context = new EmpresaEntities();

            var productoEliminar =
    from producto in context.Productoes
    where producto.ID_Producto == productoTO.Codigo
    select producto;

            foreach (var productDelete in productoEliminar)
            {
                error = false;
                context.Productoes.Remove(productDelete);
            }

            if (error)
            {
                throw new DbUpdateException();
            }
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new Exception();
            }
        }

        public void actualizarProducto(ProductoTO productoTO)
        {
            context = new EmpresaEntities();

            Producto productoDAO = (from producto in context.Productoes
                                    where producto.ID_Producto == productoTO.Codigo
                                    select producto).First();

            productoDAO.Cantidad_Disponible = productoTO.CantidadInventario;
            productoDAO.Descripcion = productoTO.Descripcion;
            productoDAO.Precio_Unidad = productoTO.PrecioVenta;
            context.SaveChanges();
        }
        public void extraerProducto(ProductoTO productoTO)
        {
            Boolean error = true;
            using (context = new EmpresaEntities())
            {
                var query = from producto in context.Productoes
                            where productoTO.Codigo == producto.ID_Producto
                            select producto;


                if (query != null)
                {
                    foreach (Producto c in query)
                    {
                        error = false;
                        productoTO.CantidadInventario = c.Cantidad_Disponible;
                        productoTO.Descripcion = c.Descripcion;
                        productoTO.PrecioVenta = c.Precio_Unidad;
                    }
                }
                if (error)
                {
                    throw new DbUpdateException();
                }
            }
        }

        public void extraerProductoCantidad(int codigo, int cantidad)
        {
            Boolean error = true;
            using (context = new EmpresaEntities())
            {
                var query = from producto in context.Productoes
                            where codigo == producto.ID_Producto
                            select producto;


                if (query != null)
                {
                    foreach (Producto c in query)
                    {
                        if (c.Cantidad_Disponible >= cantidad)
                        {
                            actualizarCantidadProducto(codigo, c.Cantidad_Disponible - cantidad);
                            error = false;
                        }
                    }
                }
                if (error)
                {
                    throw new DbUpdateException();
                }
            }
        }

        public void actualizarCantidadProducto(int codigo, int cantidad)
        {
            context = new EmpresaEntities();
            Producto productoDAO = (from producto in context.Productoes
                                    where producto.ID_Producto == codigo
                                    select producto).First();

            productoDAO.Cantidad_Disponible = cantidad;
            context.SaveChanges();
        }


    }
}
