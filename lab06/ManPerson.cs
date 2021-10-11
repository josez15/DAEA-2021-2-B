using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab06
{
    public partial class ManPerson : Form
        {
        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();
        public ManPerson()
        {
            InitializeComponent();
        }

        private void ManPerson_Load(object sender, EventArgs e)
        {
            String str = "Server=JOSE-ZEA\\LOCAL;DataBase=School;Integrated Security=true;";
            con = new SqlConnection(str);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            String sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Person");

            tablePerson = ds.Tables["Person"];
            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("InsertPerson", con);

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtLastName.Text;
            fila["FirstName"] = txtFirstName.Text;
            if (txtHireDate.Checked) fila["HireDate"] = txtHireDate.Text;
            else fila["HireDate"] = DBNull.Value;
            if (txtEnrollmentDate.Checked) fila["EnrollmentDate"] = txtEnrollmentDate.Text;
            else fila["EnrollmentDate"] = DBNull.Value;
            //fila["HireDate"] = txtHireDate.Text;
            //fila["EnrollmentDate"] = txtEnrollmentDate.Text;

            tablePerson.Rows.Add(fila);

            adapter.Update(tablePerson);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdatePerson", con);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar, 50, "PersonID");
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["FirstName"] = txtFirstName.Text;
            fila[0]["HireDate"] = txtHireDate.Text;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Text;

            adapter.Update(tablePerson);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", con);
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");

            tablePerson.Rows.Remove(fila[0]);

            adapter.Update(tablePerson);
        }

        private void btnOrnApellido_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.Sort = "LastName ASC";
            dgvListado.DataSource = dv;
        }

       

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();

                txtLastName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();

                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                
                string hireDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hireDate))
                    txtHireDate.Checked = false;
                else
                    txtHireDate.Text = hireDate;

                string enrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(enrollmentDate))
                    txtEnrollmentDate.Checked = false;
                else
                    txtEnrollmentDate.Text = enrollmentDate;




            }
        }

        private void btnBuscarxNombre_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "FirstName = '" + txtFirstName.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnBuscarxApellido_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "LastName = '" + txtLastName.Text + "'";
            dgvListado.DataSource = dv;
        }

        private void btnBuscarxCodigo_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
            dgvListado.DataSource = dv;
        }

       
    }
}
