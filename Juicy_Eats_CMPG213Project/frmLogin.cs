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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader myReader;

        private static string encryptPass = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-DOH888P;Initial Catalog=JuicyEats;Integrated Security=True";
            con = new SqlConnection(conString);
        }

        public static string decryptPassword(string encodedData)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(encodedData);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        private static string encryptPassword(string pass)
        {
            try
            {
                byte[] encData_byte = new byte[pass.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(pass);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                if (txtNum.Text != "" && txtSurname.Text != "")
                {

                    /* encryptPass = encryptPassword(txtSurname.Text);
                     string userNameManager = txtNum.Text.ToLower();

                     string query = "SELECT * from EMPLOYEE WHERE Employee_Type ='" + txtNum.Text + "' AND Employee_ID ='" + encryptPass + "'";
                     if (txtSurname.Text == decryptPassword(encryptPass))
                     {


                         cmd = new SqlCommand(query, con);
                         myReader = cmd.ExecuteReader();
                         if (myReader.HasRows)
                         {
                             frmManager ManagerP = new frmManager();
                             if (userNameManager == "Manager"&& decryptPassword(encryptPass) == "Manager")
                             {
                                 //employeesTooLStripMenuItem.Enabled = true;
                                 //ManagerP.menuStrip1.Add(ManagerP.Employees);
                                 //ManagerP..TabPages.Add(ManagerP.Inventory);
                                 //ManagerP..TabPages.Add(ManagerP.Supplier);
                                 //ManagerP..TabPages.Add(ManagerP.Reorts);
                                 //ManagerP..TabPages.Add(ManagerP.Order); //show admin tab when the admin log in
                             }


                             ManagerP.Show(); //show manager page
                             myReader.Close();
                             this.Hide();

                         }
                         else
                         {
                             MessageBox.Show("Data not found", "Information");
                         }

                 }
                 else
                 {
                     MessageBox.Show("Username or Password is empty", "Information");
                 }*/

                    frmManager ManagerP = new frmManager();
                    ManagerP.Show(); //show manager page
                    //myReader.Close();
                    this.Hide();

                    con.Close();


                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
