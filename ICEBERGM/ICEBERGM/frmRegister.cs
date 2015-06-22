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
    public partial class frmRegister : Form
    {
        bool KeyRegisterFlag,
                AllFieldsFlag = false;
        string strRole;
        string[] strAllEntries = new string[8];
        

        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            btnSubmit.Focus();
        }
        private void txtRegKey_Enter(object sender, EventArgs e)
        {
            if (txtRegKey.Text == "XXXX-XXXX-XXXX-XXXX")
            {
                txtRegKey.Text = string.Empty;
            }
        }
        private void txtRegKey_Leave(object sender, EventArgs e)
        {
            if (txtRegKey.Text == string.Empty)
            {
                txtRegKey.Text = "XXXX-XXXX-XXXX-XXXX";
            }
        }

        private bool ValidateEntries( bool AllFieldsFlag)
        {
            AllFieldsFlag = true;
            foreach (Control controls in this.Controls)
            {   

                if (controls is TextBox)
                {
                    TextBox textbox = controls as TextBox;
                    if (string.IsNullOrWhiteSpace(textbox.Text) && textbox.Name != "txtMidInit")
                    {   
                        AllFieldsFlag = false;
                    }
                }
                if (controls is ComboBox)
                {
                    ComboBox combobox = controls as ComboBox;
                    if (combobox.Text == "--")
                    {
                        AllFieldsFlag = false;
                    }
                }
            }
            return AllFieldsFlag;
        }

        private bool ValidateKeyAndLocation(string strRegistryKey)
        {
            //for demo purposes: regis key: AJ26-4566-7224-XK15
            try
            {
                PubClass.con.Open();
                string sql = "select * from RegistrationKeys where RegisterKey= '"+ strRegistryKey +"' and LocationID = '" + strAllEntries[7] + "'";
                SqlCommand cmd = new SqlCommand(sql, PubClass.con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KeyRegisterFlag = true;
                    strRole = dr[3] as string;
                    MessageBox.Show("Registry Key Matched");
                }
                dr.Close();
                PubClass.con.Close();
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
            }
            return KeyRegisterFlag;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {   
            string strRegistryKey = txtRegKey.Text;

            AllFieldsFlag = ValidateEntries(AllFieldsFlag);
            
            if (AllFieldsFlag == true)
                {
                    strAllEntries = AssignTextToValues(strAllEntries);
                    //foreach (string str in strAllEntries)
                    //{
                    //    MessageBox.Show(str);
                    //}

                    KeyRegisterFlag = ValidateKeyAndLocation(strRegistryKey);

                    if (KeyRegisterFlag == true)
                    {
                        DateTime date = new DateTime();
                        date = dateTimePicker1.Value;
                        PubClass.con.Open();
                        string sql = "SET IDENTITY_INSERT [UserAccounts] ON Declare @int as int = (select MAX([IDENTITY]) from [UserAccounts]) + 1 Insert INTO UserAccounts ([Identity],Username,[Password],[Role],[Address], City, [State], [Zipcode], [DOB], [SecAnswer], [LocationID]) Values (@int,'" +
                                                    strAllEntries[0] + "','" + strAllEntries[1] + "','"+strRole+"','" + strAllEntries[2]+"','"+ strAllEntries[3]+"','" + strAllEntries[4] +"',"+ strAllEntries[5]+",'"+ date.ToShortDateString()+ "','"+
                                                    strAllEntries[6] + "'," + strAllEntries[7] + ") SET IDENTITY_INSERT [UserAccounts] OFF";
                        SqlCommand cmd = new SqlCommand(sql, PubClass.con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            MessageBox.Show("Entry into table worked");
                        }
                        MessageBox.Show("Your login username is: " + strAllEntries[0] + Environment.NewLine +
                            "Your password is: " + strAllEntries[1], "Please Memorize or Write Your Login!");
                        dr.Close();
                        PubClass.con.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration Key Failed");
                    }
                }
            else
            {
                MessageBox.Show("Please fill out the entire form.");
            }
        }
        private string[] AssignTextToValues(string[] strAllEntries)
        {
            int intCorpLoc;
            if (string.IsNullOrWhiteSpace(txtMidInit.Text))
            {
                strAllEntries[0] = txtFirst.Text.Trim() + "." + txtLast.Text.Trim();
            }
            else
            {
                strAllEntries[0] = txtFirst.Text.Trim() + "." + txtMidInit.Text.Trim() + "." + txtLast.Text.Trim();
            }
            strAllEntries[1] = txtPassword.Text;
            strAllEntries[2] = txtAddress.Text.Trim();
            strAllEntries[3] = txtCity.Text.Trim();
            strAllEntries[4] = cbStates.Text;
            strAllEntries[5] = txtZip.Text.Trim();
            strAllEntries[6] = txtSecAnswer.Text.Trim();
            intCorpLoc = (cbCorpLocations.SelectedIndex) + 1;
            string strTemp = intCorpLoc.ToString();
            strAllEntries[7] = strTemp;

            return strAllEntries;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control controls in this.Controls)
            {
                if (controls is TextBox)
                {   
                    TextBox textbox = controls as TextBox;
                    if (textbox.Name == "txtRegKey")
                    {
                        textbox.Text = "XXXX-XXXX-XXXX-XXXX";
                    }
                    else
                    {
                        textbox.Text = string.Empty;
                    }
                }
                if (controls is ComboBox)
                {
                    ComboBox combobox = controls as ComboBox;
                    combobox.SelectedItem = null;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }
        

     }
        


 }
