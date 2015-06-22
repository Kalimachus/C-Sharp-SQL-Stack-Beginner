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
    public partial class frmPasswordRecovery : Form
    {
        public frmPasswordRecovery()
        {
            InitializeComponent();
        }
        //UI & UX related code
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        //user does two step validation to recover password
        private void btnRecover_Click_1(object sender, EventArgs e)
        {
            try
            {
                //clicking button will query user where there is a match between DOB and Favorite Acitivity
                DateTime dateTime = new DateTime();
                dateTime = dateTimePicker1.Value;
                string strFavoriteAct = txtFavActivity.Text;
                string Password = null;

                bool boolUserValidated = false;
                PubClass.con.Open();
                string sql = "select * from UserAccounts where DOB= '" + dateTime.ToShortDateString() + "' and SecAnswer = '"+strFavoriteAct+"'";
                SqlCommand cmd = new SqlCommand(sql, PubClass.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    boolUserValidated = true;
                    Password = dr[2] as string;
                }
                dr.Close();
                PubClass.con.Close();

                if (boolUserValidated == true)
                {
                    MessageBox.Show("Your password is: " + Password);
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
            }

            //if match is found, query will return password to display
        }

    }
}
