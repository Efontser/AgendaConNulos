﻿using Entidades;
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
using System.Windows.Forms.VisualStyles;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        private GestionAgenda gst;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = Program.gestion.ContactosOrdenados(out String error);
            if (error != "")
            {
                lblTexto.Text = error;
                return;
            }
            else
            {
                lblTexto.Text = "Todos los contactos ordenados";
            }
        }

        private void btnContactoPorTelefono_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            if (String.IsNullOrEmpty(txtTel.Text))
            {
                lblTexto.Text = "ERROR: Teléfono está vacío o no es válido";
                return;
            }
            try
            {
                int telefonoBuscado = int.Parse(txtTel.Text);
                List<Contacto> contactos = gst.ContactosTelefono(txtTel.Text, out string err);
                if (!String.IsNullOrEmpty(err))
                {
                    lblTexto.Text = err;
                    return;
                }
                if (contactos == null)
                {
                    lblTexto.Text = "No existe ningún contacto con teléfono: " + telefonoBuscado;
                    return;
                }
                if (contactos.Count <= 0)
                {
                    lblTexto.Text = "No existe ningún contacto con teléfono: " + telefonoBuscado;
                    return;
                }
                lblTexto.Text = "Contactos del teléfono: " + telefonoBuscado;
                dgvDatos.DataSource = contactos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gst = new GestionAgenda(out String err);
            if (!String.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
