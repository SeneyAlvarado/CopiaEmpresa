using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
using DAO;
using System.Data;

namespace BL
{
    public class ReporteFacturacionBL
    {
        public int Consecutivo;
        public String Cliente;
        public String FechaInicio;
        public String FechaFin;
        public double Total;

        public List<FacturaBL> historico(String cedula, String fechaInicio, String fechaFin)
        {
            this.Cliente = cedula;
            this.FechaFin = fechaFin;
            this.FechaInicio = fechaInicio;

            ReporteFacturacionTO reporteTO = new ReporteFacturacionTO();
            reporteTO.Cliente = this.Cliente;
            reporteTO.FechaFin = this.FechaFin;
            reporteTO.FechaInicio = this.FechaInicio;

            ReporteFacturas reporte = new ReporteFacturas();
            List<FacturaTO> r= reporte.reporte(reporteTO);
            List<FacturaBL> facturas = new List<FacturaBL>();
            FacturaBL f;
            for (int i = 0; i < r.Count; i++)
            {
                f = new FacturaBL();
                f.Cliente = r[i].Cliente;
                f.Consecutivo = r[i].Consecutivo;
                f.FechaHora = r[i].FechaHora;
                f.Total = r[i].Total;
                facturas.Add(f);
            }

            return facturas;
        }

        public double totalFacturas(List<FacturaBL> lista)
        {
            double total = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                total += lista[i].Total;
            }
            return total;
        }
    }
}
