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
            try
            {
                int idContactoBuscado = miAgendaEntities.Telefonos.Where(tel => tel.Numero.Equals(numero, StringComparison.OrdinalIgnoreCase)).Select(tel => tel.IdContacto).FirstOrDefault();
                miAgendaEntities.Telefonos.Where(tel => tel.Numero == numero).ToList();
                if (idContactoBuscado == 0)
                {
                    return null;
                }
                return miAgendaEntities.Contactos.Where(contact => contact.IdContacto == idContactoBuscado).ToList();
            }
            catch (Exception e)
            {
                error = e.Message.ToString();
                return null;
            }
            
        }
        }
    }
