using RepAgendaConNulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = Program.gestion.ContactosOrdenados(out String error);
            if (error != "") {
                lblTexto.Text = error;
                return;
            }
            else
            {
                lblTexto.Text = "Todos los contactos ordenados";
            }
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            var error = "";
            dgvDatos.DataSource = Program.gestion.ContactoPorId(out error,txtid.Text);
            if (error != "")
            {
                lblTexto.Text = error;
            }
        }
    }
}
