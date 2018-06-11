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
        }
    }
