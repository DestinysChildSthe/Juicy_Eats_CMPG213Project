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
    public partial class frmDeleteSupplier : Form
    {
        public frmDeleteSupplier()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataSet ds;
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                string sqlDelete = "DELETE SUPPLIER WHERE Supplier_ID ='" + cmbSelect.Text;
                //string sqlDeleteAll = "DELETE * FROM SUPPLIER";
                cmd = new SqlCommand();

                adapt.DeleteCommand = new SqlCommand(sqlDelete, con);
                adapt.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Supplier Removed");

                cmd.Dispose();
                con.Close();
            }
            catch (Exception )
            {
                MessageBox.Show("Supplier is not deleted");
            }
        }

        private void frmDeleteSupplier_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-DOH888P;Initial Catalog=JuicyEats;Integrated Security=True";
            con = new SqlConnection(conString);
        }
    }
}
