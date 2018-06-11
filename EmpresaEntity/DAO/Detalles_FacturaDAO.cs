using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
namespace DAO
{
   public class Detalles_FacturaDAO
    {
        private EmpresaEntities context;
        ProductoDAO productoDAO = new ProductoDAO();

        public void insertarDetalle(Detalles_FacturaTO detalleTO)
        {
            try
            {
                ProductoDAO productoDAO = new ProductoDAO();
                using (context = new EmpresaEntities())
                {
                    Detalle_Factura detalleDAO = new Detalle_Factura
                    {
                        Factura = detalleTO.Consecutivo_Factura,
                        Producto = detalleTO.Codigo_Producto,
                        Cantidad = detalleTO.Cantidad
                    };
                    
                    context.Detalle_Factura.Add(detalleDAO);
                    context.SaveChanges();
                    productoDAO.extraerProductoCantidad(detalleTO.Codigo_Producto, detalleTO.Cantidad);
                }
            }
            catch (Exception)
            {
                throw;
            }
           
            }

        public List<Detalles_FacturaTO> obtenerDetalles(Detalles_FacturaTO detallesTO)
        {
            List<Detalles_FacturaTO> lista = new List<Detalles_FacturaTO>();
            using (context = new EmpresaEntities())
            {
                var query = from detalle in context.Detalle_Factura
                            where detallesTO.Consecutivo_Factura == detalle.Factura
                            select detalle;

                
                Detalles_FacturaTO dTO;

                if (query != null)
                {
                    foreach (Detalle_Factura df in query)
                    {
                        dTO = new Detalles_FacturaTO();
                        dTO.Consecutivo_Factura = df.Factura;
                        dTO.Cantidad = df.Cantidad;
                        dTO.Codigo_Producto = df.Producto;
                        lista.Add(dTO);
                    }
                } else
                {
                    throw new Exception("No hay productos para mostrar de la factura");
                }
                
            }
            return lista;
        }
        }
    }
