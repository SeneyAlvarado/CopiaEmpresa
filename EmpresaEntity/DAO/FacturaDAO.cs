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
    }
}
