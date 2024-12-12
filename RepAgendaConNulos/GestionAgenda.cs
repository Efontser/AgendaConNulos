using Entidades;
using System;
using System.Collections.Generic;
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
                miAgendaEntities = new AgendaEntities();
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
    }
}
