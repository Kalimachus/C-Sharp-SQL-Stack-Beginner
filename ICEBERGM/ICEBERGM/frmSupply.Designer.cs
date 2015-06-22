namespace ICEBERGM
{
    partial class frmSupply
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.lblWindow = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblBackOrder = new System.Windows.Forms.Label();
            this.txtBackOrder = new System.Windows.Forms.TextBox();
            this.lblUPC = new System.Windows.Forms.Label();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtChatInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetMessages = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.txtChatUser = new System.Windows.Forms.ComboBox();
            this.grpInventory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(1, 1);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(685, 439);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 5D;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.Location = new System.Drawing.Point(572, 638);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(113, 33);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send Message";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // lblWindow
            // 
            this.lblWindow.AutoSize = true;
            this.lblWindow.BackColor = System.Drawing.Color.Transparent;
            this.lblWindow.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindow.ForeColor = System.Drawing.Color.White;
            this.lblWindow.Location = new System.Drawing.Point(726, 13);
            this.lblWindow.Name = "lblWindow";
            this.lblWindow.Size = new System.Drawing.Size(0, 25);
            this.lblWindow.TabIndex = 2;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(22, 513);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(252, 33);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Tag = "InventoryGroup";
            this.btnInventory.Text = "View Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(252, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Tag = "InventoryGroup";
            this.btnAdd.Text = "Add Inventory";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // grpInventory
            // 
            this.grpInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInventory.BackColor = System.Drawing.Color.White;
            this.grpInventory.Controls.Add(this.label5);
            this.grpInventory.Controls.Add(this.cbTasks);
            this.grpInventory.Controls.Add(this.lblPrice);
            this.grpInventory.Controls.Add(this.txtPrice);
            this.grpInventory.Controls.Add(this.lblBackOrder);
            this.grpInventory.Controls.Add(this.txtBackOrder);
            this.grpInventory.Controls.Add(this.lblUPC);
            this.grpInventory.Controls.Add(this.txtUPC);
            this.grpInventory.Controls.Add(this.lblQuant);
            this.grpInventory.Controls.Add(this.txtQty);
            this.grpInventory.Controls.Add(this.cbUsers);
            this.grpInventory.Controls.Add(this.btnTransfer);
            this.grpInventory.Controls.Add(this.btnAdd);
            this.grpInventory.Controls.Add(this.btnInventory);
            this.grpInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grpInventory.ForeColor = System.Drawing.Color.Black;
            this.grpInventory.Location = new System.Drawing.Point(692, 58);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(302, 574);
            this.grpInventory.TabIndex = 5;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Select Task:";
            // 
            // cbTasks
            // 
            this.cbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Items.AddRange(new object[] {
            "View inventory",
            "Add Inventory",
            "Distribute to Seller",
            "None"});
            this.cbTasks.Location = new System.Drawing.Point(23, 62);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(252, 31);
            this.cbTasks.TabIndex = 15;
            this.cbTasks.DropDownClosed += new System.EventHandler(this.cbTasks_DropDownClosed);
            this.cbTasks.Click += new System.EventHandler(this.cbTasks_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 315);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(187, 23);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Tag = "InventoryGroup";
            this.lblPrice.Text = "Price (New Items Only):";
            this.lblPrice.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(23, 341);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(252, 30);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.Tag = "InventoryGroup";
            this.txtPrice.Visible = false;
            // 
            // lblBackOrder
            // 
            this.lblBackOrder.AutoSize = true;
            this.lblBackOrder.Location = new System.Drawing.Point(19, 246);
            this.lblBackOrder.Name = "lblBackOrder";
            this.lblBackOrder.Size = new System.Drawing.Size(90, 23);
            this.lblBackOrder.TabIndex = 12;
            this.lblBackOrder.Tag = "InventoryGroup";
            this.lblBackOrder.Text = "Backorder:";
            this.lblBackOrder.Visible = false;
            // 
            // txtBackOrder
            // 
            this.txtBackOrder.Location = new System.Drawing.Point(22, 272);
            this.txtBackOrder.Name = "txtBackOrder";
            this.txtBackOrder.Size = new System.Drawing.Size(252, 30);
            this.txtBackOrder.TabIndex = 11;
            this.txtBackOrder.Tag = "InventoryGroup";
            this.txtBackOrder.Visible = false;
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(18, 107);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(47, 23);
            this.lblUPC.TabIndex = 10;
            this.lblUPC.Tag = "InventoryGroup";
            this.lblUPC.Text = "UPC:";
            this.lblUPC.Visible = false;
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(23, 133);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(252, 30);
            this.txtUPC.TabIndex = 9;
            this.txtUPC.Tag = "InventoryGroup";
            this.txtUPC.Visible = false;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(19, 176);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(80, 23);
            this.lblQuant.TabIndex = 8;
            this.lblQuant.Tag = "InventoryGroup";
            this.lblQuant.Text = "Quantity:";
            this.lblQuant.Visible = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(23, 202);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(252, 30);
            this.txtQty.TabIndex = 7;
            this.txtQty.Tag = "InventoryGroup";
            this.txtQty.Visible = false;
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Items.AddRange(new object[] {
            "Kyle.L.Gomez",
            "Hermes.Condrad",
            "Phillip.J.Fry",
            "Turanga.Leela",
            "John.A.Zoidberg",
            "Hubert.J.Farnsworth",
            "Amy.Wong",
            "Zapp.Brannigan",
            "Kif.Kroker",
            "Bender.B.Rodriguez",
            "Matt.Groening",
            "David.X.Cohen"});
            this.cbUsers.Location = new System.Drawing.Point(22, 427);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(252, 31);
            this.cbUsers.TabIndex = 6;
            this.cbUsers.Tag = "InventoryGroup";
            this.cbUsers.Visible = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(23, 388);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(252, 33);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Tag = "InventoryGroup";
            this.btnTransfer.Text = "Transfer Inventory";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Visible = false;
            // 
            // txtChatInput
            // 
            this.txtChatInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChatInput.Location = new System.Drawing.Point(12, 610);
            this.txtChatInput.Name = "txtChatInput";
            this.txtChatInput.Size = new System.Drawing.Size(673, 22);
            this.txtChatInput.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(1, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 158);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetMessages
            // 
            this.btnGetMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetMessages.Location = new System.Drawing.Point(453, 638);
            this.btnGetMessages.Name = "btnGetMessages";
            this.btnGetMessages.Size = new System.Drawing.Size(113, 33);
            this.btnGetMessages.TabIndex = 7;
            this.btnGetMessages.Text = "Get Messages";
            this.btnGetMessages.UseVisualStyleBackColor = true;
            this.btnGetMessages.Click += new System.EventHandler(this.btnGetMessages_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(881, 638);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtChatUser
            // 
            this.txtChatUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChatUser.FormattingEnabled = true;
            this.txtChatUser.Items.AddRange(new object[] {
            "Kyle.L.Gomez",
            "Hermes.Condrad",
            "Phillip.J.Fry",
            "Turanga.Leela",
            "John.A.Zoidberg",
            "Hubert.J.Farnsworth",
            "Amy.Wong",
            "Zapp.Brannigan",
            "Kif.Kroker",
            "Bender.B.Rodriguez",
            "Matt.Groening",
            "David.X.Cohen"});
            this.txtChatUser.Location = new System.Drawing.Point(195, 642);
            this.txtChatUser.Name = "txtChatUser";
            this.txtChatUser.Size = new System.Drawing.Size(252, 24);
            this.txtChatUser.TabIndex = 17;
            this.txtChatUser.Tag = "InventoryGroup";
            this.txtChatUser.Visible = false;
            // 
            // frmSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ICEBERGM.Properties.Resources.icecreamgradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 678);
            this.Controls.Add(this.txtChatUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetMessages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChatInput);
            this.Controls.Add(this.grpInventory);
            this.Controls.Add(this.lblWindow);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.gMapControl1);
            this.DoubleBuffered = true;
            this.Name = "frmSupply";
            this.Text = "frmSupply";
            this.Load += new System.EventHandler(this.frmSupply_Load);
            this.grpInventory.ResumeLayout(false);
            this.grpInventory.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblWindow;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtChatInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetMessages;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblBackOrder;
        private System.Windows.Forms.TextBox txtBackOrder;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox txtChatUser;
    }
}