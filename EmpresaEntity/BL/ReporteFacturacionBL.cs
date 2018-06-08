using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class ReporteFacturacionBL
    {
        public int Consecutivo;
        public ClienteBL Cliente;
        public List<FacturaBL> Historico;
        public double Total;
    }
}
