namespace CafeSystem.Forms.Admin
{
    partial class StockAddForm
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Product");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Stock");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Order");
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pnlAdminName = new System.Windows.Forms.Panel();
            this.pnlAdminNavContainer = new System.Windows.Forms.Panel();
            this.treeViewAdminNav = new CafeSystem.Components.CustomTreeView();
            this.pnlAdminTopContainer = new System.Windows.Forms.Panel();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.lblStockTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.txtStockName = new System.Windows.Forms.TextBox();
            this.lblStockName = new System.Windows.Forms.Label();
            this.btnAdd = new CafeSystem.Components.RoundButton();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSupplierLink = new System.Windows.Forms.Label();
            this.numUpDownStockQty = new System.Windows.Forms.NumericUpDown();
            this.txtStockCost = new System.Windows.Forms.TextBox();
            this.txtSupplierLink = new System.Windows.Forms.TextBox();
            this.pnlAdminName.SuspendLayout();
            this.pnlAdminNavContainer.SuspendLayout();
            this.pnlAdminTopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStockQty)).BeginInit();
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
            treeNode9.Name = "nodeUser";
            treeNode9.Text = "User";
            treeNode10.Name = "nodeProduct";
            treeNode10.Text = "Product";
            treeNode11.Name = "nodeStock";
            treeNode11.Text = "Stock";
            treeNode12.Name = "nodeOrder";
            treeNode12.Text = "Order";
            this.treeViewAdminNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
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
            // lblStockTable
            // 
            this.lblStockTable.AutoSize = true;
            this.lblStockTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStockTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTable.Location = new System.Drawing.Point(283, 73);
            this.lblStockTable.Name = "lblStockTable";
            this.lblStockTable.Size = new System.Drawing.Size(158, 29);
            this.lblStockTable.TabIndex = 17;
            this.lblStockTable.Text = "Stock Table";
            this.lblStockTable.Click += new System.EventHandler(this.lblStockTable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.panel1.Location = new System.Drawing.Point(288, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 5);
            this.panel1.TabIndex = 18;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.AutoSize = true;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumb.Location = new System.Drawing.Point(447, 73);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(28, 29);
            this.lblBreadcrumb.TabIndex = 20;
            this.lblBreadcrumb.Text = ">";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.Location = new System.Drawing.Point(469, 73);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(138, 29);
            this.lblAddStock.TabIndex = 21;
            this.lblAddStock.Text = "Add Stock";
            // 
            // txtStockName
            // 
            this.txtStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockName.Location = new System.Drawing.Point(328, 166);
            this.txtStockName.Name = "txtStockName";
            this.txtStockName.Size = new System.Drawing.Size(592, 30);
            this.txtStockName.TabIndex = 22;
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.Location = new System.Drawing.Point(323, 138);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(119, 25);
            this.lblStockName.TabIndex = 23;
            this.lblStockName.Text = "Stock Name";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(328, 578);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 10, 20, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnAdd.Size = new System.Drawing.Size(168, 46);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStockQty
            // 
            this.lblStockQty.AutoSize = true;
            this.lblStockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQty.Location = new System.Drawing.Point(323, 230);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(135, 25);
            this.lblStockQty.TabIndex = 28;
            this.lblStockQty.Text = "Stock quantity";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(323, 330);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(103, 25);
            this.lblPosition.TabIndex = 30;
            this.lblPosition.Text = "Stock cost";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblSupplierLink
            // 
            this.lblSupplierLink.AutoSize = true;
            this.lblSupplierLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierLink.Location = new System.Drawing.Point(323, 453);
            this.lblSupplierLink.Name = "lblSupplierLink";
            this.lblSupplierLink.Size = new System.Drawing.Size(118, 25);
            this.lblSupplierLink.TabIndex = 32;
            this.lblSupplierLink.Text = "Supplier link";
            this.lblSupplierLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDownStockQty
            // 
            this.numUpDownStockQty.Location = new System.Drawing.Point(328, 268);
            this.numUpDownStockQty.Name = "numUpDownStockQty";
            this.numUpDownStockQty.Size = new System.Drawing.Size(120, 22);
            this.numUpDownStockQty.TabIndex = 33;
            // 
            // txtStockCost
            // 
            this.txtStockCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCost.Location = new System.Drawing.Point(328, 369);
            this.txtStockCost.Name = "txtStockCost";
            this.txtStockCost.Size = new System.Drawing.Size(592, 30);
            this.txtStockCost.TabIndex = 34;
            this.txtStockCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockCost_KeyPress);
            // 
            // txtSupplierLink
            // 
            this.txtSupplierLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierLink.Location = new System.Drawing.Point(328, 492);
            this.txtSupplierLink.Name = "txtSupplierLink";
            this.txtSupplierLink.Size = new System.Drawing.Size(592, 30);
            this.txtSupplierLink.TabIndex = 35;
            // 
            // StockAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.txtSupplierLink);
            this.Controls.Add(this.txtStockCost);
            this.Controls.Add(this.numUpDownStockQty);
            this.Controls.Add(this.lblSupplierLink);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblStockQty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.txtStockName);
            this.Controls.Add(this.lblAddStock);
            this.Controls.Add(this.lblBreadcrumb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStockTable);
            this.Controls.Add(this.pnlAdminTopContainer);
            this.Controls.Add(this.pnlAdminNavContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockAddForm";
            this.Text = "Sunway Cafe (Admin)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserAddForm_Load);
            this.pnlAdminName.ResumeLayout(false);
            this.pnlAdminName.PerformLayout();
            this.pnlAdminNavContainer.ResumeLayout(false);
            this.pnlAdminTopContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStockQty)).EndInit();
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
        private System.Windows.Forms.Label lblStockTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.TextBox txtStockName;
        private System.Windows.Forms.Label lblStockName;
        private Components.RoundButton btnAdd;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSupplierLink;
        private System.Windows.Forms.NumericUpDown numUpDownStockQty;
        private System.Windows.Forms.TextBox txtStockCost;
        private System.Windows.Forms.TextBox txtSupplierLink;
    }
}