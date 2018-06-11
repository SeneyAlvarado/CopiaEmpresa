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

        public void reporte(ReporteFacturacionTO reporteTO)
        {
            using (context = new EmpresaEntities())
            {
                /*saca todas las facturas de un cliente*/
                var query = from reporte in context.Facturas
                            where reporteTO.Cliente == reporte.Cliente
                            select reporte;
        }
    }
}
