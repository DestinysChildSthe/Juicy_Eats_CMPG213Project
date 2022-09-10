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

namespace Juicy_Eats_CMPG213Project
{
    public partial class frmFireEmployees : Form
    {
        public frmFireEmployees()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataSet ds;

        private void frmFireEmployees_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-DOH888P;Initial Catalog=JuicyEats;Integrated Security=True";
            con = new SqlConnection(conString);
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                string sqlDelete = "DELETE EMPLOYEE WHERE Employee_FName AND Employee_LName ='" + cmbSelect.Text;
                //string sqlDeleteAll = "DELETE * FROM Employee";
                cmd = new SqlCommand();

                adapt.DeleteCommand = new SqlCommand(sqlDelete, con);
                adapt.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Employee Removed");

                cmd.Dispose();
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Employee is not deleted");
            }
        }
    }
}
