namespace CafeSystem.Forms.Admin
{
    partial class UserAddForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Product");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Stock");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Order");
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pnlAdminName = new System.Windows.Forms.Panel();
            this.pnlAdminNavContainer = new System.Windows.Forms.Panel();
            this.treeViewAdminNav = new CafeSystem.Components.CustomTreeView();
            this.pnlAdminTopContainer = new System.Windows.Forms.Panel();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.lblUserTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnAdd = new CafeSystem.Components.RoundButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.pnlAdminName.SuspendLayout();
            this.pnlAdminNavContainer.SuspendLayout();
            this.pnlAdminTopContainer.SuspendLayout();
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
            // lblUserTable
            // 
            this.lblUserTable.AutoSize = true;
            this.lblUserTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTable.Location = new System.Drawing.Point(283, 73);
            this.lblUserTable.Name = "lblUserTable";
            this.lblUserTable.Size = new System.Drawing.Size(146, 29);
            this.lblUserTable.TabIndex = 17;
            this.lblUserTable.Text = "User Table";
            this.lblUserTable.Click += new System.EventHandler(this.lblUserTable_Click);
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
            this.lblBreadcrumb.Location = new System.Drawing.Point(435, 73);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(28, 29);
            this.lblBreadcrumb.TabIndex = 20;
            this.lblBreadcrumb.Text = ">";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(469, 73);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(126, 29);
            this.lblAddUser.TabIndex = 21;
            this.lblAddUser.Text = "Add User";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(328, 166);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(592, 30);
            this.txtUserName.TabIndex = 22;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(323, 138);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(110, 25);
            this.lblItemName.TabIndex = 23;
            this.lblItemName.Text = "User Name";
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
            this.btnAdd.Location = new System.Drawing.Point(328, 497);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 10, 20, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnAdd.Size = new System.Drawing.Size(168, 46);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(323, 230);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(328, 258);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(592, 30);
            this.txtPassword.TabIndex = 27;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(323, 330);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(81, 25);
            this.lblPosition.TabIndex = 30;
            this.lblPosition.Text = "Position";
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "Cashier",
            "Kitchen",
            "Admin"});
            this.cboPosition.Location = new System.Drawing.Point(328, 358);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(592, 33);
            this.cboPosition.TabIndex = 31;
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.lblBreadcrumb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserTable);
            this.Controls.Add(this.pnlAdminTopContainer);
            this.Controls.Add(this.pnlAdminNavContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserAddForm";
            this.Text = "Sunway Cafe (Admin)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserAddForm_Load);
            this.pnlAdminName.ResumeLayout(false);
            this.pnlAdminName.PerformLayout();
            this.pnlAdminNavContainer.ResumeLayout(false);
            this.pnlAdminTopContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblUserTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblItemName;
        private Components.RoundButton btnAdd;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cboPosition;
    }
}