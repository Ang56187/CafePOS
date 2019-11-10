namespace CafeSystem.Forms.Cashier
{
    partial class CashierMenuPage
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMenuPage));
            this.panelLine = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.panelCashierName = new System.Windows.Forms.Panel();
            this.transPanelCart = new CafeSystem.Components.TransparentPanel();
            this.flowPanelCart = new CafeSystem.Components.BorderFlowLayoutPane();
            this.lblShopCart = new System.Windows.Forms.Label();
            this.panelLineUnderCart = new System.Windows.Forms.Panel();
            this.lblClearItem = new System.Windows.Forms.Label();
            this.flowPanelCartItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSubTotal = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotalTxt = new System.Windows.Forms.Label();
            this.panelTaxTxt = new System.Windows.Forms.Panel();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTxt = new System.Windows.Forms.Label();
            this.flowPanelRadio = new System.Windows.Forms.FlowLayoutPanel();
            this.radioBtnDine = new System.Windows.Forms.RadioButton();
            this.radioBtnTake = new System.Windows.Forms.RadioButton();
            this.btnCheckout = new CafeSystem.Components.RoundButton();
            this.treeViewMenu = new CafeSystem.Components.CustomTreeView();
            this.flowLayoutHeader = new CafeSystem.Components.BorderFlowLayoutPane();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new CafeSystem.Components.RoundButton();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.transparentPanel1 = new CafeSystem.Components.TransparentPanel();
            this.panelCashierName.SuspendLayout();
            this.transPanelCart.SuspendLayout();
            this.flowPanelCart.SuspendLayout();
            this.panelSubTotal.SuspendLayout();
            this.panelTaxTxt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowPanelRadio.SuspendLayout();
            this.flowLayoutHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Silver;
            this.panelLine.Location = new System.Drawing.Point(330, 88);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(3, 737);
            this.panelLine.TabIndex = 8;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.AutoScroll = true;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(359, 109);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(1233, 716);
            this.flowLayoutPanelMenu.TabIndex = 9;
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.White;
            this.lblCashierName.Location = new System.Drawing.Point(13, 20);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(149, 20);
            this.lblCashierName.TabIndex = 0;
            this.lblCashierName.Text = "Cashier: Name here";
            this.lblCashierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCashierName
            // 
            this.panelCashierName.BackColor = System.Drawing.Color.DarkGray;
            this.panelCashierName.Controls.Add(this.transparentPanel1);
            this.panelCashierName.Controls.Add(this.lblCashierName);
            this.panelCashierName.Location = new System.Drawing.Point(-1, -2);
            this.panelCashierName.Name = "panelCashierName";
            this.panelCashierName.Size = new System.Drawing.Size(334, 58);
            this.panelCashierName.TabIndex = 10;
            // 
            // transPanelCart
            // 
            this.transPanelCart.Controls.Add(this.flowPanelCart);
            this.transPanelCart.Location = new System.Drawing.Point(2, 55);
            this.transPanelCart.Name = "transPanelCart";
            this.transPanelCart.Opacity = 0;
            this.transPanelCart.Size = new System.Drawing.Size(1603, 776);
            this.transPanelCart.TabIndex = 12;
            this.transPanelCart.Click += new System.EventHandler(this.transPanelCart_Click);
            // 
            // flowPanelCart
            // 
            this.flowPanelCart.Controls.Add(this.lblShopCart);
            this.flowPanelCart.Controls.Add(this.panelLineUnderCart);
            this.flowPanelCart.Controls.Add(this.lblClearItem);
            this.flowPanelCart.Controls.Add(this.flowPanelCartItem);
            this.flowPanelCart.Controls.Add(this.panelSubTotal);
            this.flowPanelCart.Controls.Add(this.panelTaxTxt);
            this.flowPanelCart.Controls.Add(this.panel1);
            this.flowPanelCart.Controls.Add(this.flowPanelRadio);
            this.flowPanelCart.Controls.Add(this.btnCheckout);
            this.flowPanelCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowPanelCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelCart.Location = new System.Drawing.Point(1065, 0);
            this.flowPanelCart.Name = "flowPanelCart";
            this.flowPanelCart.Size = new System.Drawing.Size(538, 776);
            this.flowPanelCart.TabIndex = 11;
            // 
            // lblShopCart
            // 
            this.lblShopCart.AutoSize = true;
            this.lblShopCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShopCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopCart.Location = new System.Drawing.Point(3, 10);
            this.lblShopCart.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblShopCart.MinimumSize = new System.Drawing.Size(530, 45);
            this.lblShopCart.Name = "lblShopCart";
            this.lblShopCart.Size = new System.Drawing.Size(530, 45);
            this.lblShopCart.TabIndex = 0;
            this.lblShopCart.Text = "Shopping cart";
            this.lblShopCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLineUnderCart
            // 
            this.panelLineUnderCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelLineUnderCart.BackColor = System.Drawing.Color.Silver;
            this.panelLineUnderCart.Location = new System.Drawing.Point(68, 58);
            this.panelLineUnderCart.MaximumSize = new System.Drawing.Size(400, 3);
            this.panelLineUnderCart.MinimumSize = new System.Drawing.Size(100, 3);
            this.panelLineUnderCart.Name = "panelLineUnderCart";
            this.panelLineUnderCart.Size = new System.Drawing.Size(400, 3);
            this.panelLineUnderCart.TabIndex = 1;
            // 
            // lblClearItem
            // 
            this.lblClearItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClearItem.AutoSize = true;
            this.lblClearItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearItem.Location = new System.Drawing.Point(433, 68);
            this.lblClearItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lblClearItem.MinimumSize = new System.Drawing.Size(100, 25);
            this.lblClearItem.Name = "lblClearItem";
            this.lblClearItem.Size = new System.Drawing.Size(100, 25);
            this.lblClearItem.TabIndex = 2;
            this.lblClearItem.Text = "clear items";
            // 
            // flowPanelCartItem
            // 
            this.flowPanelCartItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowPanelCartItem.AutoScroll = true;
            this.flowPanelCartItem.Location = new System.Drawing.Point(14, 96);
            this.flowPanelCartItem.Name = "flowPanelCartItem";
            this.flowPanelCartItem.Size = new System.Drawing.Size(508, 419);
            this.flowPanelCartItem.TabIndex = 3;
            // 
            // panelSubTotal
            // 
            this.panelSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelSubTotal.Controls.Add(this.lblSubTotal);
            this.panelSubTotal.Controls.Add(this.lblSubTotalTxt);
            this.panelSubTotal.Location = new System.Drawing.Point(20, 521);
            this.panelSubTotal.Name = "panelSubTotal";
            this.panelSubTotal.Size = new System.Drawing.Size(496, 35);
            this.panelSubTotal.TabIndex = 4;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubTotal.Location = new System.Drawing.Point(296, 0);
            this.lblSubTotal.MinimumSize = new System.Drawing.Size(200, 35);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(200, 35);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "RM 12.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalTxt
            // 
            this.lblSubTotalTxt.AutoSize = true;
            this.lblSubTotalTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSubTotalTxt.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotalTxt.MinimumSize = new System.Drawing.Size(200, 35);
            this.lblSubTotalTxt.Name = "lblSubTotalTxt";
            this.lblSubTotalTxt.Size = new System.Drawing.Size(200, 35);
            this.lblSubTotalTxt.TabIndex = 0;
            this.lblSubTotalTxt.Text = "Sub-Total:";
            this.lblSubTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTaxTxt
            // 
            this.panelTaxTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelTaxTxt.Controls.Add(this.lblTax);
            this.panelTaxTxt.Controls.Add(this.lblTaxTxt);
            this.panelTaxTxt.Location = new System.Drawing.Point(20, 562);
            this.panelTaxTxt.Name = "panelTaxTxt";
            this.panelTaxTxt.Size = new System.Drawing.Size(496, 35);
            this.panelTaxTxt.TabIndex = 5;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTax.Location = new System.Drawing.Point(296, 0);
            this.lblTax.MinimumSize = new System.Drawing.Size(200, 35);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(200, 35);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "RM 12.00";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxTxt
            // 
            this.lblTaxTxt.AutoSize = true;
            this.lblTaxTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaxTxt.Location = new System.Drawing.Point(0, 0);
            this.lblTaxTxt.MinimumSize = new System.Drawing.Size(200, 35);
            this.lblTaxTxt.Name = "lblTaxTxt";
            this.lblTaxTxt.Size = new System.Drawing.Size(200, 35);
            this.lblTaxTxt.TabIndex = 0;
            this.lblTaxTxt.Text = "Service tax(6%):";
            this.lblTaxTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblTotalTxt);
            this.panel1.Location = new System.Drawing.Point(20, 603);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 35);
            this.panel1.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Location = new System.Drawing.Point(296, 0);
            this.lblTotal.MinimumSize = new System.Drawing.Size(200, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 35);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "RM 12.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.AutoSize = true;
            this.lblTotalTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalTxt.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTxt.MinimumSize = new System.Drawing.Size(200, 35);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(200, 35);
            this.lblTotalTxt.TabIndex = 0;
            this.lblTotalTxt.Text = "Total:";
            this.lblTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowPanelRadio
            // 
            this.flowPanelRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowPanelRadio.Controls.Add(this.radioBtnDine);
            this.flowPanelRadio.Controls.Add(this.radioBtnTake);
            this.flowPanelRadio.Location = new System.Drawing.Point(107, 644);
            this.flowPanelRadio.Name = "flowPanelRadio";
            this.flowPanelRadio.Size = new System.Drawing.Size(322, 38);
            this.flowPanelRadio.TabIndex = 7;
            // 
            // radioBtnDine
            // 
            this.radioBtnDine.AutoSize = true;
            this.radioBtnDine.Location = new System.Drawing.Point(3, 3);
            this.radioBtnDine.MinimumSize = new System.Drawing.Size(150, 30);
            this.radioBtnDine.Name = "radioBtnDine";
            this.radioBtnDine.Size = new System.Drawing.Size(150, 30);
            this.radioBtnDine.TabIndex = 0;
            this.radioBtnDine.TabStop = true;
            this.radioBtnDine.Text = "Dine-In";
            this.radioBtnDine.UseVisualStyleBackColor = true;
            // 
            // radioBtnTake
            // 
            this.radioBtnTake.AutoSize = true;
            this.radioBtnTake.Location = new System.Drawing.Point(159, 3);
            this.radioBtnTake.MinimumSize = new System.Drawing.Size(150, 30);
            this.radioBtnTake.Name = "radioBtnTake";
            this.radioBtnTake.Size = new System.Drawing.Size(150, 30);
            this.radioBtnTake.TabIndex = 1;
            this.radioBtnTake.TabStop = true;
            this.radioBtnTake.Text = "Take away";
            this.radioBtnTake.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(122, 695);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(291, 40);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.AlternateBackColor = System.Drawing.Color.White;
            this.treeViewMenu.BackColor = System.Drawing.Color.White;
            this.treeViewMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeViewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewMenu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeViewMenu.HideSelection = false;
            this.treeViewMenu.ItemHeight = 40;
            this.treeViewMenu.LineColor = System.Drawing.Color.White;
            this.treeViewMenu.Location = new System.Drawing.Point(12, 88);
            this.treeViewMenu.MinimumSize = new System.Drawing.Size(100, 100);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Node2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Node0";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeViewMenu.ShowLines = false;
            this.treeViewMenu.Size = new System.Drawing.Size(295, 711);
            this.treeViewMenu.TabIndex = 3;
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterSelect);
            // 
            // flowLayoutHeader
            // 
            this.flowLayoutHeader.Controls.Add(this.btnCart);
            this.flowLayoutHeader.Controls.Add(this.btnLogOut);
            this.flowLayoutHeader.Controls.Add(this.panelSearch);
            this.flowLayoutHeader.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutHeader.Location = new System.Drawing.Point(330, -2);
            this.flowLayoutHeader.Name = "flowLayoutHeader";
            this.flowLayoutHeader.Size = new System.Drawing.Size(1275, 58);
            this.flowLayoutHeader.TabIndex = 7;
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(1198, 2);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(77, 55);
            this.btnCart.TabIndex = 0;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(1018, 10);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 10, 30, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 14, 0);
            this.btnLogOut.Size = new System.Drawing.Size(147, 40);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtBoxSearch);
            this.panelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSearch.Location = new System.Drawing.Point(536, 6);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 6, 60, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(419, 44);
            this.panelSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(367, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(1, 0);
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(100, 47);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(355, 23);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Opacity = 0;
            this.transparentPanel1.Size = new System.Drawing.Size(200, 100);
            this.transparentPanel1.TabIndex = 0;
            //
            // CashierMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 831);
            this.Controls.Add(this.transPanelCart);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.treeViewMenu);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.flowLayoutHeader);
            this.Controls.Add(this.panelCashierName);
            this.Location = new System.Drawing.Point(9, 0);
            this.Name = "CashierMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = StandardizedNames.form_name;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierMenuPage_Load);
            this.panelCashierName.ResumeLayout(false);
            this.panelCashierName.PerformLayout();
            this.transPanelCart.ResumeLayout(false);
            this.flowPanelCart.ResumeLayout(false);
            this.flowPanelCart.PerformLayout();
            this.panelSubTotal.ResumeLayout(false);
            this.panelSubTotal.PerformLayout();
            this.panelTaxTxt.ResumeLayout(false);
            this.panelTaxTxt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowPanelRadio.ResumeLayout(false);
            this.flowPanelRadio.PerformLayout();
            this.flowLayoutHeader.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCart;
        private Components.CustomTreeView treeViewMenu;
        private Components.RoundButton btnLogOut;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private Components.BorderFlowLayoutPane flowLayoutHeader;
        private System.Windows.Forms.Panel panelLine;
        private Components.RoundButton btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.Panel panelCashierName;
        private Components.BorderFlowLayoutPane flowPanelCart;
        private System.Windows.Forms.Label lblShopCart;
        private System.Windows.Forms.Panel panelLineUnderCart;
        private System.Windows.Forms.Label lblClearItem;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCartItem;
        private System.Windows.Forms.Panel panelSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSubTotalTxt;
        private System.Windows.Forms.Panel panelTaxTxt;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTxt;
        private System.Windows.Forms.FlowLayoutPanel flowPanelRadio;
        private System.Windows.Forms.RadioButton radioBtnDine;
        private System.Windows.Forms.RadioButton radioBtnTake;
        private Components.RoundButton btnCheckout;
        private Components.TransparentPanel transparentPanel1;
        private Components.TransparentPanel transPanelCart;
    }
}