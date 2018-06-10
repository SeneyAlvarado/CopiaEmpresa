using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TO;
using System.Data.Entity.Infrastructure;

namespace DAO
{
    public class ClienteDAO
    {

        private EmpresaEntities context;

        /*-----------CLIENTES-----------*/
        public List<TO.ClienteTO> getClients()
        {
            using (context = new EmpresaEntities())
            {

                var query = from clients in context.Clientes
                            select clients;

                List<ClienteTO> list = new List<ClienteTO>();
                ClienteTO clienteTO = new ClienteTO();
                foreach (Cliente client in query)
                {
                    clienteTO = new ClienteTO();
                    clienteTO.Nombre = client.Nombre;
                    clienteTO.Telefono = client.Telefono;
                    clienteTO.Correo = client.Correo;
                    clienteTO.Cedula = client.Cedula;
                    clienteTO.Apellido = client.Apellido;
                    list.Add(clienteTO);
                }


                return list;
            }
        }

        public void extraerCliente(ClienteTO clienteTO)
        {
            Boolean error = true;

            using (context = new EmpresaEntities())
            {
                var query = from clientes in context.Clientes
                            where clienteTO.Cedula == clientes.Cedula
                            select clientes;

                if (query != null)
                {
                    foreach (Cliente c in query)
                    {
                        error = false;
                        clienteTO.Nombre = c.Nombre;
                        clienteTO.Apellido = c.Apellido;
                        clienteTO.Correo = c.Correo;
                        clienteTO.Telefono = c.Telefono;
                    }
                }
                if (error)
                {
                    throw new DbUpdateException();
                }
            }
        }

        public void insertarCliente(ClienteTO cliente)
        {
            try
            {
                using (context = new EmpresaEntities())
                {
                    Cliente nuevoCliente = new Cliente
                    {
                        Cedula = cliente.Cedula,
                        Nombre = cliente.Nombre,
                        Apellido = cliente.Apellido,
                        Correo = cliente.Correo,
                        Telefono = cliente.Telefono
                    };
                    context.Clientes.Add(nuevoCliente);
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException)
            {

                throw new DbUpdateException();
            }
            
        }


        public void actualizarCliente(ClienteTO clienteTO)
        {
            context = new EmpresaEntities();

            Cliente cliente = (from clientes in context.Clientes
                               where clientes.Cedula == clienteTO.Cedula
                               select clientes).First();

            cliente.Nombre = clienteTO.Nombre;
            cliente.Apellido = clienteTO.Apellido;
            cliente.Correo = clienteTO.Correo;
            cliente.Telefono = clienteTO.Telefono;

            context.SaveChanges();
        }


        public void eliminarCliente(ClienteTO clienteTO)
        {
            context = new EmpresaEntities();
            Boolean error = true;
            var clienteEliminar =
    from cliente in context.Clientes
    where cliente.Cedula == clienteTO.Cedula
    select cliente;

            foreach (var clientDelete in clienteEliminar)
            {
                error = false;
                context.Clientes.Remove(clientDelete);
            }
            if (error)
            {
                throw new DbUpdateException();
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new Exception();
            }
        }
    }
}
