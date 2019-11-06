namespace CafeSystem.Forms
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
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMenuPage));
            this.panelLine = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.treeViewMenu = new CafeSystem.Components.CustomTreeView();
            this.flowLayoutHeader = new CafeSystem.Components.BorderFlowLayoutPane();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnLogOut = new CafeSystem.Components.RoundButton();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new CafeSystem.Components.RoundButton();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
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
            treeNode49.Name = "Node1";
            treeNode49.Text = "Node1";
            treeNode50.Name = "Node2";
            treeNode50.Text = "Node2";
            treeNode51.Name = "Node3";
            treeNode51.Text = "Node3";
            treeNode52.Name = "Node4";
            treeNode52.Text = "Node4";
            treeNode53.Name = "Node5";
            treeNode53.Text = "Node5";
            treeNode54.Name = "Node6";
            treeNode54.Text = "Node6";
            treeNode55.Name = "Node7";
            treeNode55.Text = "Node7";
            treeNode56.Name = "Node0";
            treeNode56.Text = "Node0";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode56});
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
            this.flowLayoutHeader.Location = new System.Drawing.Point(-2, -2);
            this.flowLayoutHeader.Name = "flowLayoutHeader";
            this.flowLayoutHeader.Size = new System.Drawing.Size(1607, 58);
            this.flowLayoutHeader.TabIndex = 7;
            // 
            // btnCart
            // 
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(1530, 2);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(77, 55);
            this.btnCart.TabIndex = 0;
            this.btnCart.UseVisualStyleBackColor = true;
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
            this.btnLogOut.Location = new System.Drawing.Point(1350, 10);
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
            this.panelSearch.Location = new System.Drawing.Point(868, 6);
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
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(1, 0);
            this.txtBoxSearch.MinimumSize = new System.Drawing.Size(100, 47);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(355, 23);
            this.txtBoxSearch.TabIndex = 0;
            // 
            // CashierMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 831);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.treeViewMenu);
            this.Controls.Add(this.flowLayoutHeader);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Name = "CashierMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierMenuPage_Load);
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
    }
}