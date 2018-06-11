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
        public int Consecutivo { get; set; }
        public String Cliente;
        public List<ProductoBL> ListaProductos;
        public double SubTotal;
        public DateTime FechaHora;
        public double Total;
        public FacturaDAO facturaDAO = new FacturaDAO();

        public FacturaBL()
        {
            ListaProductos = new List<ProductoBL>();
        }

        public void getFacturas(DataTable tableFacturas)
        {
            tableFacturas.Rows.Clear();

            foreach (FacturaTO item in facturaDAO.getFacturas())
            {
                tableFacturas.Rows.Add(item.Consecutivo, item.FechaHora, item.Cliente
                    , item.Total);
            }
        }

        public void agregarFactura(String cliente)
        {
            this.Cliente = cliente;

            FacturaTO facturaTO = new FacturaTO();
            facturaTO.Cliente = this.Cliente;

            facturaDAO = new FacturaDAO();
            facturaDAO.insertarFactura(facturaTO);
            this.Consecutivo = facturaTO.Consecutivo;
        }

        public void actualizarTotalFactura(double total)
        {
            this.Total = this.Total + total;

            FacturaTO facturaTO = new FacturaTO();
            facturaTO.Consecutivo = this.Consecutivo;
            facturaTO.Total = this.Total;

            facturaDAO = new FacturaDAO();
            facturaDAO.actualizarTotalFactura(facturaTO);
        }

        public void buscarFactura(String consecutivo)
        {
            try
            {
                this.Consecutivo = int.Parse(consecutivo);

                FacturaTO facturaTO = new FacturaTO();
                facturaTO.Consecutivo = this.Consecutivo;

                facturaDAO = new FacturaDAO();
                facturaDAO.extraerFactura(facturaTO);

                this.Cliente = facturaTO.Cliente;
                this.FechaHora = facturaTO.FechaHora;
                this.Total = facturaTO.Total;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
