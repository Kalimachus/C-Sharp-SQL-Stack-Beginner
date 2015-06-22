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

namespace ICEBERGM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //UI and UX related code
        #region UI and UX frmLogin
        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Focus();
        } //focus on load
        private void txtUsernameInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsernameInput.Text == "   Username")
            {
                txtUsernameInput.Text = string.Empty;
            }

        }//txtbox text change upon click
        private void txtUsernameInput_Leave(object sender, EventArgs e)
        {
            if (txtUsernameInput.Text == string.Empty)
            {
                txtUsernameInput.Text = "   Username";
            }
        }//restore txt default if entry is meaningless
        private void txtPasswordInput_MouseClick(object sender, MouseEventArgs e)
        {
            txtPasswordInput.UseSystemPasswordChar = true;

            if (txtPasswordInput.Text == "   Password")
            {
                txtPasswordInput.Text = string.Empty;  
            }
        }//txtbox text change upon click
        private void txtPasswordInput_Leave(object sender, EventArgs e)
        {
            if (txtPasswordInput.Text == string.Empty)
            {
                txtPasswordInput.UseSystemPasswordChar = false;
                txtPasswordInput.Text = "   Password";
            }
        }//restore txt default if entry is meaningless
        private void lblForgotUser_MouseHover(object sender, EventArgs e)
        {
            this.lblForgotUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }//flicker effects on mouseover
        private void lblForgotUser_MouseLeave(object sender, EventArgs e)
        {
            this.lblForgotUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void lblForgotPass_MouseHover(object sender, EventArgs e)
        {
            this.lblForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }//flick effect on mouseover
        private void lblForgotPass_MouseLeave(object sender, EventArgs e)
        {
            this.lblForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void lblRegisterUser_MouseHover(object sender, EventArgs e)
        {
            this.lblRegisterUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lblRegisterUser_MouseLeave(object sender, EventArgs e)
        {
            this.lblRegisterUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void btnExit2_Click(object sender, EventArgs e)
        {
            this.Close();
        } //close buttons
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void lblForgotUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your username is your 'Firstname.MI.Lastname' ie Mitch.L.Hedberg");
        }
        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            frmPasswordRecovery frmPassRec = new frmPasswordRecovery();
            frmPassRec.Show();
            this.Hide();
        }

        private void lblRegisterUser_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                //Validate user's login credentials
                string strUser = txtUsernameInput.Text;
                string strPass = txtPasswordInput.Text;
                string strSession, strUserName = null, strRole = null,
                        strSessionName = null;
                Int32 int32LocationID = 0;
                bool boolValidUser = false;
                PubClass.con.Open();
                string sql = "select * from UserAccounts where Username= '" + strUser + "' and Password = '" + strPass + "'";
                SqlCommand cmd = new SqlCommand(sql, PubClass.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strSession = dr[1] as string;
                    strUserName = dr[1] as string;
                    strRole = dr[3] as string;
                    int32LocationID = dr.GetInt32(0);
                    boolValidUser = true;
                    int index = strSession.IndexOf(".");
                    if (index > 0)
                    {
                        strSessionName = strSession.Substring(0, index);
                    }
                }
                dr.Close();
                PubClass.con.Close();
                PubClass.strLocation = LocateIDtoString(int32LocationID);
                PubClass.strRole = strRole;
                PubClass.strSessionName = strSessionName;
                PubClass.strUsername = strUserName;
               

                if (boolValidUser == true)
                {

                    switch (PubClass.strRole)
                    {
                        case "CEO":
                            frmCEO frmCEO = new frmCEO();
                            frmCEO.Show();
                            this.Hide();
                            break;
                        case "Admin":
                            frmAdmin frmAdmin = new frmAdmin();
                            frmAdmin.Show();
                            this.Hide();
                            break;
                        case "Seller":
                            frmSeller frmSeller = new frmSeller();
                            frmSeller.Show();
                            this.Hide();
                            break;
                        case "Supply":
                            frmSupply frmSupply = new frmSupply();
                            frmSupply.Show();
                            this.Hide();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username / Password");
                }

            }

            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
            }

        }

        private string LocateIDtoString(Int32 int32LocationID)
        {
            switch (int32LocationID)
            {
                case 1:
                    PubClass.strLocation = "Austin,TX, USA";
                    break;
                case 2:
                    PubClass.strLocation = "Dallas,TX, USA";
                    break;
                case 3:
                    PubClass.strLocation = "Houston,TX, USA";
                    break;
                case 4:
                    PubClass.strLocation = "San Antonio,TX, USA";
                    break;
                case 5:
                    PubClass.strLocation = "Los Angeles, CA, USA";
                    break;
                case 6:
                    PubClass.strLocation = "San Francisco, CA, USA";
                    break;
                case 7:
                    PubClass.strLocation = "Ventura, CA, USA";
                    break;
                case 8:
                    PubClass.strLocation = "Sacramento, CA, USA";
                    break;
                case 9:
                    PubClass.strLocation = "San Diego, CA, USA";
                    break;
            }
            return PubClass.strLocation;
        }


    }
}
