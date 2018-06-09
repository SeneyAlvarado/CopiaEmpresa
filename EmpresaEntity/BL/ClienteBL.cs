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
        public DAOHandler dao;

        public void getClients(DataTable tableClients)
        {
            dao = new DAOHandler();
            tableClients.Rows.Clear();

            foreach (TO.ClienteTO item in dao.getClients())
            {
                tableClients.Rows.Add(item.Cedula, item.Nombre, item.Apellido
                    , item.Correo, item.Telefono);
            }
        }

        public void agregarCliente(String cedula, String nombre, String apellido,
            String correo, int telefono)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.Telefono = telefono;

            ClienteTO toCliente = new ClienteTO(Cedula, Nombre, Apellido, Correo, Telefono);

            dao = new DAOHandler();
            dao.insertarCliente(toCliente);

        }

        public void buscarCliente(String cedula)
        {
            this.Cedula = cedula;

            ClienteTO clienteTO = new ClienteTO();
            clienteTO.Cedula = this.Cedula;

            dao = new DAOHandler();
            dao.extraerCliente(clienteTO);

            this.Nombre = clienteTO.Nombre;
            this.Apellido = clienteTO.Apellido;
            this.Correo = clienteTO.Correo;
            this.Telefono = clienteTO.Telefono;
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

            dao = new DAOHandler();
            dao.actualizarCliente(clienteTO);
        }
    }
}
