using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;
using System.Data;

namespace BL
{
    public class ClienteBL
    {

        public String Cedula;
        public String Nombre;
        public String Apellido;
        public String Correo;
        public int Telefono;
        public ClienteDAO clienteDao;

        public void getClients(DataTable tableClients)
        {
            clienteDao = new ClienteDAO();
            tableClients.Rows.Clear();

            foreach (TO.ClienteTO item in clienteDao.getClients())
            {
                tableClients.Rows.Add(item.Cedula, item.Nombre, item.Apellido
                    , item.Correo, item.Telefono);
            }
        }

        public void agregarCliente(String cedula, String nombre, String apellido,
            String correo, int telefono)
        {

            try
            {
                this.Cedula = cedula;
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Correo = correo;
                this.Telefono = telefono;

                ClienteTO toCliente = new ClienteTO(Cedula, Nombre, Apellido, Correo, Telefono);

                clienteDao = new ClienteDAO();
                clienteDao.insertarCliente(toCliente);
            }
            catch (Exception)
            {
                throw;
            }
            

        }

        public void buscarCliente(String cedula)
        {
            try
            {
                this.Cedula = cedula;

                ClienteTO clienteTO = new ClienteTO();
                clienteTO.Cedula = this.Cedula;

                clienteDao = new ClienteDAO();
                clienteDao.extraerCliente(clienteTO);

                this.Nombre = clienteTO.Nombre;
                this.Apellido = clienteTO.Apellido;
                this.Correo = clienteTO.Correo;
                this.Telefono = clienteTO.Telefono;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public void actualizarCliente(String cedula, String nombre, String apellido, 
            String correo, int telefono)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Telefono = telefono;

            ClienteTO clienteTO = new ClienteTO(cedula, nombre, apellido, correo, telefono);

            clienteDao = new ClienteDAO();
            clienteDao.actualizarCliente(clienteTO);
        }

        public void eliminarCliente(String cedula)
        {
            this.Cedula = cedula;

            ClienteTO clienteTO = new ClienteTO();
            clienteTO.Cedula = this.Cedula;

            try
            {
                clienteDao = new ClienteDAO();
                clienteDao.eliminarCliente(clienteTO);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
            
        }
    }
}
