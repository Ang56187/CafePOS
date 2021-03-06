﻿namespace CafeSystem.Forms.Admin
{
    partial class ProductAddForm
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
            this.lblProductTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.rdoFood = new System.Windows.Forms.RadioButton();
            this.rdoBeverage = new System.Windows.Forms.RadioButton();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.cboIngredient = new System.Windows.Forms.ComboBox();
            this.lblItemImage = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.btnAddIngredient = new CafeSystem.Components.RoundButton();
            this.btnAdd = new CafeSystem.Components.RoundButton();
            this.flowPaneIngredientInner = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPaneIngredientOuter = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAdminName.SuspendLayout();
            this.pnlAdminNavContainer.SuspendLayout();
            this.pnlAdminTopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.flowPaneIngredientInner.SuspendLayout();
            this.flowPaneIngredientOuter.SuspendLayout();
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
            treeNode4,
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
            // lblProductTable
            // 
            this.lblProductTable.AutoSize = true;
            this.lblProductTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProductTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTable.Location = new System.Drawing.Point(283, 73);
            this.lblProductTable.Name = "lblProductTable";
            this.lblProductTable.Size = new System.Drawing.Size(183, 29);
            this.lblProductTable.TabIndex = 17;
            this.lblProductTable.Text = "Product Table";
            this.lblProductTable.Click += new System.EventHandler(this.lblProductTable_Click);
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
            this.lblBreadcrumb.Location = new System.Drawing.Point(472, 73);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(28, 29);
            this.lblBreadcrumb.TabIndex = 20;
            this.lblBreadcrumb.Text = ">";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProduct.Location = new System.Drawing.Point(506, 73);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(163, 29);
            this.lblAddProduct.TabIndex = 21;
            this.lblAddProduct.Text = "Add Product";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(328, 166);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(592, 30);
            this.txtItemName.TabIndex = 22;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(323, 138);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(106, 25);
            this.lblItemName.TabIndex = 23;
            this.lblItemName.Text = "Item Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(990, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(995, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 30);
            this.txtPrice.TabIndex = 24;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(323, 245);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 28;
            this.lblCategory.Text = "Category";
            // 
            // rdoFood
            // 
            this.rdoFood.AutoSize = true;
            this.rdoFood.Checked = true;
            this.rdoFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFood.Location = new System.Drawing.Point(347, 274);
            this.rdoFood.Name = "rdoFood";
            this.rdoFood.Size = new System.Drawing.Size(64, 22);
            this.rdoFood.TabIndex = 29;
            this.rdoFood.TabStop = true;
            this.rdoFood.Text = "Food";
            this.rdoFood.UseVisualStyleBackColor = true;
            this.rdoFood.CheckedChanged += new System.EventHandler(this.rdoFood_CheckedChanged);
            // 
            // rdoBeverage
            // 
            this.rdoBeverage.AutoSize = true;
            this.rdoBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBeverage.Location = new System.Drawing.Point(477, 274);
            this.rdoBeverage.Name = "rdoBeverage";
            this.rdoBeverage.Size = new System.Drawing.Size(91, 22);
            this.rdoBeverage.TabIndex = 30;
            this.rdoBeverage.Text = "Beverage";
            this.rdoBeverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBeverage.UseVisualStyleBackColor = true;
            this.rdoBeverage.CheckedChanged += new System.EventHandler(this.rdoBeverage_CheckedChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Pastry",
            "Sides"});
            this.cboCategory.Location = new System.Drawing.Point(328, 302);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(592, 33);
            this.cboCategory.TabIndex = 31;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(323, 371);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(98, 25);
            this.lblIngredient.TabIndex = 34;
            this.lblIngredient.Text = "Ingredient";
            // 
            // cboIngredient
            // 
            this.cboIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIngredient.FormattingEnabled = true;
            this.cboIngredient.Location = new System.Drawing.Point(3, 3);
            this.cboIngredient.Name = "cboIngredient";
            this.cboIngredient.Size = new System.Drawing.Size(341, 33);
            this.cboIngredient.TabIndex = 35;
            // 
            // lblItemImage
            // 
            this.lblItemImage.AutoSize = true;
            this.lblItemImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemImage.Location = new System.Drawing.Point(323, 489);
            this.lblItemImage.Name = "lblItemImage";
            this.lblItemImage.Size = new System.Drawing.Size(108, 25);
            this.lblItemImage.TabIndex = 37;
            this.lblItemImage.Text = "Item Image";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(708, 489);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 25);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(713, 529);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(437, 275);
            this.txtDescription.TabIndex = 39;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(335, 805);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(98, 17);
            this.lblFileName.TabIndex = 42;
            this.lblFileName.Text = "No file chosen";
            // 
            // picItem
            // 
            this.picItem.BackgroundImage = global::CafeSystem.Properties.Resources.image_upload;
            this.picItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picItem.ErrorImage = null;
            this.picItem.Location = new System.Drawing.Point(328, 529);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(341, 273);
            this.picItem.TabIndex = 0;
            this.picItem.TabStop = false;
            this.picItem.Click += new System.EventHandler(this.picItem_Click);
            this.picItem.DragDrop += new System.Windows.Forms.DragEventHandler(this.picItem_DragDrop);
            this.picItem.DragEnter += new System.Windows.Forms.DragEventHandler(this.picItem_DragEnter);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.AutoSize = true;
            this.btnAddIngredient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddIngredient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIngredient.FlatAppearance.BorderSize = 0;
            this.btnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIngredient.ForeColor = System.Drawing.Color.White;
            this.btnAddIngredient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIngredient.Location = new System.Drawing.Point(357, 4);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(4, 4, 20, 4);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Padding = new System.Windows.Forms.Padding(13, 0, 13, 2);
            this.btnAddIngredient.Size = new System.Drawing.Size(214, 42);
            this.btnAddIngredient.TabIndex = 40;
            this.btnAddIngredient.Text = "Add More Ingredient";
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(328, 866);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 10, 20, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnAdd.Size = new System.Drawing.Size(168, 46);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flowPaneIngredientInner
            // 
            this.flowPaneIngredientInner.AutoSize = true;
            this.flowPaneIngredientInner.Controls.Add(this.cboIngredient);
            this.flowPaneIngredientInner.Location = new System.Drawing.Point(3, 3);
            this.flowPaneIngredientInner.Name = "flowPaneIngredientInner";
            this.flowPaneIngredientInner.Size = new System.Drawing.Size(347, 39);
            this.flowPaneIngredientInner.TabIndex = 43;
            // 
            // flowPaneIngredientOuter
            // 
            this.flowPaneIngredientOuter.AutoSize = true;
            this.flowPaneIngredientOuter.Controls.Add(this.flowPaneIngredientInner);
            this.flowPaneIngredientOuter.Controls.Add(this.btnAddIngredient);
            this.flowPaneIngredientOuter.Location = new System.Drawing.Point(328, 409);
            this.flowPaneIngredientOuter.Name = "flowPaneIngredientOuter";
            this.flowPaneIngredientOuter.Size = new System.Drawing.Size(695, 56);
            this.flowPaneIngredientOuter.TabIndex = 44;
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.flowPaneIngredientOuter);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblItemImage);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.rdoBeverage);
            this.Controls.Add(this.rdoFood);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.lblBreadcrumb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProductTable);
            this.Controls.Add(this.pnlAdminTopContainer);
            this.Controls.Add(this.pnlAdminNavContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductAddForm";
            this.Text = "Sunway Cafe (Admin)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductAddForm_Load);
            this.pnlAdminName.ResumeLayout(false);
            this.pnlAdminName.PerformLayout();
            this.pnlAdminNavContainer.ResumeLayout(false);
            this.pnlAdminTopContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.flowPaneIngredientInner.ResumeLayout(false);
            this.flowPaneIngredientOuter.ResumeLayout(false);
            this.flowPaneIngredientOuter.PerformLayout();
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
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private Components.RoundButton btnAdd;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RadioButton rdoFood;
        private System.Windows.Forms.RadioButton rdoBeverage;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.ComboBox cboIngredient;
        private System.Windows.Forms.Label lblItemImage;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private Components.RoundButton btnAddIngredient;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.FlowLayoutPanel flowPaneIngredientInner;
        private System.Windows.Forms.FlowLayoutPanel flowPaneIngredientOuter;
    }
}