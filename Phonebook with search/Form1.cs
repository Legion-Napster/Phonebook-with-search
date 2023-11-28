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

namespace Phonebook_with_search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to update this person", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE tblPersonalContact SET " +
                        "First_Name = '" + txtFname.Text.Trim() + "'," +
                        "Last_Name = '" + txtLname.Text.Trim() + "'," +
                        "Company = '" + txtcompany.Text.Trim() + "',"+
                        "JobRole = '" + txtjobrole.Text.Trim() + "',"+
                        "Email = '" + txtEmail.Text.Trim() + "',"+
                        "Mobile No1 = '" + TxtMNo1.Text + "'," +
                        "Mobile No2 = '" + TxtMNo2.Text + "'," +
                        "StreetName  = '" + txtstreetname.Text + "'," +
                        "Address = '" + Txtaddress.Text + "'," +
                        "Address = '" + Txtaddress.Text.Trim() + "'," +
                       
                        "ContactType = '" + cmbContactType.Text + "'," +
                        "Reg_Date = '" + dtpRegDate.Value.ToShortDateString() + "' " +
                        "WHERE Per_ContactID = " + id;
                    myCon.Open();
                    SqlCommand cmd = new SqlCommand(qry, myCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Update Operation");
                    btnNew.PerformClick();
                    myFillGridDetail();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myCon.Close();
            }
        }
    }
}
