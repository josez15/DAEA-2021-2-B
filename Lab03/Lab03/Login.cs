using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Login : Form
    {
        SqlConnection conn;

        public Login(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario_nombre FROM tbl_usuario WHERE usuario_nombre='" + txtUser.Text + "' AND usuario_password='"+txtPss.Text + "'", conn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if(dr.Read())
                        {
                            MessageBox.Show("Login exitoso");
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }
    }
}
