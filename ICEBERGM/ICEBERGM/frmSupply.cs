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
    public partial class frmSupply : Form
    {
        public frmSupply()
        {
            InitializeComponent();
        }

        private void frmSupply_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome to ICEBERG-M " + PubClass.strSessionName + "!";
            lblWindow.Text = PubClass.strRole + "'s Menu";
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords(PubClass.strLocation);   
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            try
            {
                string test = "select * from Messages";
                string select = "SELECT [Sender], [Body], [TimeStamp] FROM [Messages] Where Recipient= '" + PubClass.strUsername + "' Order by TimeStamp DESC";
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

        //private void cbTasks_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    foreach (Control controls in this.Controls)
        //    {
        //        if (controls.Tag == "InventoryGroup")
        //        {
        //            controls.Visible = false;
        //        }
                
        //    }

        //    int intTask;
        //    intTask = cbTasks.SelectedIndex;
        //    switch(intTask)
        //    {/// View inventory
        //        ///Add Inventory
        //        ///Distribute to Seller
        //        ///None
        //        case 0:
        //            lblUPC.Visible = true;
        //            txtUPC.Visible = true;
        //            btnInventory.Visible = true;
        //            break;
        //        case 1:
        //            lblUPC.Visible = true;
        //            lblQuant.Visible = true;
        //            lblBackOrder.Visible = true;
        //            txtUPC.Visible = true;
        //            txtQty.Visible = true;
        //            txtBackOrder.Visible = true;
        //            break;
        //        case 2:
        //            lblUPC.Visible = true;
        //            lblQuant.Visible = true;
        //            txtUPC.Visible = true;
        //            txtQty.Visible = true;
        //            btnTransfer.Visible = true;
        //            cbUsers.Visible = true;
        //            break;
        //        default:

        //            break;
        //    }
        //}

        private void cbTasks_DropDownClosed(object sender, EventArgs e)
        {
            {
                foreach (Control controls in this.Controls)
                {
                    if ((string)controls.Tag == "InventoryGroup")
                    {
                        controls.Visible = false;
                    }

                }

                int intTask;
                intTask = cbTasks.SelectedIndex;
                switch (intTask)
                {/// View inventory
                    ///Add Inventory
                    ///Distribute to Seller
                    ///None
                    case 0:
                        lblUPC.Visible = true;
                        txtUPC.Visible = true;
                        btnInventory.Visible = true;
                        break;
                    case 1:
                        lblUPC.Visible = true;
                        lblQuant.Visible = true;
                        lblBackOrder.Visible = true;
                        txtUPC.Visible = true;
                        txtQty.Visible = true;
                        txtBackOrder.Visible = true;
                        break;
                    case 2:
                        lblUPC.Visible = true;
                        lblQuant.Visible = true;
                        txtUPC.Visible = true;
                        txtQty.Visible = true;
                        btnTransfer.Visible = true;
                        cbUsers.Visible = true;
                        break;
                    default:

                        break;
                }
            }
        }

        private void cbTasks_Click(object sender, EventArgs e)
        {

        }
    }
}
