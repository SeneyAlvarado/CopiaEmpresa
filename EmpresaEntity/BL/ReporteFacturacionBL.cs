using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
using DAO;

namespace BL
{
    public class ReporteFacturacionBL
    {
        public int Consecutivo;
        public String Cliente;
        public List<FacturaBL> Historico;
        public String FechaInicio;
        public String FechaFin;
        public double Total;

        public void historico(String cedula, String fechaInicio, String fechaFin)
        {
            this.Cliente = cedula;
            this.FechaFin = fechaFin;
            this.FechaInicio = fechaInicio;

            

        }
    }
}
