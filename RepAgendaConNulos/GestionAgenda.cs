using Entidades;
using Servidores;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepAgendaConNulos
{
    public class GestionAgenda
    {
        AgendaEntities miAgendaEntities;
        public GestionAgenda( out String error) //out error
        {
            error = "";
            try
            {
                String miServidor = Servidor.ServidorActual();
                String cadenaConexion = $@"metadata=res://*/AgendaBD.csdl|res://*/AgendaBD.ssdl|res://*/AgendaBD.msl;
                           provider=System.Data.SqlClient;
                           provider connection string='data source={miServidor};
                           initial catalog=Agenda;
                           integrated security=True;
                           trustservercertificate=True;
                           MultipleActiveResultSets=True;
                           App=EntityFramework'";
                miAgendaEntities = new AgendaEntities(cadenaConexion);
            }
            catch (Exception e)
            {
                error = e.Message.ToString();
            }
            
        }
        public List<Contacto> ContactosOrdenados(out String error)
        {
            error = "";
            try
            {
               return miAgendaEntities.Contactos.OrderBy(contacto => contacto.Nombre).ToList();
            }
            catch (Exception e)
            {

                error = e.Message.ToString();
                return null;
            }
        }
        public List<Contacto> ContactosTelefono(string numero, out String error)
        {
            error = "";
            //Toda la parte comentada es la versión de buscar el primer o único contacto que tenga el teléfono buscado
            //try
            //{
            //    int idContactoBuscado = miAgendaEntities.Telefonos.Where(tel => tel.Numero.Equals(numero, StringComparison.OrdinalIgnoreCase)).Select(tel => tel.IdContacto).FirstOrDefault();
            //    miAgendaEntities.Telefonos.Where(tel => tel.Numero == numero).ToList();
            //    if (idContactoBuscado == 0)
            //    {
            //        return null;
            //    }
            //    return miAgendaEntities.Contactos.Where(contact => contact.IdContacto == idContactoBuscado).ToList();
            //}
            //catch (Exception e)
            //{
            //    error = e.Message.ToString();
            //    return null;
            //}
            try
            {
                var prueba = miAgendaEntities.Telefonos.Where(tel => tel.Numero.Equals(numero, StringComparison.OrdinalIgnoreCase)).Select(tel => tel.IdContacto).ToList();
                if (prueba == null)
                {
                    error = "No existen contactos con el teléfono: " + numero;
                    return null;
                }
                List<Contacto> contactos = miAgendaEntities.Contactos.ToList();
                List<Contacto> contactosEncontrados = new List<Contacto>();
                foreach (var contact in contactos)
                {
                    if (prueba.Contains(contact.IdContacto))
                    {
                        contactosEncontrados.Add(contact);
                    }
                }
                if (contactosEncontrados == null)
                {
                    error = "No existen contactos con el teléfono: " + numero;
                    return null;
                }
                return contactosEncontrados.ToList();
            }
            catch (Exception e)
            {
                error = e.Message.ToString();
                return null;
            }
        }
        }
    }
