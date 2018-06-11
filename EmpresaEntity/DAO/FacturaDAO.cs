using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
using System.Data.Entity.Infrastructure;

namespace DAO
{

    public class FacturaDAO
    {

        private EmpresaEntities context;


        public void insertarFactura(FacturaTO facturaTo)
        {
            using (context = new EmpresaEntities())
            {
                var dateQuery = context.Database.SqlQuery<DateTime>("SELECT getdate()");
                DateTime serverDate = dateQuery.AsEnumerable().First();

                Factura facturaDAO = new Factura
                {

                    Cliente = facturaTo.Cliente,
                    Fecha_Hora = serverDate,
                    Total = 0
                };
                context.Facturas.Add(facturaDAO);
                context.SaveChanges();

                var query = from factura in context.Facturas
                            select factura;

                List<FacturaTO> list = new List<FacturaTO>();

                foreach (Factura factura in query) { 
                    facturaTo.Consecutivo = factura.Consecutivo;
                }

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

        public void actualizarTotalFactura(FacturaTO facturaTO)
        {
            context = new EmpresaEntities();

            Factura factura = (from facturas in context.Facturas
                               where facturas.Consecutivo == facturaTO.Consecutivo
                               select facturas).First();

            factura.Total = facturaTO.Total;
            context.SaveChanges();
        }

        public void extraerFactura(FacturaTO facturaTO)
        {
            Boolean error = true;

            using (context = new EmpresaEntities())
            {
                var query = from facturas in context.Facturas
                            where facturaTO.Consecutivo == facturas.Consecutivo
                            select facturas;

                if (query != null)
                {
                    foreach (Factura c in query)
                    {
                        error = false;
                        facturaTO.Consecutivo = c.Consecutivo;
                        facturaTO.Cliente = c.Cliente;
                        facturaTO.FechaHora = c.Fecha_Hora;
                        facturaTO.Total = c.Total;
                    }
                }
                if (error)
                {
                    throw new DbUpdateException();
                }
            }
        }

    }


}
