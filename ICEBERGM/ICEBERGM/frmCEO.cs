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
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace ICEBERGM
{
    public partial class frmCEO : Form
    {
        public frmCEO()
        {
            InitializeComponent();
        }

        private void frmCEO_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome to ICEBERG-M " + PubClass.strSessionName + "!";
            lblWindow.Text = PubClass.strRole + "'s Menu";
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords(PubClass.strLocation);   
        }

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            try
            {
                string test = "select * from Messages";
                string select = "SELECT [Sender], [Body], [TimeStamp] FROM [Messages] Where Recipient= '" + PubClass.strUsername + "' or Sender= '" + PubClass.strUsername + "' Order by TimeStamp DESC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, PubClass.con); //c.con is the connection string
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                // you can make it grid readonly.
                dataGridView1.ReadOnly = true;
                // finally bind the data to the grid
                dataGridView1.DataSource = bindingSource1;
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string strChat = txtChatInput.Text.Trim();
            string strRecipient = txtChatUser.Text;
            DateTime date = new DateTime();
            try
            {
                string test = "select * from Messages";
                string insert = "SET IDENTITY_INSERT [Messages] ON Declare @int as int = (select MAX([IDENTITY]) from [Messages]) + 1 Insert into [Messages]([Sender],[Recipient],[TimeStamp],[Body]) Values ('" + PubClass.strUsername + "','" + strRecipient + "','" + date.TimeOfDay.ToString() + "','" + strChat + "') SET IDENTITY_INSERT [Messages] OFF SELECT [Sender], [Body], [TimeStamp] FROM [Messages] Where Recipient= '" + PubClass.strUsername + "' or Sender= '" + PubClass.strUsername + "' Order by TimeStamp DESC";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(insert, PubClass.con); //c.con is the connection string
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                // you can make it grid readonly.
                dataGridView1.ReadOnly = true;
                // finally bind the data to the grid
                dataGridView1.DataSource = bindingSource1;
            }
            catch (SqlException SqlEx)
            {
                MessageBox.Show(SqlEx.Message);
            }
        }
    }
}
