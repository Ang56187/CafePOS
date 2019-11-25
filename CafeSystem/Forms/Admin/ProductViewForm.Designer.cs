namespace CafeSystem.Forms.Admin
{
    partial class ProductViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductViewForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Product");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Stock");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Order");
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pnlAdminName = new System.Windows.Forms.Panel();
            this.pnlAdminNavContainer = new System.Windows.Forms.Panel();
            this.pnlAdminTopContainer = new System.Windows.Forms.Panel();
            this.lblProductTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBtnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddProduct = new CafeSystem.Components.RoundButton();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.treeViewAdminNav = new CafeSystem.Components.CustomTreeView();
            this.pnlAdminName.SuspendLayout();
            this.pnlAdminNavContainer.SuspendLayout();
            this.pnlAdminTopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
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
            // lblProductTable
            // 
            this.lblProductTable.AutoSize = true;
            this.lblProductTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTable.Location = new System.Drawing.Point(283, 73);
            this.lblProductTable.Name = "lblProductTable";
            this.lblProductTable.Size = new System.Drawing.Size(183, 29);
            this.lblProductTable.TabIndex = 17;
            this.lblProductTable.Text = "Product Table";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.panel1.Location = new System.Drawing.Point(288, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 5);
            this.panel1.TabIndex = 18;
            // 
            // dtgProduct
            // 
            this.dtgProduct.AllowUserToOrderColumns = true;
            this.dtgProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductName,
            this.colProductPrice,
            this.colProductStock,
            this.colBtnEdit,
            this.colBtnDelete});
            this.dtgProduct.Location = new System.Drawing.Point(335, 194);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.RowTemplate.Height = 24;
            this.dtgProduct.Size = new System.Drawing.Size(1507, 776);
            this.dtgProduct.TabIndex = 20;
            // 
            // colProductName
            // 
            this.colProductName.HeaderText = "Name";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colProductPrice
            // 
            this.colProductPrice.HeaderText = "Price";
            this.colProductPrice.Name = "colProductPrice";
            this.colProductPrice.ReadOnly = true;
            // 
            // colProductStock
            // 
            this.colProductStock.HeaderText = "Current Stock";
            this.colProductStock.Name = "colProductStock";
            this.colProductStock.ReadOnly = true;
            // 
            // colBtnEdit
            // 
            this.colBtnEdit.HeaderText = "";
            this.colBtnEdit.Name = "colBtnEdit";
            this.colBtnEdit.ReadOnly = true;
            this.colBtnEdit.Text = "Edit";
            this.colBtnEdit.UseColumnTextForButtonValue = true;
            // 
            // colBtnDelete
            // 
            this.colBtnDelete.HeaderText = "";
            this.colBtnDelete.Name = "colBtnDelete";
            this.colBtnDelete.ReadOnly = true;
            this.colBtnDelete.Text = "Delete";
            this.colBtnDelete.UseColumnTextForButtonValue = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSize = true;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(283, 123);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 10, 20, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(168, 46);
            this.btnAddProduct.TabIndex = 19;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
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
            // treeViewAdminNav
            // 
            this.treeViewAdminNav.AlternateBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.treeViewAdminNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.treeViewAdminNav.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            treeNode1.Name = "nodeUser";
            treeNode1.Text = "User";
            treeNode2.Name = "nodeProduct";
            treeNode2.Text = "Product";
            treeNode3.Name = "nodeStock";
            treeNode3.Text = "Stock";
            treeNode4.Name = "nodeOrder";
            treeNode4.Text = "Order";
            this.treeViewAdminNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeViewAdminNav.ShowLines = false;
            this.treeViewAdminNav.Size = new System.Drawing.Size(275, 951);
            this.treeViewAdminNav.TabIndex = 3;
            this.treeViewAdminNav.TabStop = false;
            this.treeViewAdminNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAdminNav_AfterSelect);
            // 
            // ProductViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.dtgProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProductTable);
            this.Controls.Add(this.pnlAdminTopContainer);
            this.Controls.Add(this.pnlAdminNavContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductViewForm";
            this.Text = "Sunway Cafe (Admin)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductViewForm_Load);
            this.pnlAdminName.ResumeLayout(false);
            this.pnlAdminName.PerformLayout();
            this.pnlAdminNavContainer.ResumeLayout(false);
            this.pnlAdminTopContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.RoundButton btnLogOut;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Panel pnlAdminName;
        private Components.CustomTreeView treeViewAdminNav;
        private System.Windows.Forms.Panel pnlAdminNavContainer;
        private System.Windows.Forms.Panel pnlAdminTopContainer;
        private System.Windows.Forms.Label lblProductTable;
        private System.Windows.Forms.Panel panel1;
        private Components.RoundButton btnAddProduct;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductStock;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnDelete;
    }
}