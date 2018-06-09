using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;

namespace DAO
{
    public class DAOHandler
    {
        private EmpresaEntities context;


        public List<TO.ClienteTO> getClients()
        {
            using (context = new EmpresaEntities())
            {

                var query = from clients in context.Clientes
                        select clients;

            List<ClienteTO> list = new List<ClienteTO>();
            ClienteTO clienteTO = new ClienteTO();
            foreach (Cliente client in query)
            {
                    clienteTO = new ClienteTO();
                    clienteTO.Nombre = client.Nombre;
                    clienteTO.Telefono = client.Telefono;
                clienteTO.Correo = client.Correo;
                clienteTO.Cedula = client.Cedula;
                clienteTO.Apellido = client.Apellido;
                list.Add(clienteTO);
            }

             
            return list;
        }
        }

        public void extraerCliente(ClienteTO clienteTO)
        {
            using (context = new EmpresaEntities())
            {
                var query = from clientes in context.Clientes
                            where clienteTO.Cedula == clientes.Cedula
                            select clientes;

                if (query != null)
                {
                    foreach (Cliente c in query)
                    {
                        clienteTO.Nombre = c.Nombre;
                        clienteTO.Apellido = c.Apellido;
                        clienteTO.Correo = c.Correo;
                        clienteTO.Telefono = c.Telefono;
                    }
                }
            }
        }

        public void insertarCliente(ClienteTO cliente)
        {
            using (context = new EmpresaEntities())
            {
                Cliente nuevoCliente = new Cliente
                {
                    Cedula = cliente.Cedula,
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Correo = cliente.Correo,
                    Telefono = cliente.Telefono
                };
                context.Clientes.Add(nuevoCliente);
                context.SaveChanges();
            }
        }

        public void insertarFactura(FacturaTO facturaTo)
        {
            using (context = new EmpresaEntities())
            {
                Factura facturaDAO = new Factura
                {

                    Cliente = facturaTo.Cliente,
                    Fecha_Hora = facturaTo.FechaHora,
                    Total = facturaTo.Total
                };
                context.Facturas.Add(facturaDAO);
                context.SaveChanges();
            }
        }

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
                context.Productoes.Add(productoDAO);
                context.SaveChanges();
            }
        }

        public List<TO.FacturaTO> getFacturas()
        {
            using (context = new EmpresaEntities())
            {

                var query = from factura in context.Facturas
                            select factura;

                List<FacturaTO> list = new List<FacturaTO>();
                FacturaTO facturaTo = new FacturaTO();
                foreach (Factura factura in query)
                {
                    facturaTo = new FacturaTO();
                    facturaTo.Cliente = factura.Cliente;
                    facturaTo.Consecutivo = factura.Consecutivo;
                    facturaTo.FechaHora = factura.Fecha_Hora;
                    facturaTo.Total = factura.Total;
                    list.Add(facturaTo);
                }
                return list;
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

    }
}
