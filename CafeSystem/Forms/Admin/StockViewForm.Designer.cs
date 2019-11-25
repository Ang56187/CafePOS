namespace CafeSystem.Forms.Admin
{
    partial class StockViewForm
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Product");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Stock");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Order");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockViewForm));
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pnlAdminName = new System.Windows.Forms.Panel();
            this.pnlAdminNavContainer = new System.Windows.Forms.Panel();
            this.treeViewAdminNav = new CafeSystem.Components.CustomTreeView();
            this.pnlAdminTopContainer = new System.Windows.Forms.Panel();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.lblUserTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgStock = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new CafeSystem.Components.RoundButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlAdminName.SuspendLayout();
            this.pnlAdminNavContainer.SuspendLayout();
            this.pnlAdminTopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(12, 22);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(175, 25);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "Admin: Name here";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAdminName
            // 
            this.pnlAdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.pnlAdminName.Controls.Add(this.lblAdminName);
            this.pnlAdminName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminName.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminName.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdminName.Name = "pnlAdminName";
            this.pnlAdminName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlAdminName.Size = new System.Drawing.Size(274, 57);
            this.pnlAdminName.TabIndex = 10;
            // 
            // pnlAdminNavContainer
            // 
            this.pnlAdminNavContainer.BackColor = System.Drawing.Color.White;
            this.pnlAdminNavContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdminNavContainer.Controls.Add(this.treeViewAdminNav);
            this.pnlAdminNavContainer.Controls.Add(this.pnlAdminName);
            this.pnlAdminNavContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAdminNavContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlAdminNavContainer.Name = "pnlAdminNavContainer";
            this.pnlAdminNavContainer.Size = new System.Drawing.Size(276, 1010);
            this.pnlAdminNavContainer.TabIndex = 15;
            // 
            // treeViewAdminNav
            // 
            this.treeViewAdminNav.AlternateBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.treeViewAdminNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.treeViewAdminNav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewAdminNav.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeViewAdminNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAdminNav.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeViewAdminNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdminNav.ForeColor = System.Drawing.Color.White;
            this.treeViewAdminNav.HideSelection = false;
            this.treeViewAdminNav.ItemHeight = 40;
            this.treeViewAdminNav.LineColor = System.Drawing.Color.White;
            this.treeViewAdminNav.Location = new System.Drawing.Point(0, 57);
            this.treeViewAdminNav.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewAdminNav.MinimumSize = new System.Drawing.Size(133, 123);
            this.treeViewAdminNav.Name = "treeViewAdminNav";
            treeNode17.Name = "nodeUser";
            treeNode17.Text = "User";
            treeNode18.Name = "nodeProduct";
            treeNode18.Text = "Product";
            treeNode19.Name = "nodeStock";
            treeNode19.Text = "Stock";
            treeNode20.Name = "nodeOrder";
            treeNode20.Text = "Order";
            this.treeViewAdminNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.treeViewAdminNav.ShowLines = false;
            this.treeViewAdminNav.Size = new System.Drawing.Size(275, 951);
            this.treeViewAdminNav.TabIndex = 3;
            this.treeViewAdminNav.TabStop = false;
            this.treeViewAdminNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAdminNav_AfterSelect);
            // 
            // pnlAdminTopContainer
            // 
            this.pnlAdminTopContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdminTopContainer.Controls.Add(this.btnLogOut);
            this.pnlAdminTopContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminTopContainer.Location = new System.Drawing.Point(276, 0);
            this.pnlAdminTopContainer.Name = "pnlAdminTopContainer";
            this.pnlAdminTopContainer.Size = new System.Drawing.Size(1648, 58);
            this.pnlAdminTopContainer.TabIndex = 16;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1439, 5);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 10, 20, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnLogOut.Size = new System.Drawing.Size(187, 46);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblUserTable
            // 
            this.lblUserTable.AutoSize = true;
            this.lblUserTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTable.Location = new System.Drawing.Point(283, 73);
            this.lblUserTable.Name = "lblUserTable";
            this.lblUserTable.Size = new System.Drawing.Size(158, 29);
            this.lblUserTable.TabIndex = 17;
            this.lblUserTable.Text = "Stock Table";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.panel1.Location = new System.Drawing.Point(288, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 5);
            this.panel1.TabIndex = 18;
            // 
            // dtgStock
            // 
            this.dtgStock.AllowUserToOrderColumns = true;
            this.dtgStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.stock_name,
            this.stock_quantity,
            this.stock_cost,
            this.supplier_link,
            this.colBtnEdit,
            this.colBtnDelete});
            this.dtgStock.Location = new System.Drawing.Point(335, 194);
            this.dtgStock.Name = "dtgStock";
            this.dtgStock.RowHeadersWidth = 51;
            this.dtgStock.RowTemplate.Height = 24;
            this.dtgStock.Size = new System.Drawing.Size(1507, 776);
            this.dtgStock.TabIndex = 20;
            this.dtgStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgStock_CellContentClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(283, 123);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 10, 20, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnAddUser.Size = new System.Drawing.Size(168, 46);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.Text = "Add Stock";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // stock_name
            // 
            this.stock_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stock_name.Frozen = true;
            this.stock_name.HeaderText = "Stock name";
            this.stock_name.MinimumWidth = 6;
            this.stock_name.Name = "stock_name";
            this.stock_name.ReadOnly = true;
            this.stock_name.Width = 366;
            // 
            // stock_quantity
            // 
            this.stock_quantity.HeaderText = "Stock quantity";
            this.stock_quantity.MinimumWidth = 6;
            this.stock_quantity.Name = "stock_quantity";
            this.stock_quantity.ReadOnly = true;
            // 
            // stock_cost
            // 
            this.stock_cost.HeaderText = "Stock cost";
            this.stock_cost.MinimumWidth = 6;
            this.stock_cost.Name = "stock_cost";
            // 
            // supplier_link
            // 
            this.supplier_link.HeaderText = "Supplier link";
            this.supplier_link.MinimumWidth = 6;
            this.supplier_link.Name = "supplier_link";
            // 
            // colBtnEdit
            // 
            this.colBtnEdit.HeaderText = "";
            this.colBtnEdit.MinimumWidth = 6;
            this.colBtnEdit.Name = "colBtnEdit";
            this.colBtnEdit.ReadOnly = true;
            this.colBtnEdit.Text = "Edit";
            this.colBtnEdit.UseColumnTextForButtonValue = true;
            // 
            // colBtnDelete
            // 
            this.colBtnDelete.HeaderText = "";
            this.colBtnDelete.MinimumWidth = 6;
            this.colBtnDelete.Name = "colBtnDelete";
            this.colBtnDelete.ReadOnly = true;
            this.colBtnDelete.Text = "Delete";
            this.colBtnDelete.UseColumnTextForButtonValue = true;
            // 
            // StockViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.dtgStock);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserTable);
            this.Controls.Add(this.pnlAdminTopContainer);
            this.Controls.Add(this.pnlAdminNavContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockViewForm";
            this.Text = "Sunway Cafe (Admin)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockViewForm_Load);
            this.pnlAdminName.ResumeLayout(false);
            this.pnlAdminName.PerformLayout();
            this.pnlAdminNavContainer.ResumeLayout(false);
            this.pnlAdminTopContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.RoundButton btnLogOut;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Panel pnlAdminName;
        private System.Windows.Forms.Panel pnlAdminNavContainer;
        private System.Windows.Forms.Panel pnlAdminTopContainer;
        private System.Windows.Forms.Label lblUserTable;
        private System.Windows.Forms.Panel panel1;
        private Components.RoundButton btnAddUser;
        private System.Windows.Forms.DataGridView dtgStock;
        private Components.CustomTreeView treeViewAdminNav;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_link;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnDelete;
    }
}