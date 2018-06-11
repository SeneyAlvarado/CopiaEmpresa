using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;

namespace DAO
{
    public class ReporteFacturas
    {
        private EmpresaEntities context;

        public List<FacturaTO> reporte(ReporteFacturacionTO reporteTO)
        {
            List<FacturaTO> listaFacturas = new List<FacturaTO>();
            DateTime fechaInicio = DateTime.Parse(reporteTO.FechaInicio);
            DateTime fechaFin = DateTime.Parse(reporteTO.FechaFin);
            using (context = new EmpresaEntities())
            {
                /*saca todas las facturas de un cliente*/
                var query = from reporte in context.Facturas
                            where (reporteTO.Cliente == reporte.Cliente) &&
                            (reporte.Fecha_Hora >= fechaInicio &&
                            reporte.Fecha_Hora <= fechaFin)
                            select reporte;

                FacturaTO facturaTO;
                foreach (Factura fac in query)
                {
                    facturaTO = new FacturaTO();
                    facturaTO.Cliente = fac.Cliente;
                    facturaTO.Consecutivo = fac.Consecutivo;
                    facturaTO.FechaHora = fac.Fecha_Hora;
                    facturaTO.Total = fac.Total;
                    listaFacturas.Add(facturaTO);
                }
            }

            return listaFacturas;
        }
    }
}
