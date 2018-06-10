using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;
using System.Data;

namespace BL
{
    public class FacturaBL
    {
        public int Consecutivo;
        public String Cliente;
        public ProductoBL Producto;
        public double SubTotal;
        public DateTime FechaHora;
        public double Total;
        public FacturaDAO dacturaDao = new FacturaDAO();


        public void getFacturas(DataTable tableFacturas)
        {
            tableFacturas.Rows.Clear();

            foreach (FacturaTO item in dacturaDao.getFacturas())
            {
                tableFacturas.Rows.Add(item.Consecutivo, item.FechaHora, item.Cliente
                    , item.Total);
            }
        }

        public void agregarFactura(DateTime FechaHora, String cliente, float total)
        {
            this.FechaHora = FechaHora;
            this.Cliente = cliente;
            this.Total = total;

            FacturaTO facturaTO = new FacturaTO();
            facturaTO.FechaHora = this.FechaHora;
            facturaTO.Cliente = this.Cliente;
            facturaTO.Total = this.Total;

            dacturaDao = new FacturaDAO();
            dacturaDao.insertarFactura(facturaTO);
        }
    }
}
