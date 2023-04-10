using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WinApplication
{

    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserid.Text != "" && txtPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                //string Query = "Select * from Tblusers Where Userid = @Userid and Password = @Password";
                string Query = "GEN_tblUsersSP @nType = 0 ,@nsType = 0 ,@Userid= @Userid,@Password= @Password";


                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Userid", txtUserid.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == true)
                {
                    MessageBox.Show("login successfully", "successfully",MessageBoxButtons.OK);
                    this.Hide();
                    Menu Menu = new Menu();
                    Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("login failed", "failed", MessageBoxButtons.OK);
                }
                con.Close();
            }
            else 
            {
                MessageBox.Show("please uerid and Password type");
            }

        }

        private void txtUserid_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserid.Text) == true) 
            {
                errorProvider1.SetError(this.txtUserid, "Muhammad usman");
            }
            else
            {
                errorProvider1.Clear();

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider2.SetError(this.txtPassword, "Muhammad usman");
            }
            else
            {
                errorProvider2.Clear();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
