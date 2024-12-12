using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepAgendaConNulos;

namespace CapaPresentacion
{
    public static class Program
    {
        public static GestionAgenda gestion;
      
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gestion = new GestionAgenda(out string error);
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }
            Application.Run(new Form1());
        }
    }
}
