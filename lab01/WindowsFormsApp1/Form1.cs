using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int num = 10001;
            string codigo = $"{num}";
            string nombre = txtNombre.Text;
            string dni = txtDNI.Text;
            string apellidos = txtApellidos.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string fecnac = dtpNac.Text;
            bool activo = cbxActivo.Checked;
            dgvUsuarios.Rows.Add(codigo, nombre, dni, apellidos, direccion, telefono, email, fecnac, activo);

        }
    }
}
