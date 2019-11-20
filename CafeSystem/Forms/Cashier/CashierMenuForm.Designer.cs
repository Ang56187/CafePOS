namespace CafeSystem.Forms.Cashier
{
    partial class CashierMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMenuForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Pastry");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sides");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Food", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Coffee");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Tea");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Beverage", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.panelCashierName = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.btnEndBusiness = new CafeSystem.Components.RoundButton();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowPanelRadio = new System.Windows.Forms.FlowLayoutPanel();
            this.radioBtnDine = new System.Windows.Forms.RadioButton();
            this.radioBtnTake = new System.Windows.Forms.RadioButton();
            this.btnCheckout = new CafeSystem.Components.RoundButton();
            this.flowLayoutHeader = new CafeSystem.Components.BorderFlowLayoutPane();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new CafeSystem.Components.RoundButton();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.treeViewMenu = new CafeSystem.Components.CustomTreeView();
            this.panelCashierName.SuspendLayout();
            this.flowPanelCart.SuspendLayout();
            this.panelSubTotal.SuspendLayout();
            this.panelTaxTxt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowPanelRadio.SuspendLayout();
            this.flowLayoutHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.AutoScroll = true;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(315, 114);
            this.flowLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(1229, 838);
            this.flowLayoutPanelMenu.TabIndex = 9;
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.BackColor = System.Drawing.Color.Transparent;
            this.lblCashierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.Color.White;
            this.lblCashierName.Location = new System.Drawing.Point(12, 22);
            this.lblCashierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(187, 25);
            this.lblCashierName.TabIndex = 0;
            this.lblCashierName.Text = "Cashier: Name here";
            this.lblCashierName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCashierName
            // 
            this.panelCashierName.BackColor = System.Drawing.Color.DarkGray;
            this.panelCashierName.Controls.Add(this.lblCashierName);
            this.panelCashierName.Location = new System.Drawing.Point(-1, 0);
            this.panelCashierName.Margin = new System.Windows.Forms.Padding(4);
            this.panelCashierName.Name = "panelCashierName";
            this.panelCashierName.Size = new System.Drawing.Size(421, 71);
            this.panelCashierName.TabIndex = 10;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Silver;
            this.panelLine.Location = new System.Drawing.Point(276, 111);
            this.panelLine.Margin = new System.Windows.Forms.Padding(4);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(3, 800);
            this.panelLine.TabIndex = 13;
            // 
            // btnEndBusiness
            // 
            this.btnEndBusiness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnEndBusiness.FlatAppearance.BorderSize = 0;
            this.btnEndBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndBusiness.ForeColor = System.Drawing.Color.White;
            this.btnEndBusiness.Image = global::CafeSystem.Properties.Resources.bill_48;
            this.btnEndBusiness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndBusiness.Location = new System.Drawing.Point(10, 850);
            this.btnEndBusiness.Margin = new System.Windows.Forms.Padding(4);
            this.btnEndBusiness.Name = "btnEndBusiness";
            this.btnEndBusiness.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnEndBusiness.Size = new System.Drawing.Size(259, 65);
            this.btnEndBusiness.TabIndex = 14;
            this.btnEndBusiness.Text = "End the day";
            this.btnEndBusiness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndBusiness.UseVisualStyleBackColor = false;
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
            this.flowPanelCart.Controls.Add(this.panel2);
            this.flowPanelCart.Controls.Add(this.flowPanelRadio);
            this.flowPanelCart.Controls.Add(this.btnCheckout);
            this.flowPanelCart.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowPanelCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPanelCart.Location = new System.Drawing.Point(1397, 0);
            this.flowPanelCart.Margin = new System.Windows.Forms.Padding(4, 4, 11, 4);
            this.flowPanelCart.Name = "flowPanelCart";
            this.flowPanelCart.Size = new System.Drawing.Size(527, 1010);
            this.flowPanelCart.TabIndex = 11;
            // 
            // lblShopCart
            // 
            this.lblShopCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShopCart.AutoSize = true;
            this.lblShopCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopCart.Location = new System.Drawing.Point(6, 12);
            this.lblShopCart.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.lblShopCart.MaximumSize = new System.Drawing.Size(491, 55);
            this.lblShopCart.MinimumSize = new System.Drawing.Size(500, 55);
            this.lblShopCart.Name = "lblShopCart";
            this.lblShopCart.Size = new System.Drawing.Size(500, 55);
            this.lblShopCart.TabIndex = 0;
            this.lblShopCart.Text = "Shopping cart";
            this.lblShopCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLineUnderCart
            // 
            this.panelLineUnderCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelLineUnderCart.BackColor = System.Drawing.Color.Silver;
            this.panelLineUnderCart.Location = new System.Drawing.Point(56, 71);
            this.panelLineUnderCart.Margin = new System.Windows.Forms.Padding(4);
            this.panelLineUnderCart.MaximumSize = new System.Drawing.Size(120, 4);
            this.panelLineUnderCart.MinimumSize = new System.Drawing.Size(400, 4);
            this.panelLineUnderCart.Name = "panelLineUnderCart";
            this.panelLineUnderCart.Size = new System.Drawing.Size(400, 4);
            this.panelLineUnderCart.TabIndex = 1;
            // 
            // lblClearItem
            // 
            this.lblClearItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClearItem.AutoSize = true;
            this.lblClearItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearItem.Location = new System.Drawing.Point(386, 84);
            this.lblClearItem.Margin = new System.Windows.Forms.Padding(4, 5, 11, 0);
            this.lblClearItem.MinimumSize = new System.Drawing.Size(109, 31);
            this.lblClearItem.Name = "lblClearItem";
            this.lblClearItem.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.lblClearItem.Size = new System.Drawing.Size(116, 31);
            this.lblClearItem.TabIndex = 2;
            this.lblClearItem.Text = "clear items";
            this.lblClearItem.Click += new System.EventHandler(this.lblClearItem_Click);
            // 
            // flowPanelCartItem
            // 
            this.flowPanelCartItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowPanelCartItem.AutoScroll = true;
            this.flowPanelCartItem.Location = new System.Drawing.Point(4, 119);
            this.flowPanelCartItem.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanelCartItem.Name = "flowPanelCartItem";
            this.flowPanelCartItem.Size = new System.Drawing.Size(505, 604);
            this.flowPanelCartItem.TabIndex = 3;
            // 
            // panelSubTotal
            // 
            this.panelSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelSubTotal.Controls.Add(this.lblSubTotal);
            this.panelSubTotal.Controls.Add(this.lblSubTotalTxt);
            this.panelSubTotal.Location = new System.Drawing.Point(23, 731);
            this.panelSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.panelSubTotal.Name = "panelSubTotal";
            this.panelSubTotal.Size = new System.Drawing.Size(467, 30);
            this.panelSubTotal.TabIndex = 4;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubTotal.Location = new System.Drawing.Point(267, 0);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(200, 30);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "RM 0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalTxt
            // 
            this.lblSubTotalTxt.AutoSize = true;
            this.lblSubTotalTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSubTotalTxt.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotalTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotalTxt.MinimumSize = new System.Drawing.Size(189, 30);
            this.lblSubTotalTxt.Name = "lblSubTotalTxt";
            this.lblSubTotalTxt.Size = new System.Drawing.Size(189, 30);
            this.lblSubTotalTxt.TabIndex = 0;
            this.lblSubTotalTxt.Text = "Sub-Total:";
            this.lblSubTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTaxTxt
            // 
            this.panelTaxTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelTaxTxt.Controls.Add(this.lblTax);
            this.panelTaxTxt.Controls.Add(this.lblTaxTxt);
            this.panelTaxTxt.Location = new System.Drawing.Point(22, 769);
            this.panelTaxTxt.Margin = new System.Windows.Forms.Padding(4);
            this.panelTaxTxt.Name = "panelTaxTxt";
            this.panelTaxTxt.Size = new System.Drawing.Size(469, 30);
            this.panelTaxTxt.TabIndex = 5;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTax.Location = new System.Drawing.Point(269, 0);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(200, 30);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "RM 0.00";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxTxt
            // 
            this.lblTaxTxt.AutoSize = true;
            this.lblTaxTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaxTxt.Location = new System.Drawing.Point(0, 0);
            this.lblTaxTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxTxt.MinimumSize = new System.Drawing.Size(189, 30);
            this.lblTaxTxt.Name = "lblTaxTxt";
            this.lblTaxTxt.Size = new System.Drawing.Size(189, 30);
            this.lblTaxTxt.TabIndex = 0;
            this.lblTaxTxt.Text = "Service tax(6%):";
            this.lblTaxTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblTotalTxt);
            this.panel1.Location = new System.Drawing.Point(22, 807);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 30);
            this.panel1.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Location = new System.Drawing.Point(269, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 30);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "RM 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalTxt
            // 
            this.lblTotalTxt.AutoSize = true;
            this.lblTotalTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalTxt.Location = new System.Drawing.Point(0, 0);
            this.lblTotalTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTxt.MinimumSize = new System.Drawing.Size(189, 30);
            this.lblTotalTxt.Name = "lblTotalTxt";
            this.lblTotalTxt.Size = new System.Drawing.Size(189, 30);
            this.lblTotalTxt.TabIndex = 0;
            this.lblTotalTxt.Text = "Total:";
            this.lblTotalTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(190, 845);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.MaximumSize = new System.Drawing.Size(67, 4);
            this.panel2.MinimumSize = new System.Drawing.Size(133, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 4);
            this.panel2.TabIndex = 10;
            // 
            // flowPanelRadio
            // 
            this.flowPanelRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowPanelRadio.Controls.Add(this.radioBtnDine);
            this.flowPanelRadio.Controls.Add(this.radioBtnTake);
            this.flowPanelRadio.Location = new System.Drawing.Point(46, 857);
            this.flowPanelRadio.Margin = new System.Windows.Forms.Padding(4);
            this.flowPanelRadio.Name = "flowPanelRadio";
            this.flowPanelRadio.Size = new System.Drawing.Size(421, 59);
            this.flowPanelRadio.TabIndex = 7;
            // 
            // radioBtnDine
            // 
            this.radioBtnDine.AutoSize = true;
            this.radioBtnDine.Location = new System.Drawing.Point(4, 4);
            this.radioBtnDine.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnDine.MinimumSize = new System.Drawing.Size(200, 37);
            this.radioBtnDine.Name = "radioBtnDine";
            this.radioBtnDine.Size = new System.Drawing.Size(200, 37);
            this.radioBtnDine.TabIndex = 0;
            this.radioBtnDine.TabStop = true;
            this.radioBtnDine.Text = "Dine-in";
            this.radioBtnDine.UseVisualStyleBackColor = true;
            // 
            // radioBtnTake
            // 
            this.radioBtnTake.AutoSize = true;
            this.radioBtnTake.Location = new System.Drawing.Point(212, 4);
            this.radioBtnTake.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnTake.MinimumSize = new System.Drawing.Size(200, 37);
            this.radioBtnTake.Name = "radioBtnTake";
            this.radioBtnTake.Size = new System.Drawing.Size(200, 37);
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
            this.btnCheckout.Location = new System.Drawing.Point(62, 926);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(388, 49);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // flowLayoutHeader
            // 
            this.flowLayoutHeader.Controls.Add(this.panelSearch);
            this.flowLayoutHeader.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutHeader.Location = new System.Drawing.Point(420, 0);
            this.flowLayoutHeader.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutHeader.Name = "flowLayoutHeader";
            this.flowLayoutHeader.Size = new System.Drawing.Size(1103, 71);
            this.flowLayoutHeader.TabIndex = 7;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtBoxSearch);
            this.panelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelSearch.Location = new System.Drawing.Point(465, 7);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4, 7, 80, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(558, 54);
            this.panelSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(489, 1);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 48);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(1, 0);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(133, 47);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(133, 29);
            this.txtBoxSearch.TabIndex = 0;
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
            this.btnLogOut.Location = new System.Drawing.Point(10, 774);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 12, 40, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(13, 0, 3, 0);
            this.btnLogOut.Size = new System.Drawing.Size(259, 68);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            this.treeViewMenu.Location = new System.Drawing.Point(16, 108);
            this.treeViewMenu.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewMenu.MinimumSize = new System.Drawing.Size(133, 123);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.Name = "Pastry";
            treeNode1.Text = "Pastry";
            treeNode2.Name = "Sides";
            treeNode2.Text = "Sides";
            treeNode3.Name = "Food";
            treeNode3.Text = "Food";
            treeNode4.Name = "Coffee";
            treeNode4.Text = "Coffee";
            treeNode5.Name = "Tea";
            treeNode5.Text = "Tea";
            treeNode6.Name = "Beverage";
            treeNode6.Text = "Beverage";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeViewMenu.ShowLines = false;
            this.treeViewMenu.Size = new System.Drawing.Size(232, 490);
            this.treeViewMenu.TabIndex = 3;
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterSelect);
            // 
            // CashierMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnEndBusiness);
            this.Controls.Add(this.flowPanelCart);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.flowLayoutHeader);
            this.Controls.Add(this.panelCashierName);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.treeViewMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierMenuForm";
            this.Text = "Sunway Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierMenuPage_Load);
            this.panelCashierName.ResumeLayout(false);
            this.panelCashierName.PerformLayout();
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
        private Components.RoundButton btnLogOut;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private Components.BorderFlowLayoutPane flowLayoutHeader;
        private Components.RoundButton btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.Panel panelCashierName;
        private Components.CustomTreeView treeViewMenu;
        private System.Windows.Forms.Panel panelLine;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowPanelRadio;
        private System.Windows.Forms.RadioButton radioBtnDine;
        private System.Windows.Forms.RadioButton radioBtnTake;
        private Components.RoundButton btnCheckout;
        private Components.RoundButton btnEndBusiness;
    }
}